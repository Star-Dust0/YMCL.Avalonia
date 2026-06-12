<p align="center">
<img height="400" width="400" src="./Assets/Icon.Border.png" alt="YMCL Logo"/>
</p>

<div align="center">

# ⛏️ Yu Minecraft Launcher 🐳

**免费、跨平台、完全开源的 Minecraft 启动器**

![Latest Release](https://img.shields.io/github/v/release/Star-Dust0/YMCL.Avalonia?logo=github&style=for-the-badge&color=007ec6&label=最新版本)
![Downloads](https://img.shields.io/github/downloads/Star-Dust0/YMCL.Avalonia/total?logo=github&label=下载量&style=for-the-badge&color=44cc12)
![Stars](https://img.shields.io/github/stars/Star-Dust0/YMCL.Avalonia?logo=github&label=Star&style=for-the-badge)
![License](https://img.shields.io/badge/GPL%203.0%20License%20-%20?logo=github&label=开源协议&style=for-the-badge&color=ff7a35)

> Forked from [yiikooo/YMCL.Avalonia](https://github.com/yiikooo/YMCL.Avalonia)

[English](README.en.md)

</div>

### 📋 项目简介

Yu Minecraft Launcher (YMCL) 是一个基于 Avalonia UI 的跨平台 Minecraft 启动器。支持 Mod 管理、多版本安装、界面自定义等功能。

### ✨ 核心功能

- **Mod 管理** - 安装、管理和切换 Mod
- **自动安装** - 一键安装 Forge、Fabric、Quilt、OptiFine 等加载器
- **游戏自定义** - 灵活配置启动参数和游戏选项
- **界面自定义** - 个性化启动器外观和主题
- **多账户支持** - 管理多个游戏账户
- **跨平台** - Windows / Linux / macOS

### 🖥️ 平台支持

| 架构  | Windows | Linux | macOS |
| ----- | :-----: | :---: | :---: |
| x64   |   ✅    |  ✅   |  ✅   |
| x86   |   ✅    |  ❌   |  ❌   |
| ARM64 |   ❔    |  ❔   |  ❌   |

- ✅ 完全支持
- ❔ 支持但未充分测试
- ❌ 不支持

### 📥 下载安装

访问 [Releases 页面](https://github.com/Star-Dust0/YMCL.Avalonia/releases) 下载最新版本。

**系统要求：** Windows 10+ / Ubuntu 20.04+ / macOS 10.15+

### 📖 开发

**技术栈：** .NET 8.0+ / Avalonia UI / MVVM + Reactive

```bash
# 构建
dotnet build YMCL.sln

# 运行
dotnet run --project YMCL.Main/YMCL.Desktop
```

### 📦 依赖项目

| 项目 | 用途 |
| ---- | ---- |
| [FluentAvaloniaUI](https://github.com/amwx/FluentAvalonia) | UI 组件库 |
| [MinecraftLaunch](https://github.com/Blessing-Studio/MinecraftLaunch) | Minecraft 启动核心 |
| [ReactiveUI](https://github.com/reactiveui/reactiveui) | 响应式编程框架 |
| [Semi.Avalonia](https://github.com/irihitech/Semi.Avalonia) | UI 主题 |
| [Irihi.Ursa](https://github.com/irihitech/Ursa.Avalonia) | UI 组件 |
| [NAudio](https://github.com/naudio/NAudio) | 音频处理 |

### 📄 许可证

本项目基于 **GPL 3.0** 开源协议。详见 [LICENSE](LICENSE)。

### 📝 更新日志

详见 [Releases](https://github.com/Star-Dust0/YMCL.Avalonia/releases)。
