<img src="https://sunrisenw.s3.amazonaws.com/Images/512x512.png" width=80px height=80px></img> 
# SunCore

SunCore is a library for Minecraft Launchers (uses CmlLib.Core), applications that can manage Windows OS (e.g. Change wallpaper, Play MP3 audio etc.)

[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)


## Features

- Change Windows Wallpaper
- Play MP3 audio
- Launch Minecraft
- and more coming soon!

    
## Contributing

Contributions are always welcome!

See `Contributing.md` for ways to get started.

Please adhere to this project's `code of conduct`.


## Usage/Examples

Launching Minecraft:
```csharp
using SunCore_Ultralight.MCLauncher;

Launcher.Launch("1.18.2", "Player", 1024, new MinecraftPath(), false, "GameLauncherName", 1280, 720, "play.sunrisenw.com", 25565);

```

The code example above launches:

- Version 1.18.2
- With username "Player"
- With 1024 MB (1 GB) RAM
- On default Minecraft Path
- Windowed
- With resolution: 1280x720
- To connect server play.sunrisenw.com:25565.

Getting Image from Stream:
```csharp
using SunCore_Ultralight.SystemManagement.Native_win32.NT.Media;

private Image myImage;

myImage = Images.GetFromStream("https://example.com");
```

Getting Image From File:
```csharp
using SunCore_Ultralight.SystemManagement.Native_win32.NT.Media;

private Image myImage;

myImage = Images.GetFromFile(@"C:\Users\User\Pictures\flower.jpg");
```
Setting desktop Wallpaper:
```csharp
using SunCore_Ultralight.SystemManagement.Native_win32.NT62x;

Wallpaper.Set(@"C:\Users\User\Pictures\flower.jpg", WallpaperStyle.Fill);
```
Setting desktop wallpaper silently (without affecting Windows history):
```csharp
using SunCore_Ultralight.SystemManagement.Native_win32.NT62x;

Wallpaper.SilentSet(@"C:\Users\User\Pictures\flower.jpg");
```
