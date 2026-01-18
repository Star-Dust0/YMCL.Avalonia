<p align="center">
<img height="400" width="400" src="https://raw.githubusercontent.com/yiikooo/YMCL.Avalonia/refs/heads/main/Assets/Icon.Border.png" alt="YMCL Logo"/>
</p>

<div align="center">

# ⛏️ Yu Minecraft Launcher 🐳

**Free, Cross-platform, Fully Open Source Minecraft Launcher**

![Latest Release](https://img.shields.io/github/v/release/yiikooo/YMCL.Avalonia?logo=github&style=for-the-badge&color=007ec6&label=Latest%20Release)
![Downloads](https://img.shields.io/github/downloads/yiikooo/YMCL.Avalonia/total?logo=github&label=Downloads&style=for-the-badge&color=44cc12)
![Stars](https://img.shields.io/github/stars/yiikooo/YMCL.Avalonia?logo=github&label=Star&style=for-the-badge)
![License](https://img.shields.io/badge/GPL%203.0%20License%20-%20?logo=github&label=License&style=for-the-badge&color=ff7a35)

[中文](README.md)

</div>

### 📋 About

**Yu Minecraft Launcher (YMCL)** is a modern, cross-platform Minecraft launcher built with Avalonia UI framework. It provides a smooth user experience and powerful features for both beginners and experienced players.

### ✨ Features

- **Mod Management** - Install, manage, and switch mods easily
- **Auto Installation** - One-click installation of Forge, NeoForge, Fabric, Quilt, OptiFine, and more
- **Game Customization** - Flexible configuration of game parameters and launch options
- **UI Customization** - Personalize launcher appearance and themes
- **Multi-Account Support** - Manage multiple game accounts
- **Cross-Platform Sync** - Seamless switching between different operating systems

### 🖥️ Platform Support

| Architecture | Windows | Linux | macOS |
| ------------ | :-----: | :---: | :---: |
| x64          |   ✅    |  ✅   |  ✅   |
| x86          |   ✅    |  ❌   |  ❌   |
| ARM64        |   ❔    |  ❔   |  ❌   |
| ARM32        |   ❌    |  ❔   |  ❌   |

- ✅ Fully supported
- ❔ Supported but not fully tested
- ❌ Not supported

### 📥 Download

Visit the [Releases page](https://github.com/yiikooo/YMCL.Avalonia/releases) to download the latest version.

**System Requirements:**

- Windows 10 or later
- Ubuntu 20.04 LTS or later
- macOS 10.15 or later

### 🚀 Quick Start

1. Download the version for your system from the Releases page
2. Install and launch YMCL
3. Configure Java path (if needed)
4. Add a game account
5. Select a version and launch the game

### 📖 Development

**Tech Stack:**

- Framework: .NET 8.0+
- UI: Avalonia UI
- Architecture: MVVM + Reactive

**Build:**

```bash
dotnet build YMCL.sln
```

**Run:**

```bash
dotnet run --project YMCL.Main/YMCL.Desktop
```

### 📦 Dependencies

Thanks to these amazing open-source projects:

| Project                                                                                 | Purpose                    |
| --------------------------------------------------------------------------------------- | -------------------------- |
| [FluentAvaloniaUI](https://github.com/amwx/FluentAvalonia)                              | UI Components              |
| [MinecraftLaunch](https://github.com/Blessing-Studio/MinecraftLaunch)                   | Minecraft Launch Core      |
| [CurseForge.APIClient](https://github.com/CurseForgeCommunity/.NET-APIClient)           | CurseForge API Integration |
| [ReactiveUI](https://github.com/reactiveui/reactiveui)                                  | Reactive Programming       |
| [Newtonsoft.Json](https://www.newtonsoft.com/json)                                      | JSON Processing            |
| [NAudio](https://github.com/naudio/NAudio)                                              | Audio Processing           |
| [HtmlAgilityPack](https://github.com/zzzprojects/html-agility-pack)                     | HTML Parsing               |
| [Semi.Avalonia](https://github.com/irihitech/Semi.Avalonia)                             | UI Themes                  |
| [Irihi.Ursa](https://github.com/irihitech/Ursa.Avalonia)                                | UI Components              |
| [MinecraftLaunch.Skin](https://github.com/Blessing-Studio/MinecraftLaunch.Skin)         | Skin Rendering             |
| [StarLight_Core](https://github.com/Ink-Marks-Studio/StarLight.Core)                    | Core Library               |
| [Afdian.Sdk](https://github.com/yiyungent/Afdian.Sdk)                                   | Afdian SDK                 |
| [AsyncImageLoader.Avalonia](https://github.com/AvaloniaUtils/AsyncImageLoader.Avalonia) | Async Image Loading        |
| [CommunityToolkit.Mvvm](https://github.com/CommunityToolkit/dotnet)                     | MVVM Toolkit               |
| [Tomlyn](https://github.com/xoofx/Tomlyn)                                               | TOML Parsing               |

### 📄 License

This project is licensed under the **GPL 3.0** License. See [LICENSE](LICENSE) file for details.

**GPL 3.0 Highlights:**

- Freedom to use, modify, and distribute
- Modified versions must remain GPL 3.0 licensed
- Must retain original copyright notices
- No warranty provided

### 💬 Community

- **QQ Group:** 475032328
- **GitHub Issues:** Report bugs and suggest features

### 🤝 Contributing

Pull requests and issues are welcome!

### 📝 Changelog

See [Releases](https://github.com/yiikooo/YMCL.Avalonia/releases) page for details.
