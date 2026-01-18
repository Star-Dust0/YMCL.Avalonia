<p align="center">
<img height="400" width="400" src="https://raw.githubusercontent.com/yiikooo/YMCL.Avalonia/refs/heads/main/Assets/Icon.Border.png" alt="YMCL Logo"/>
</p>

<div align="center">

# ⛏️ Yu Minecraft Launcher 🐳

**免费、跨平台、完全开源的 Minecraft 启动器**

![Latest Release](https://img.shields.io/github/v/release/yiikooo/YMCL.Avalonia?logo=github&style=for-the-badge&color=007ec6&label=%E6%9C%80%E6%96%B0%E7%89%88%E6%9C%AC)
![Downloads](https://img.shields.io/github/downloads/yiikooo/YMCL.Avalonia/total?logo=github&label=%E4%B8%8B%E8%BD%BD%E9%87%8F&style=for-the-badge&color=44cc12)
![Stars](https://img.shields.io/github/stars/yiikooo/YMCL.Avalonia?logo=github&label=Star&style=for-the-badge)
![License](https://img.shields.io/badge/GPL%203.0%20License%20-%20?logo=github&label=%E5%BC%80%E6%BA%90%E5%8D%8F%E8%AE%AE&style=for-the-badge&color=ff7a35)

[English](README.en.md)

</div>

### 📋 项目简介

**Yu Minecraft Launcher (YMCL)** 是一个现代化的跨平台 Minecraft 启动器，采用 Avalonia UI 框架开发，提供流畅的用户体验和强大的功能。无论你是 Minecraft 新手还是资深玩家，YMCL 都能满足你的需求。

### ✨ 核心功能

- **Mod 管理** - 轻松安装、管理和切换 Mod
- **自动安装** - 一键安装 Forge、NeoForge、Fabric、Quilt、OptiFine 等加载器
- **游戏自定义** - 灵活配置游戏参数和启动选项
- **界面自定义** - 个性化启动器外观和主题
- **多账户支持** - 管理多个游戏账户
- **跨平台同步** - 在不同操作系统间无缝切换

### 🖥️ 平台支持

| 架构  | Windows | Linux | macOS |
| ----- | :-----: | :---: | :---: |
| x64   |   ✅    |  ✅   |  ✅   |
| x86   |   ✅    |  ❌   |  ❌   |
| ARM64 |   ❔    |  ❔   |  ❌   |
| ARM32 |   ❌    |  ❔   |  ❌   |

- ✅ 完全支持
- ❔ 支持但未充分测试
- ❌ 不支持

### 📥 下载安装

访问 [Releases 页面](https://github.com/yiikooo/YMCL.Avalonia/releases) 下载最新版本。

**系统要求：**

- Windows 10 或更高版本
- Ubuntu 20.04 LTS 或更高版本
- macOS 10.15 或更高版本

### 🚀 快速开始

1. 从 Releases 页面下载适合你系统的版本
2. 安装并启动 YMCL
3. 配置 Java 路径（如需要）
4. 添加游戏账户
5. 选择版本并启动游戏

### 📖 开发

**技术栈：**

- 框架：.NET 8.0+
- UI：Avalonia UI
- 架构：MVVM + Reactive

**构建项目：**

```bash
dotnet build YMCL.sln
```

**运行项目：**

```bash
dotnet run --project YMCL.Main/YMCL.Desktop
```

### 📦 依赖项目

感谢以下开源项目的支持：

| 项目                                                                                    | 用途                |
| --------------------------------------------------------------------------------------- | ------------------- |
| [FluentAvaloniaUI](https://github.com/amwx/FluentAvalonia)                              | UI 组件库           |
| [MinecraftLaunch](https://github.com/Blessing-Studio/MinecraftLaunch)                   | Minecraft 启动核心  |
| [CurseForge.APIClient](https://github.com/CurseForgeCommunity/.NET-APIClient)           | CurseForge API 集成 |
| [ReactiveUI](https://github.com/reactiveui/reactiveui)                                  | 响应式编程框架      |
| [Newtonsoft.Json](https://www.newtonsoft.com/json)                                      | JSON 处理           |
| [NAudio](https://github.com/naudio/NAudio)                                              | 音频处理            |
| [HtmlAgilityPack](https://github.com/zzzprojects/html-agility-pack)                     | HTML 解析           |
| [Semi.Avalonia](https://github.com/irihitech/Semi.Avalonia)                             | UI 主题             |
| [Irihi.Ursa](https://github.com/irihitech/Ursa.Avalonia)                                | UI 组件             |
| [MinecraftLaunch.Skin](https://github.com/Blessing-Studio/MinecraftLaunch.Skin)         | 皮肤渲染            |
| [StarLight_Core](https://github.com/Ink-Marks-Studio/StarLight.Core)                    | 核心库              |
| [Afdian.Sdk](https://github.com/yiyungent/Afdian.Sdk)                                   | 爱发电 SDK          |
| [AsyncImageLoader.Avalonia](https://github.com/AvaloniaUtils/AsyncImageLoader.Avalonia) | 异步图片加载        |
| [CommunityToolkit.Mvvm](https://github.com/CommunityToolkit/dotnet)                     | MVVM 工具包         |
| [Tomlyn](https://github.com/xoofx/Tomlyn)                                               | TOML 解析           |

### 📄 许可证

本项目采用 **GPL 3.0** 开源协议。详见 [LICENSE](LICENSE) 文件。

**GPL 3.0 要点：**

- 自由使用、修改和分发
- 修改后的版本必须保持 GPL 3.0 许可
- 必须保留原始版权声明
- 不提供任何形式的保证

### 💬 社区

- **QQ 群：** 475032328
- **GitHub Issues：** 报告 Bug 和功能建议

### 🤝 贡献

欢迎提交 Pull Request 和 Issue！

### 📝 更新日志

详见 [Releases](https://github.com/yiikooo/YMCL.Avalonia/releases) 页面。
