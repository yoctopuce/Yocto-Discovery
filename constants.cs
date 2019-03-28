
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

namespace YoctoDiscovery
{
  class constants
  {

    public static string buildVersion = "34827";
 

    public static bool _OSX_Running = (Environment.OSVersion.Platform == PlatformID.Unix &&
                                       Directory.Exists("/Applications") && Directory.Exists("/System") &&
                                       Directory.Exists("/Users") && Directory.Exists("/Volumes"));
    public static bool OSX_Running { get { return _OSX_Running; } }
    private static bool  _MonoRunning = (Type.GetType ("Mono.Runtime") != null);
		public static bool MonoRunning {get {return  _MonoRunning;}}
    private static string MonoMinVersion { get { return "4.0"; }} 
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
            return "unknow";
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
       for (int i=0;i< Math.Min(requirement.Length, value.Length); i++)
       {
        if  (Int32.Parse(value[i])< Int32.Parse(requirement[i]))
        {
          errmsg = "Yocto-Discovery requires at least Mono " + MonoMinVersion + ", installed version is " + MonoVersion;
          return false;
        }

       }


       return true;


    }



   

  }
}
