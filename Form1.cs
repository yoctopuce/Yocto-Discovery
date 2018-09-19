
/*
 *   Yocto-Discovery, a free application to locate Yoctopuce devices.
 * 
 *  Main form
 * 
 *   - - - - - - - - - License information: - - - - - - - - -
 *
 *  Copyright (C) 2017 and beyond by Yoctopuce Sarl, Switzerland.
 *
 *  Yoctopuce Sarl (hereafter Licensor) grants to you a perpetual
 *  non-exclusive license to use, modify, copy and integrate this
 *  file into your software for the sole purpose of interfacing
 *  with Yoctopuce products.
 *
 *  You may reproduce and distribute copies of this file in
 *  source or object form, as long as the sole purpose of this
 *  code is to interface with Yoctopuce products. You must retain
 *  this notice in the distributed source file.
 *
 *  You should refer to Yoctopuce General Terms and Conditions
 *  for additional information regarding your rights and
 *  obligations.
 *
 *  THE SOFTWARE AND DOCUMENTATION ARE PROVIDED "AS IS" WITHOUT
 *  WARRANTY OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING
 *  WITHOUT LIMITATION, ANY WARRANTY OF MERCHANTABILITY, FITNESS
 *  FOR A PARTICULAR PURPOSE, TITLE AND NON-INFRINGEMENT. IN NO
 *  EVENT SHALL LICENSOR BE LIABLE FOR ANY INCIDENTAL, SPECIAL,
 *  INDIRECT OR CONSEQUENTIAL DAMAGES, LOST PROFITS OR LOST DATA,
 *  COST OF PROCUREMENT OF SUBSTITUTE GOODS, TECHNOLOGY OR
 *  SERVICES, ANY CLAIMS BY THIRD PARTIES (INCLUDING BUT NOT
 *  LIMITED TO ANY DEFENSE THEREOF), ANY CLAIMS FOR INDEMNITY OR
 *  CONTRIBUTION, OR OTHER SIMILAR COSTS, WHETHER ASSERTED ON THE
 *  BASIS OF CONTRACT, TORT (INCLUDING NEGLIGENCE), BREACH OF
 *  WARRANTY, OR OTHERWISE.
 */


