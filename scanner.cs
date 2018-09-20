
/*
 *   Yocto-Discovery, a free application to locate Yoctopuce devices.
 * 
 *  device scanning utility
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
using System.Linq;
using System.Text;
using System.Threading;

namespace YoctoDiscovery
{
  public delegate void logFunction(string msg);


// Emulate Tuples in .NET 3.5 (windows XP compatibility)
// Thank you Tomas Jansson @ stackoverflow
  public class Tuple<T1, T2>
  {
    public T1 Item1 { get; private set; }
    public T2 Item2 { get; private set; }
    internal Tuple(T1 first, T2 second)
    {
      Item1 = first;
      Item2 = second;
    }
  }

  public class Tuple<T1, T2, T3>
  {
    public T1 Item1 { get; private set; }
    public T2 Item2 { get; private set; }
    public T3 Item3 { get; private set; }
    internal Tuple(T1 first, T2 second, T3 third)
    {
      Item1 = first;
      Item2 = second;
      Item3 = third;

    }
  }


  public static class Tuple
  {
    public static Tuple<T1, T2> New<T1, T2>(T1 first, T2 second)
    {
      var tuple = new Tuple<T1, T2>(first, second);
      return tuple;
    }

    public static Tuple<T1, T2,T3> New<T1, T2,T3>(T1 first, T2 second,T3 third)
    {
      var tuple = new Tuple<T1, T2,T3>(first, second,third);
      return tuple;
    }

  }

  //**************



  public  class Device
  {
    YModule _module;
    String _serial="";
    String _url;

    logFunction _log;
    bool _isNetworkDevice = false;
    bool _isShieldDevice = false;
    bool _isonline = false;
    string _friendlyName = "";
    string _hardwareId = "";
    string _parentHub = "";
    string _lastError = "";
    string _model = "";
    string _logicalName = "";
    string _ipAddr = "";
    string _macAddr = "";
    string _firmware = "";


    bool _beacon = false;
    public string friendlyName { get { return _friendlyName; } }
    public string  hardwareId { get { return _hardwareId; } }
    public string serialNumber { get { return _serial; } }
    public string parentHub { get { return _parentHub; } }
    public bool beaconActive { get { return _beacon; } }

    List<int> hubPorts = new List<int>();
    List<Tuple<String, String, String>> functions = new List<Tuple<String, String, String>>(); 

    public Device(string serial, string  url, logFunction log )
     {
      _serial = serial;
      _url = url;
      _log = log;
      if (serial == "usb") _friendlyName = "Local USB";
     }


    public void toggleBeacon()
    {
      try
      {
        _module.set_beacon(_beacon ? YModule.BEACON_OFF : YModule.BEACON_ON);
      }
      catch (Exception)
      {
        _isonline = false;
      }
    }

    public bool isUsbRoot { get { return _serial == "usb"; } }
    public bool isNetworkDevice { get { return _isNetworkDevice; } }
    public bool isShieldDevice { get { return _isShieldDevice; } }
    public bool isOnline { get { return _isonline; } }
    public string lastError { get { return _lastError; } }
    public string model { get { return _model; } }
    public string macAddr { get { return _macAddr; } }
    public string ipAddr { get { return _ipAddr; } }
    public string logicalName { get { return _logicalName; } }
    public string firmware { get { return _firmware; } }


    public bool matchSearch(string param)
    { if (param == "") return false;
      param = param.ToUpper();
      if (_friendlyName.ToUpper().IndexOf(param)>=0) return true;
      if (_parentHub.ToUpper().IndexOf(param) >= 0) return true;
      if (_model.ToUpper().IndexOf(param) >= 0) return true;
      if (_logicalName.ToUpper().IndexOf(param) >= 0) return true;
      if (_ipAddr.ToUpper().IndexOf(param) >= 0) return true;
      if (_macAddr.ToUpper().IndexOf(param) >= 0) return true;
      if (_firmware.ToUpper().IndexOf(param) >= 0) return true;

      foreach (var it in functions)
       {  if (it.Item1.ToUpper().IndexOf(param) >= 0) return true;
          if (it.Item2.ToUpper().IndexOf(param) >= 0) return true;

      }

      return false;

    

    }

    public List<Tuple<String,String,String>> get_functionList()
    { if (!_isonline) return null;

      List<Tuple<String, String, String>> l = new List<Tuple<String, String, String>>();
      try
      {
       

        int count = _module.functionCount();
        for (int i = 0; i < count; i++)
          l.Add(new Tuple<string, string, string>(_module.functionId(i), _module.functionName(i), _module.functionValue(i)));
      }
      catch (Exception) { _isonline = false;  return null; }
  
 
      return l;



    }

    public void setLastError( string errmsg)
    {
     _lastError = errmsg;
    


    }


    public bool isConnectedTo(string serial)
    {
      foreach (int i in hubPorts)
      {
        if (_module.functionName(i) == serial) return true;

      }
      return false;
    }

    public void init_node(YModule m, bool online)
    {
      _module = m;
      _isonline = online;
      _isNetworkDevice = false;

      if ((_isonline) && (m != null))
      {

        bool hubPortsFound = false;
        functions.Clear();
        hubPorts.Clear();
        int count = m.functionCount();
        for (int i = 0; i < count; i++)
        {
          string id = m.functionId(i);
          string name = m.functionName(i);
          string type = m.functionType(i);

          functions.Add(new Tuple<String, String, String>(id, name, type));

          if (type == "Network") _isNetworkDevice = true;
          if (type == "HubPort")
          {
            hubPorts.Add(i);
            hubPortsFound = true;
          }


        }

        if (hubPortsFound && !_isNetworkDevice) _isShieldDevice = true;
        _beacon = (m.get_beacon() == YModule.BEACON_ON);
        _friendlyName = m.get_friendlyName();
        _hardwareId = m.get_hardwareId();
        _model = m.get_productName();
        _logicalName = m.get_logicalName();
        _firmware = m.get_firmwareRelease();
        _parentHub = (_url == "usb") ? "usb" : m.get_parentHub();

        if (_isNetworkDevice)
        {
          YNetwork n = YNetwork.FindNetwork(_serial + ".network");
          _ipAddr = n.get_ipAddress();
          _macAddr = n.get_macAddress();




        }

      }
      else _beacon = false;


    }

    }


  


 public  class Yscanner
  {

    Dictionary<String, Device> Devices;
    logFunction _log = null;
    bool _running = false;
    public bool mustStop = false;
    bool _usbConnected = false;

    Thread scanThread;
    moduleChangeCallBack _changeCallback;

    void log(string msg)
    { if (_log == null)  return;
      _log(msg);

    }

    bool usbConnected { get { return _usbConnected; } }

    private void arrival(YModule m)
    { log("Device arrival " + m.get_serialNumber());
      string serial = m.get_serialNumber();
      string url = m.get_url();

      Device d;
      if (!Devices.ContainsKey(serial))
      {
       
        d = new Device(serial, url, _log);
        Devices[serial] = d;
      } 
      else d = Devices[serial];
      d.init_node(m,true);
      _changeCallback(d);
      m.registerConfigChangeCallback(deviceConfigChange);

    }

    private void removal(YModule m)
    { log("Device removal " + m.get_serialNumber());
      string serial = m.get_serialNumber();
      if (Devices.ContainsKey(serial))
      {
        Device d = Devices[serial];
        d.init_node(m, false);
        _changeCallback(d);
      }

    }

    private void deviceConfigChange(YModule m)
    { log("Device change " + m.get_serialNumber());
      string serial = m.get_serialNumber();
      if (Devices.ContainsKey(serial))
      {
        Device d = Devices[serial];
        d.init_node(m, true);
        _changeCallback(d);
      }

    }

  





    public Yscanner(logFunction log, moduleChangeCallBack changeCallback )
    { _log = log;
      _changeCallback = changeCallback;
      Devices = new Dictionary<String, Device>();


    }


    public void Start()
     {  if (_running) return;
        _running = true;
        scanThread = new Thread(new ThreadStart(Run));
        scanThread.Start();
    }

    public void Stop()
    {
      if (!_running) return;
      mustStop = true;
    }



    private  void Run()
    {
      log("Scan thread starting..");
      string errmsg = "";
      if (YAPI.InitAPI(YAPI.DETECT_NONE, ref errmsg) != YAPI.SUCCESS)
      {
        log("Fatal Error : Yocto Init API failed : " + errmsg);
        return;

      }

      YAPI.RegisterDeviceArrivalCallback(arrival);
      YAPI.RegisterDeviceRemovalCallback(removal);
      YAPI.RegisterDeviceChangeCallback(deviceConfigChange);


      _usbConnected = false;

      if (YAPI.PreregisterHub("127.0.0.1", ref errmsg) != YAPI.SUCCESS)
         { log("Warning: Can't preregister 127.0.0.1 : " + errmsg); }

        Device d = new  Device("usb", "usb", _log);
      bool usbOnline = true;
      if (YAPI.PreregisterHub("usb", ref errmsg) != YAPI.SUCCESS)
      {
        log("Warning: Can't preregister USB : " + errmsg);
        d.setLastError( errmsg);
        usbOnline = false;
      } 

       d.init_node(null, usbOnline);
       _changeCallback(d);

      if (YAPI.RegisterHub("net", ref errmsg) != YAPI.SUCCESS)
      {
        log("Warning: Can't register net : " + errmsg);

      }

      YAPI.SetDeviceListValidity(3600);

     
      mustStop = false;
    
        int n = 0;
        while (!mustStop)
      { try
        {
          n++;
          if (YAPI.Sleep(100, ref errmsg) != YAPI.SUCCESS) log("Sleep  error: " + errmsg);
          if (n%10 == 0) if (YAPI.UpdateDeviceList(ref errmsg) != YAPI.SUCCESS) log("UpdateDeviceList  error: " + errmsg);
          if (n%20 == 0) if (YAPI.TriggerHubDiscovery(ref errmsg) != YAPI.SUCCESS) log("TriggerHubDiscovery  error: " + errmsg);

        }
        catch (Exception e) { log("Scanner error: " + e.Message); }
      }
    

      YAPI.FreeAPI();
      _running = false; 
    }

  }
}
