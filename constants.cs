
/*
 *   Yocto-Discovery, a free application to locate Yoctopuce devices.
 * 
 *  some global constant and framework version management
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

using System.IO;

using System.Reflection;
using System.Windows.Forms;
using System.Xml;

namespace YoctoDiscovery
{
  class constants
  {

    public static string buildVersion = "35622";
    private static string _configfile = Path.Combine(Application.UserAppDataPath, "config.xml");
    // note : automatic check for updates is not implemented on the GitHub version.
    private static bool _forceCheckForUpdate = false;
    private static bool _checkforUpdate = true;
    public static bool checkForUpdate { get { return _checkforUpdate || _forceCheckForUpdate; } set { _checkforUpdate = value; } }
    private static int _UpdateIgnoreBuild = 0;
    public static int updateIgnoreBuild { get { return _UpdateIgnoreBuild; } set { _UpdateIgnoreBuild = value; } }


    public static bool _OSX_Running = (Environment.OSVersion.Platform == PlatformID.Unix &&
                                       Directory.Exists("/Applications") && Directory.Exists("/System") &&
                                       Directory.Exists("/Users") && Directory.Exists("/Volumes"));
    public static bool OSX_Running { get { return _OSX_Running; } }
    private static bool _MonoRunning = (Type.GetType("Mono.Runtime") != null);
    public static bool MonoRunning { get { return _MonoRunning; } }
    private static string MonoMinVersion { get { return "4.0"; } }
    public static string MonoVersion
    {
      get
      {
        Type type = Type.GetType("Mono.Runtime");
        if (type != null)
        {
          MethodInfo displayName = type.GetMethod("GetDisplayName", BindingFlags.NonPublic | BindingFlags.Static);
          if (displayName != null)
            return displayName.Invoke(null, null).ToString();
          else
            return "unknown";
        }
        return "Not in Mono";
      }
    }


    public static bool CheckMonoVersion(out string errmsg)
    {
      errmsg = "";
      if (!MonoRunning) return true;
      string[] requirement = MonoMinVersion.Split(new[] { "." }, StringSplitOptions.None);
      string[] value = MonoVersion.Split(new[] { " " }, StringSplitOptions.None)[0].Split(new[] { "." }, StringSplitOptions.None);
      for (int i = 0; i < Math.Min(requirement.Length, value.Length); i++)
      {
        if (Int32.Parse(value[i]) < Int32.Parse(requirement[i]))
        {
          errmsg = "Yocto-Discovery requires at least Mono " + MonoMinVersion + ", installed version is " + MonoVersion;
          return false;
        }

      }
      return true;
    }

    public static void init(String[] args)
    {
      for (int i = 0; i < args.Length; i++)
      {
        if (args[i] == "-check4updates")
          _forceCheckForUpdate = true;
      }
      LoadConfig();
    }


    public static void InitCheckForUpdateParams(XmlNode memNode)
    {
      foreach (XmlNode node in memNode.ChildNodes)
      {
        switch (node.Name)
        {
          case "checkForUpdate":
            bool bvalue;
            if (bool.TryParse(node.Attributes["value"].InnerText, out bvalue)) checkForUpdate = bvalue;
            break;

          case "ignoreBuild":
            int ivalue;
            if (Int32.TryParse(node.Attributes["value"].InnerText, out ivalue)) updateIgnoreBuild = ivalue;
            break;

        }
      }
    }



    public static string GetXMLConfiguration()
    {
      string res = "<Config>\n";
      res += "  <Updates>\n";
      res += "    <checkForUpdate  value = \"" + constants.checkForUpdate.ToString() + "\"/>\n";
      res += "    <ignoreBuild  value = \"" + constants.updateIgnoreBuild.ToString() + "\"/>\n";
      res += "  </Updates>\n";
      res += "</Config>\n";
      return res;
    }

    public static void SaveConfig()
    {
      string XmlConfigFile = "<?xml version=\"1.0\" ?>\n<ROOT version='1'>\n";
      XmlConfigFile += constants.GetXMLConfiguration();
      XmlConfigFile += "</ROOT>\n";
      try
      {
        TextWriter tw = File.CreateText(_configfile);
        tw.WriteLine(XmlConfigFile);
        tw.Close();
      }
      catch (Exception e)
      {
        MessageBox.Show("Can't save configuration file:\n" + e.Message + "\nSorry.");
      }
    }

    public static void LoadConfig()
    {
      if (File.Exists(_configfile))
      {
        XmlDocument doc = new XmlDocument();
        doc.Load(_configfile);
        foreach (XmlNode node in doc.DocumentElement.ChildNodes)
        {
          switch (node.Name)
          {
            case "Config":
              foreach (XmlNode snode in node.ChildNodes)
              {
                switch (snode.Name)
                {
                  case "Updates":
                    InitCheckForUpdateParams(snode);
                    break;
                }
              }
              break;
          }
        }
      }
    }
  }
}
