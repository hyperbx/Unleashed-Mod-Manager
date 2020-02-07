<p align="center">
    <img src="https://github.com/HyperPolygon64/Unleashed-Mod-Manager/blob/master/Unleashed-Mod-Manager/res/Images/Logo.png"
         width="256"/>
</p>

<h1 align="center">Unleashed Mod Manager</h1>

<p align="center">A tool designed to make it easier to use and manage mods for Sonic Unleashed on the Xbox 360 and PlayStation 3.</p>

# Building
To manually build the Mod Manager, simply clone this repository to a location on your computer and open `Unleashed-Mod-Manager.sln` in Visual Studio (only [Visual Studio 2019](https://visualstudio.microsoft.com/vs/) has been tested for this, but any recent version should be able to compile it). Right-click on the project in the Solution Explorer and choose Rebuild Solution to build an executable in `..\Unleashed-Mod-Manager\bin\Debug`.

If you just wish to use the Mod Manager without touching the code, [simply grab the most recent stable release](https://github.com/HyperPolygon64/Unleashed-Mod-Manager/releases).

# Usage
When you first run the Mod Manager it will prompt you with the first time setup, these settings be changed at any time. [Please refer to the wiki if you get stuck.](https://github.com/HyperPolygon64/Unleashed-Mod-Manager/wiki)

## Emulators
Configure your Game Executable and Emulator Executable locations using the text fields (or browse buttons). The Emulator Executable simply requires you to select your EXE of [Xenia emulator](https://github.com/xenia-project/xenia) or [RPCS3](https://github.com/RPCS3/rpcs3). Then click `Save, install content and launch Unleashed` to automatically copy the mods to your game directory and launch the game in the selected emulator.

## Real Hardware
Uncheck `Launch emulator after installing mods` in the Settings section, then set your game executable to an extracted copy of Sonic Unleashed on external media. Click `Save and install content` and once finished, you can launch the game on the external media from real hardware, provided it's modified.

# ISO Extraction
In order to use the Mod Manager, your copy of Sonic Unleashed needs to be extracted, how you will do this depends on your system, follow the appropriate instructions in the links below.

- Xbox 360: https://www.reddit.com/r/xenia/wiki/how_to_rip_games
- PlayStation 3: https://www.reddit.com/r/ps3homebrew/wiki/multiman#wiki_making_backups_of_games

(Xbox 360 users) - If you end up with an ISO disc image, then you can use [Sonic '06 Toolkit](https://github.com/HyperPolygon64/Sonic-06-Toolkit) to extract the Xbox 360 ISO.
