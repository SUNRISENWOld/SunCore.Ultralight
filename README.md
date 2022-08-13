<img src="https://sunrisenw.s3.amazonaws.com/Images/512x512.png" width=80px height=80px></img> 
# SunCore

SunCore is a library for applications that can manage Windows OS (e.g. Change wallpaper, Play MP3 audio etc.)

[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)


## Features

- Change Windows Wallpaper
- Play MP3 audio
- and more coming soon!

## Installation

Install SunCore Ultralight with nuget

```bash
  dotnet add package SunCore.Ultralight --version 1.0.1
```
    
## Contributing

Contributions are always welcome!

See `Contributing.md` for ways to get started.

Please adhere to this project's `code of conduct`.


## Usage/Examples

Getting Image from Stream:
```csharp
using SunCore.Ultralight.SystemManagement.Native_win32.NT.Media;

private Image myImage;

myImage = Images.GetFromStream("https://example.com");
```

Getting Image From File:
```csharp
using SunCore.Ultralight.SystemManagement.Native_win32.NT.Media;

private Image myImage;

myImage = Images.GetFromFile(@"C:\Users\User\Pictures\flower.jpg");
```
Setting desktop Wallpaper:
```csharp
using SunCore.Ultralight.SystemManagement.Native_win32.NT62x;

Wallpaper.Set(@"C:\Users\User\Pictures\flower.jpg", WallpaperStyle.Fill);
```
Setting desktop wallpaper silently (without affecting Windows history):
```csharp
using SunCore.Ultralight.SystemManagement.Native_win32.NT62x;

Wallpaper.SilentSet(@"C:\Users\User\Pictures\flower.jpg");
```
