<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X UniTask

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.cysharp.unitask)](https://github.com/GameFrameX/com.gameframex.unity.cysharp.unitask/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.cysharp.unitask)](https://github.com/GameFrameX/com.gameframex.unity.cysharp.unitask/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

独立游戏前后端一体化解决方案 · 独立游戏开发者的圆梦大使

<br />

[文档](https://gameframex.doc.alianblank.com) · [快速开始](#快速开始) · QQ群: 467608841 / 233840761

<br />

[English](README.md) | **简体中文** | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>

## 项目简介

Game Frame X UniTask 是基于 [UniTask](https://github.com/Cysharp/UniTask) 的二次修改版本，集成到 GameFrameX 框架中。为 Unity 提供高效的 async/await 集成。

该库主要服务于 [GameFrameX](https://github.com/AlianBlank/GameFrameX) 作为子库使用。

## 改动功能

1. 增加 `link.xml` 的裁剪过滤
2. 增加对 `Packages` 的支持
3. 增加延迟一帧的接口

## 快速开始

### 安装

编辑 Unity 项目的 `Packages/manifest.json`，添加 `scopedRegistries` 部分：

```json
{
  "scopedRegistries": [
    {
      "name": "GameFrameX",
      "url": "https://gameframex.upm.alianblank.uk",
      "scopes": [
        "com.gameframex"
      ]
    }
  ]
}
```

`scopes` 控制哪些包通过此注册表解析。只有以 `com.gameframex` 开头的包才会从这个注册表获取。

Then add the package to `dependencies`:

```json
{
  "dependencies": {
    "com.gameframex.unity.cysharp.unitask": "2.6.0"
  }
}
```


## 同步版本

基于 UniTask 提交：https://github.com/Cysharp/UniTask/commit/5cc97c7f0085624b6ef57853d70b404440060cef

## 文档与资源

- UniTask 文档: https://github.com/Cysharp/UniTask
- GameFrameX 文档: https://gameframex.doc.alianblank.com
- 仓库地址: https://github.com/GameFrameX/com.gameframex.unity.cysharp.unitask
- 问题反馈: https://github.com/GameFrameX/com.gameframex.unity.cysharp.unitask/issues


## 依赖

| 包 | 说明 |
|----|------|
| (无) | - |


## 社区与支持

- QQ群: 467608841 / 233840761

## 更新日志

查看 [Releases](https://github.com/GameFrameX/gameframex/com.gameframex.unity.cysharp.unitask/releases) 了解更新日志。
## 开源协议

UniTask 遵循 [MIT](https://github.com/Cysharp/UniTask/blob/master/LICENSE) 许可证。
