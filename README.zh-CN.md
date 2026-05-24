<div align="center">
  <img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />
</div>

# Game Frame X UniTask

[![GitHub release](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.cysharp.unitask?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.cysharp.unitask/releases)
[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.cysharp.unitask?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.cysharp.unitask/blob/main/LICENSE.md)
[![Documentation](https://img.shields.io/badge/Documentation-Online-blue?style=flat-square)](https://gameframex.doc.alianblank.com)

**独立游戏前后端一体化解决方案 · 独立游戏开发者的圆梦大使**

[文档](https://gameframex.doc.alianblank.com) · [快速开始](#快速开始) · [QQ群](https://qm.qq.com/q/5s5e1e6e6e)

**语言**: [English](README.md) | **简体中文** | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)

---

## 项目简介

Game Frame X UniTask 是基于 [UniTask](https://github.com/Cysharp/UniTask) 的二次修改版本，集成到 GameFrameX 框架中。为 Unity 提供高效的 async/await 集成。

该库主要服务于 [GameFrameX](https://github.com/AlianBlank/GameFrameX) 作为子库使用。

## 改动功能

1. 增加 `link.xml` 的裁剪过滤
2. 增加对 `Packages` 的支持
3. 增加延迟一帧的接口

## 快速开始

### 系统要求

- Unity 2018.4 或更高版本

### 安装

任选以下方式之一：

1. 直接在 `manifest.json` 文件中添加以下内容：
   ```json
   {"com.gameframex.unity.cysharp.unitask": "https://github.com/AlianBlank/com.gameframex.unity.cysharp.unitask.git"}
   ```

2. 在 Unity 的 `Packages Manager` 中使用 `Git URL` 的方式添加库，地址为：
   ```
   https://github.com/AlianBlank/com.gameframex.unity.cysharp.unitask.git
   ```

3. 直接下载仓库放置到 Unity 项目的 `Packages` 目录下，会自动加载识别。

## 同步版本

基于 UniTask 提交：https://github.com/Cysharp/UniTask/commit/5cc97c7f0085624b6ef57853d70b404440060cef

## 文档与资源

- UniTask 文档: https://github.com/Cysharp/UniTask
- GameFrameX 文档: https://gameframex.doc.alianblank.com
- 仓库地址: https://github.com/GameFrameX/com.gameframex.unity.cysharp.unitask
- 问题反馈: https://github.com/GameFrameX/com.gameframex.unity.cysharp.unitask/issues

## 开源协议

UniTask 遵循 [MIT](https://github.com/Cysharp/UniTask/blob/master/LICENSE) 许可证。
