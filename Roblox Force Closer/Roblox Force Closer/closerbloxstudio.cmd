@echo off
echo Attempting to force close Roblox Studio.
title Roblox Closer
@echo on
taskkill /im RobloxStudioBeta.exe /t /f
pause