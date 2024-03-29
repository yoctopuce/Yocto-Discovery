#!/bin/bash
## builds linux binary for local platform
## requires installation of
## mono-devel   (sudo apt-get install mono-devel)
## monodevelop  (sudo apt-get install monodevelop)


rm -rf yoctodiscovery

mkdir --mode=755 yoctodiscovery/
mkdir --mode=755 yoctodiscovery/usr/
mkdir --mode=755 yoctodiscovery/usr/lib/
mkdir --mode=755 yoctodiscovery/usr/lib/Yocto-Discovery

mkdir --mode=755 yoctodiscovery/usr/bin/

mkdir --mode=755 yoctodiscovery/usr/share/
mkdir --mode=755 yoctodiscovery/usr/share/applications
mkdir --mode=755 yoctodiscovery/usr/share/pixmaps
mkdir --mode=755 yoctodiscovery/DEBIAN

mkdir --mode=755 yoctodiscovery/usr/share/icons
mkdir --mode=755 yoctodiscovery/usr/share/icons/hicolor/
mkdir --mode=755 yoctodiscovery/usr/share/icons/hicolor/16x16
mkdir --mode=755 yoctodiscovery/usr/share/icons/hicolor/16x16/apps
mkdir --mode=755 yoctodiscovery/usr/share/icons/hicolor/32x32
mkdir --mode=755 yoctodiscovery/usr/share/icons/hicolor/32x32/apps
mkdir --mode=755 yoctodiscovery/usr/share/icons/hicolor/48x48
mkdir --mode=755 yoctodiscovery/usr/share/icons/hicolor/48x48/apps
mkdir --mode=755 yoctodiscovery/usr/share/icons/hicolor//128x128
mkdir --mode=755 yoctodiscovery/usr/share/icons/hicolor//128x128/apps
mkdir --mode=755 yoctodiscovery/usr/share/icons/hicolor/256x256
mkdir --mode=755 yoctodiscovery/usr/share/icons/hicolor/256x256/apps
mkdir --mode=755 yoctodiscovery/usr/share/icons/hicolor/scalable
mkdir --mode=755 yoctodiscovery/usr/share/icons/hicolor/scalable/apps

mkdir --mode=755 yoctodiscovery/usr/share/doc
mkdir --mode=755 yoctodiscovery/usr/share/doc/yoctodiscovery


#mkdir yoctodiscovery/etc
#mkdir yocto-Discovery/etc/udev
#mkdir yocto-Discovery/etc/rules.d

#cp 51-yoctopuce_all.rules yocto-Discovery/etc/udev/rules.d
#chmod -R 644 yocto-Discovery/etc


#copy copyright
cp copyright yoctodiscovery/usr/share/doc/yoctodiscovery
chmod 644 yoctodiscovery/usr/share/doc/yoctodiscovery/copyright
cp changelog yoctodiscovery/usr/share/doc/yoctodiscovery
gzip -n -9 yoctodiscovery/usr/share/doc/yoctodiscovery/changelog
chmod 644 yoctodiscovery/usr/share/doc/yoctodiscovery/changelog.gz

#copy debian control filE
cp control yoctodiscovery/DEBIAN
#cp conffiles yoctodiscovery/DEBIAN
chmod 644 yoctodiscovery/DEBIAN/*

#copy freedesktop stuff
cp YoctoDiscovery.desktop yoctodiscovery/usr/share/applications
chmod 644 yoctodiscovery/usr/share/applications/YoctoDiscovery.desktop
cp ../artwork/icon.svg yoctodiscovery/usr/share/icons/hicolor/scalable/apps/YoctoDiscovery.svg
chmod 644 yoctodiscovery/usr/share/icons/hicolor/scalable/apps/YoctoDiscovery.svg
cp YoctoDiscovery_16.png yoctodiscovery/usr/share/icons/hicolor/16x16/apps/YoctoDiscovery.png
chmod 644 yoctodiscovery/usr/share/icons/hicolor/16x16/apps/YoctoDiscovery.png
cp YoctoDiscovery_32.png yoctodiscovery/usr/share/icons/hicolor/32x32/apps/YoctoDiscovery.png
chmod 644 yoctodiscovery/usr/share/icons/hicolor/32x32/apps/YoctoDiscovery.png
cp YoctoDiscovery_48.png yoctodiscovery/usr/share/icons/hicolor/48x48/apps/YoctoDiscovery.png
chmod 644 yoctodiscovery/usr/share/icons/hicolor/48x48/apps/YoctoDiscovery.png
cp YoctoDiscovery_128.png yoctodiscovery/usr/share/icons/hicolor//128x128/apps/YoctoDiscovery.png
chmod 644 yoctodiscovery/usr/share/icons/hicolor//128x128/apps/YoctoDiscovery.png
cp YoctoDiscovery_256.png yoctodiscovery/usr/share/icons/hicolor/256x256/apps/YoctoDiscovery.png
chmod 644 yoctodiscovery/usr/share/icons/hicolor/256x256/apps/YoctoDiscovery.png
cp YoctoDiscovery_48.png yoctodiscovery/usr/share/pixmaps/YoctoDiscovery.png
chmod 644 yoctodiscovery/usr/share/pixmaps/YoctoDiscovery.png



# copy shell script in the path
cp Yocto-Discovery yoctodiscovery/usr/bin
chmod 755 yoctodiscovery/usr/bin/Yocto-Discovery

#copy linux libs
cp ../libyapi-amd64.so yoctodiscovery/usr/lib/Yocto-Discovery
chmod 0644 yoctodiscovery/usr/lib/Yocto-Discovery/libyapi-amd64.so
cp ../libyapi-armhf.so yoctodiscovery/usr/lib/Yocto-Discovery/libyapi-armhf.so
chmod 0644 yoctodiscovery/usr/lib/Yocto-Discovery/libyapi-armhf.so
cp ../libyapi-i386.so yoctodiscovery/usr/lib/Yocto-Discovery
chmod 0644 yoctodiscovery/usr/lib/Yocto-Discovery/libyapi-i386.so
cp ../libyapi-aarch64.so yoctodiscovery/usr/lib/Yocto-Discovery
chmod 0644 yoctodiscovery/usr/lib/Yocto-Discovery/libyapi-aarch64.so

#copy binary
cp  ../bin/Release/YoctoDiscovery.exe yoctodiscovery/usr/lib/Yocto-Discovery
cp  YoctoDiscovery.exe.config yoctodiscovery/usr/lib/Yocto-Discovery
chmod 755 yoctodiscovery/usr/lib/Yocto-Discovery/YoctoDiscovery.exe
chmod 644 yoctodiscovery/usr/lib/Yocto-Discovery/YoctoDiscovery.exe.config

fakeroot dpkg-deb -Zxz --build yoctodiscovery
lintian yoctodiscovery.deb
