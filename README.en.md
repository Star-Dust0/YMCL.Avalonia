<p align="center">
<img height="400" width="400" src="./Assets/Icon.Border.png" alt="YMCL Logo"/>
</p>

<div align="center">

# ⛏️ Yu Minecraft Launcher 🐳

**Free, Cross-platform, Fully Open Source Minecraft Launcher**

![Latest Release](https://img.shields.io/github/v/release/Star-Dust0/YMCL.Avalonia?logo=github&style=for-the-badge&color=007ec6&label=Latest%20Release)
![Downloads](https://img.shields.io/github/downloads/Star-Dust0/YMCL.Avalonia/total?logo=github&label=Downloads&style=for-the-badge&color=44cc12)
![Stars](https://img.shields.io/github/stars/Star-Dust0/YMCL.Avalonia?logo=github&label=Star&style=for-the-badge)
![License](https://img.shields.io/badge/GPL%203.0%20License%20-%20?logo=github&label=License&style=for-the-badge&color=ff7a35)

> Forked from [yiikooo/YMCL.Avalonia](https://github.com/yiikooo/YMCL.Avalonia)

[中文](README.md)

</div>

### 📋 About

Yu Minecraft Launcher (YMCL) is a cross-platform Minecraft launcher built with Avalonia UI. It supports mod management, multi-version installation, UI customization, and more.

### ✨ Features

- **Mod Management** - Install, manage, and switch mods easily
- **Auto Installation** - One-click install Forge, Fabric, Quilt, OptiFine, and more
- **Game Customization** - Flexible launch parameter configuration
- **UI Customization** - Personalize launcher appearance and themes
- **Multi-Account** - Manage multiple game accounts
- **Cross-Platform** - Windows / Linux / macOS

### 🖥️ Platform Support

| Architecture | Windows | Linux | macOS |
| ------------ | :-----: | :---: | :---: |
| x64          |   ✅    |  ✅   |  ✅   |
| x86          |   ✅    |  ❌   |  ❌   |
| ARM64        |   ❔    |  ❔   |  ❌   |

- ✅ Fully supported
- ❔ Supported but not fully tested
- ❌ Not supported

### 📥 Download

Visit the [Releases page](https://github.com/Star-Dust0/YMCL.Avalonia/releases) to download the latest version.

**Requirements:** Windows 10+ / Ubuntu 20.04+ / macOS 10.15+

### 📖 Development

**Tech Stack:** .NET 8.0+ / Avalonia UI / MVVM + Reactive

```bash
# Build
dotnet build YMCL.sln

# Run
dotnet run --project YMCL.Main/YMCL.Desktop
```

### 📦 Dependencies

| Project | Purpose |
| ------- | ------- |
| [FluentAvaloniaUI](https://github.com/amwx/FluentAvalonia) | UI Components |
| [MinecraftLaunch](https://github.com/Blessing-Studio/MinecraftLaunch) | Minecraft Launch Core |
| [ReactiveUI](https://github.com/reactiveui/reactiveui) | Reactive Programming |
| [Semi.Avalonia](https://github.com/irihitech/Semi.Avalonia) | UI Themes |
| [Irihi.Ursa](https://github.com/irihitech/Ursa.Avalonia) | UI Components |
| [NAudio](https://github.com/naudio/NAudio) | Audio Processing |

### 📄 License

Licensed under **GPL 3.0**. See [LICENSE](LICENSE) for details.

### 📝 Changelog

See [Releases](https://github.com/Star-Dust0/YMCL.Avalonia/releases).
