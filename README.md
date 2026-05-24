<div align="center">
  <img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />
</div>

# Game Frame X UniTask

[![GitHub release](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.cysharp.unitask?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.cysharp.unitask/releases)
[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.cysharp.unitask?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.cysharp.unitask/blob/main/LICENSE.md)
[![Documentation](https://img.shields.io/badge/Documentation-Online-blue?style=flat-square)](https://gameframex.doc.alianblank.com)

**All-in-One Solution for Indie Game Development · Empowering Indie Developers' Dreams**

[Documentation](https://gameframex.doc.alianblank.com) · [Quick Start](#quick-start) · [QQ Group](https://qm.qq.com/q/5s5e1e6e6e)

**Language**: **English** | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)

---

## Project Overview

Game Frame X UniTask is a modified version of [UniTask](https://github.com/Cysharp/UniTask) integrated for the GameFrameX framework. It provides an efficient async/await integration to Unity.

This library primarily serves as a submodule for [GameFrameX](https://github.com/AlianBlank/GameFrameX).

## Changes from Upstream

1. Added `link.xml` stripping filter
2. Added `Packages` support
3. Added delay-one-frame interface

## Quick Start

### System Requirements

- Unity 2018.4 or higher

### Installation

Choose one of the following methods:

1. Add the following to your project's `manifest.json` file:
   ```json
   {"com.gameframex.unity.cysharp.unitask": "https://github.com/AlianBlank/com.gameframex.unity.cysharp.unitask.git"}
   ```

2. Use `Git URL` in Unity's Package Manager:
   ```
   https://github.com/AlianBlank/com.gameframex.unity.cysharp.unitask.git
   ```

3. Download the repository and place it in your Unity project's `Packages` directory. It will be loaded automatically.

## Sync Version

Based on UniTask commit: https://github.com/Cysharp/UniTask/commit/5cc97c7f0085624b6ef57853d70b404440060cef

## Documentation & Resources

- UniTask Documentation: https://github.com/Cysharp/UniTask
- GameFrameX Documentation: https://gameframex.doc.alianblank.com
- Repository: https://github.com/GameFrameX/com.gameframex.unity.cysharp.unitask
- Issues: https://github.com/GameFrameX/com.gameframex.unity.cysharp.unitask/issues

## License

UniTask is licensed under the [MIT](https://github.com/Cysharp/UniTask/blob/master/LICENSE) license.
