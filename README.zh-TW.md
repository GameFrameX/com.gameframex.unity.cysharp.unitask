<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X UniTask

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.cysharp.unitask)](https://github.com/GameFrameX/com.gameframex.unity.cysharp.unitask/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.cysharp.unitask)](https://github.com/GameFrameX/com.gameframex.unity.cysharp.unitask/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

獨立遊戲前後端一體化解決方案 · 獨立遊戲開發者的圓夢大使

<br />

[文檔](https://gameframex.doc.alianblank.com) · [快速開始](#快速開始) · QQ群: 467608841 / 233840761

<br />

[English](README.md) | [简体中文](README.zh-CN.md) | **繁體中文** | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>

## 項目簡介

Game Frame X UniTask 是基於 [UniTask](https://github.com/Cysharp/UniTask) 的二次修改版本，整合到 GameFrameX 框架中。為 Unity 提供高效的 async/await 整合。

該庫主要服務於 [GameFrameX](https://github.com/AlianBlank/GameFrameX) 作為子庫使用。

## 改動功能

1. 增加 `link.xml` 的裁剪過濾
2. 增加對 `Packages` 的支援
3. 增加延遲一幀的介面

## 快速開始

### 安裝

編輯 Unity 專案的 `Packages/manifest.json`，添加 `scopedRegistries` 部分：

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

`scopes` 控制哪些套件透過此註冊表解析。只有以 `com.gameframex` 開頭的套件才會從這個註冊表取得。

Then add the package to `dependencies`:

```json
{
  "dependencies": {
    "com.gameframex.unity.cysharp.unitask": "2.6.0"
  }
}
```


## 同步版本

基於 UniTask 提交：https://github.com/Cysharp/UniTask/commit/5cc97c7f0085624b6ef57853d70b404440060cef

## 文檔與資源

- UniTask 文檔: https://github.com/Cysharp/UniTask
- GameFrameX 文檔: https://gameframex.doc.alianblank.com
- 倉庫地址: https://github.com/GameFrameX/com.gameframex.unity.cysharp.unitask
- 問題回報: https://github.com/GameFrameX/com.gameframex.unity.cysharp.unitask/issues


## 依賴

| 套件 | 說明 |
|------|------|
| (无) | - |


## 社區與支援

- QQ群: 467608841 / 233840761

## 更新日誌

查看 [Releases](https://github.com/GameFrameX/gameframex/com.gameframex.unity.cysharp.unitask/releases) 了解更新日誌。
## 開源協議

UniTask 遵循 [MIT](https://github.com/Cysharp/UniTask/blob/master/LICENSE) 許可證。
