# Yocto-Discovery

Yocto-Discovery is a simple C# .Net application able to discover [Yoctopuce](https://www.yoctopuce.com) devices present on local network. This application is mainly read-only, the only allowed interaction is switching the devices Yocto-Beacon. The application features a search function allowing to quickly find a specific device based on any of its property.  

This application runs on Windows, Linux and macOS.

![Screenshot example](http://www.yoctopuce.com/pubarchive/2018-09/Yocto-Discovery-ScreenShot_1.png)

You will find more information about this application on [Yoctopuce website](http://www.yoctopuce.com/EN/article/nouvelle-application-yocto-discovery). If you are not much into programming and are only interested in installing Yocto-Discovery, here is a page linking to [Windows, Linux and macOS binaries](https://www.yoctopuce.com/EN/tools.php) .


## Source code installation
Extract the project files wherever you want.

### On Windows
Open the *.csprog* project with at least Visual-Studio 2015, that's it. Adaptation for  previous version of Visual-Studio should be possible at the cost of some minor rework. The application only requires .Net 3.5 and can run on Windows XP.

### On Linux
Make sure that Mono is installed (min version 4) as well as Mono-Develop (min version 5) and open the  *.csprog* project with Mono-Develop. Avoid the flatpak based Mono-Develop version as it is sand-boxed and can't access to the libusb. 

### On macOS 
Install Mono for macOS (Visual Studio channel) and Visual Studio for macOS and open the *.csprog* project with Visual Studio.