using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace YoctoDiscovery
{
  public delegate void appendLogCallback(string text);
  public delegate void moduleChangeCallBack(Device d);

  public partial class Form1 : Form
  {
    const int OFFLINE_ICON = 0;
    const int ONLINE_ICON  = 1;
    const int BEACON_ICON  = 2;
    const int ERROR_ICON   = 3;
    Device _currentDevice  = null;

    Yscanner scanner = null;
    Dictionary<string,Tuple< TreeNode,  Device>> nodeList = new Dictionary<string, Tuple<TreeNode, Device>>();

   void SearchForDevices(string param)
    {
      if (param=="")
      {
        foreach (var n in nodeList)
          n.Value.Item1.ForeColor = Color.Black;
        searchresult.Text = "";

        return;
      }
      int count = 0;
      foreach (var n in nodeList)
      {
        if (n.Value.Item2.matchSearch(param))
        {
          n.Value.Item1.ForeColor = Color.Black;
          n.Value.Item1.EnsureVisible();
          count++;

        }
        else n.Value.Item1.ForeColor = Color.LightGray;

        if (count ==0) searchresult.Text = "No match found";
        else if (count == 1) searchresult.Text = "One match found";
        else  searchresult.Text = count.ToString()+ " matches found";



      }




    }


   public TreeNode FindNodeByName( string name)
    {
      if (!nodeList.ContainsKey(name)) return null;
      return nodeList[name].Item1;
    }

   public Device FindDeviceByname(TreeNode t)     
    { foreach(var n in nodeList)
      {  if (n.Value.Item1 == t) return n.Value.Item2;

      }
      return null;
    }


    public int computeIconIndex(Device d)
    {
      if (d.isUsbRoot)
      {
        return (d.isOnline) ? ONLINE_ICON : ERROR_ICON;

      }

      return d.beaconActive ? BEACON_ICON : (d.isOnline ? ONLINE_ICON : OFFLINE_ICON); 

    }

    public void moduleChange(Device d)
    {
      if (DeviceTree.InvokeRequired)
      {
        moduleChangeCallBack c = new moduleChangeCallBack(moduleChange);
        Invoke(c, new object[] { d });
      }
      else
      {
        if (d.isNetworkDevice)
         {
           TreeNode n = FindNodeByName( d.serialNumber);
           if (n == null)
            {
              n = new TreeNode();
              n.Name = d.serialNumber;
              DeviceTree.Nodes.Add(n);
              nodeList[d.serialNumber] = new Tuple<TreeNode, Device>(n, d);
             }
            n.Text = d.friendlyName;
            n.ImageIndex = computeIconIndex(d);
            n.SelectedImageIndex = n.ImageIndex;
        }
       else 
        {
          TreeNode p = null;
          if (d.parentHub != "")
          {
            TreeNode pNode = FindNodeByName(d.parentHub);
             p = pNode;
            foreach (TreeNode subnode in pNode.Nodes)
            {
              Device subDevice = nodeList[subnode.Name].Item2;
              if (subDevice.isShieldDevice)
              {
                if (subDevice.isConnectedTo(d.serialNumber))
                {
                  p = subnode;
                }
              }
            }
          }

          TreeNode n = FindNodeByName(d.serialNumber);
          if (n == null)
          {
            n = new TreeNode();
            n.Name = d.serialNumber;
            if (p != null) p.Nodes.Add(n); else DeviceTree.Nodes.Add(n);
            nodeList[d.serialNumber] = new Tuple<TreeNode, Device>(n, d);
          }
          else
          { if (n.Parent!=p)
            {
              n.Remove();
              if (p != null) p.Nodes.Add(n); else DeviceTree.Nodes.Add(n);

            }


          }


          n.ImageIndex = computeIconIndex(d);
          n.SelectedImageIndex = n.ImageIndex;
          n.Text = d.friendlyName;
        }

        if (d == _currentDevice) showDevice(d);
      }
    }

    public void log(string msg)
    {
      try
      { 
        if (logPanel.InvokeRequired)
        {
          appendLogCallback d = new appendLogCallback(log);
          Invoke(d, new object[] { msg });
        }
        else
        { 
          logPanel.AppendText(DateTime.Now.ToString("yyyy/MM/dd h:mm:ss.ff") + ' ' + msg + "\r\n");      
        }
      }  catch (Exception) { }
    }

    public Form1()
    {
      InitializeComponent();

      showDevice(null);
      scanner = new Yscanner(log, moduleChange);

    }

      private void Form1_Load(object sender, EventArgs e)
    {

      log("Application start, Welcome to Yocto-Discovery.");

     
      log("Yocto-Discovery version is " + constants.buildVersion);
      log("Yoctopuce API version is " + YAPI.GetAPIVersion());
      log("Architecture is " + (IntPtr.Size * 8).ToString() + " bits (platform " + Environment.OSVersion.Platform.ToString() + ")");

      if (constants.MonoRunning)
      {
        if (constants.OSX_Running)
        {
          log("Mono version is " + constants.MonoVersion + " (Mac OS X)");
        }
        else
        {
          log("Mono version is " + constants.MonoVersion);
        }
      }
      else
      {
        log("Running on .NET");

      }

      scanner.Start();
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (scanner != null) scanner.Stop();
    }

    private void DeviceTree_AfterSelect(object sender, TreeViewEventArgs e)
    {

      Device d =  FindDeviceByname(e.Node);
      showDevice(d);
    }

    [DllImport("user32.dll")]
    private static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

    private const int WM_SETREDRAW = 0xB;

    public static void SuspendDrawing(Control target)
    { if (constants.OSX_Running) return;   
      SendMessage(target.Handle, WM_SETREDRAW, 0, 0); // makes Mono crash on macOS
    }

    public static void ResumeDrawing(Control target)
    {
      if (constants.OSX_Running) return;
      SendMessage(target.Handle, WM_SETREDRAW, 1, 0);  // makes Mono crash on macOS
      target.Refresh();
    }

    private void refreshFunctionList()
    {
      if (_currentDevice == null) return;
      if (!functionsPanel.Visible) return;
      List<Tuple<String, String, String>> f = _currentDevice.get_functionList();

      if (f != null)
      {
        SuspendDrawing(functionsPanel);
        while (functionList.Items.Count > f.Count) functionList.Items.RemoveAt(functionList.Items.Count - 1);

        for (int i = 0; i < f.Count; i++)
        {
          ListViewItem it;
          if (i >= functionList.Items.Count)
          {
            it = new ListViewItem();
            it.SubItems.Add(new ListViewItem.ListViewSubItem());
            it.SubItems.Add(new ListViewItem.ListViewSubItem());
            functionList.Items.Add(it);
          }
          it = functionList.Items[i];
          it.Text = f[i].Item1;
          it.SubItems[1].Text = f[i].Item2;
          it.SubItems[2].Text = _currentDevice.isOnline ? f[i].Item3 : "OFFLINE";
        }
        functionList.Visible = true;
        offlineLabel.Visible = false;
        ResumeDrawing(functionsPanel);
      }
      else
      {
        functionList.Visible = false;
        offlineLabel.Visible = true;
      }

      
    }




    


    private void showDevice(Device d)
    {
      _currentDevice = d;
      int y = 0;

      if (d==null)
      {
        devPanel.Visible = false;
        networkPanel.Visible = false;
        functionsPanel.Visible = false;
        helloPanel.Visible = true;
        helloPanel.Top = y;
        VersionLabel.Text = constants.buildVersion;

      }
      else
      if (d.serialNumber == "usb")
      {
        devPanel.Visible = false;
        networkPanel.Visible = false;
        functionsPanel.Visible = false;
        helloPanel.Visible = false;

        usbPanel.Visible = true;
        usbPanel.Top = y;
        if (!d.isOnline)
        { USBstatus.Text = "Cannot access to local USB devices (" + d.lastError + ")"; }
        else
        {
          TreeNode t = FindNodeByName("usb");
          
          if (t.Nodes.Count==0) USBstatus.Text ="No Yoctopuce device found on local USB";
          else if (t.Nodes.Count == 1) USBstatus.Text = "One Yoctopuce device found on local USB";
          else USBstatus.Text = t.Nodes.Count.ToString() + " Yoctopuce devices found on local USB";
         
        }
        y += usbPanel.Height;
      }
      else
      {
        usbPanel.Visible = false;
        devPanel.Visible = true;
        helloPanel.Visible = false;
        devPanel.Top = y;
        textBoxModel.Text = d.model;
        textBoxSerial.Text = d.serialNumber;
        textBoxLogicalName.Text = d.logicalName;
        textBoxFirmware.Text = d.firmware;
        beaconState.Text = d.beaconActive ? "on" : "off";
        BeaconLink.Text = d.beaconActive ? "Beacon off" : "Beacon on";
        BeaconLink.Visible = d.isOnline;
        textBoxStatus.Text = d.isOnline ? "online" : "offline";

        y += devPanel.Height;

        if (d.isNetworkDevice)
        {
          networkPanel.Top = y;
          networkPanel.Visible = true;
          textBoxIPAddr.Text = d.ipAddr;
          textBoxMacAddr.Text = d.macAddr;
          y += networkPanel.Height;

        }
        else networkPanel.Visible = false;


        functionsPanel.Visible = true;
        functionsPanel.Height = 400;
        functionsPanel.Top = y;

        refreshFunctionList();
        timer1.Enabled = true;

        y += networkPanel.Height;

      }
    }

    private void BeaconButton_Click(object sender, EventArgs e)
    {
      if (_currentDevice != null) _currentDevice.toggleBeacon();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      refreshFunctionList();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      searchtimer.Interval = 500;
      searchtimer.Enabled = true;
    }

    private void searchtimer_Tick(object sender, EventArgs e)
    {
      searchtimer.Enabled = false;
      SearchForDevices(SearchParam.Text);
    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {

    }

    private void label9_Click(object sender, EventArgs e)
    {
      if (_currentDevice == null) return;
      System.Diagnostics.Process.Start("http://"+ _currentDevice.ipAddr+":4444");

    }

    private void BeaconLink_Click(object sender, EventArgs e)
    {
      if (_currentDevice != null) _currentDevice.toggleBeacon();
    }
  }
}
