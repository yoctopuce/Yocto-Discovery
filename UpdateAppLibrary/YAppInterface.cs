using System;


namespace UpdateAppLibrary
{
    public interface YAppInterface
    {
        // return the full version string (1.10.1234)
        string GetVersion();
        // function called just before starting the MSI
        void StopRunningProcess();
        // return the platform (Windows, Linux, Mac-OS-X, MSI)
        string GetPlatform();
        // return the application name (Yocto-Visualization,....)
        string GetAppName();
        // setter and getter for the settings parameters        
        // GetCheckUpdateSettings must return the boolean settings
        bool GetCheckUpdateSettings();
        // SetBuildNumberToIgnoreSettings must save the value in the settings 
        void SetCheckUpdateSettings(bool newval);
        // GetCheckUpdateSettings must return the integer value 
        int GetBuildNumberToIgnoreSettings();
        // SetBuildNumberToIgnoreSettings must save the value in the settings 
        void SetBuildNumberToIgnoreSettings(int buildnumber);
    }
}