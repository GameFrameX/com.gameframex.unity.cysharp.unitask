<div align="center">
  <img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />
</div>

# Game Frame X UniTask

[![GitHub release](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.cysharp.unitask?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.cysharp.unitask/releases)
[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.cysharp.unitask?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.cysharp.unitask/blob/main/LICENSE.md)
[![Documentation](https://img.shields.io/badge/Documentation-Online-blue?style=flat-square)](https://gameframex.doc.alianblank.com)

**獨立遊戲前後端一體化解決方案 · 獨立遊戲開發者的圓夢大使**

[文檔](https://gameframex.doc.alianblank.com) · [快速開始](#快速開始) · [QQ群](https://qm.qq.com/q/5s5e1e6e6e)

**語言**: [English](README.md) | [简体中文](README.zh-CN.md) | **繁體中文** | [日本語](README.ja.md) | [한국어](README.ko.md)

---

## 項目簡介

Game Frame X UniTask 是基於 [UniTask](https://github.com/Cysharp/UniTask) 的二次修改版本，整合到 GameFrameX 框架中。為 Unity 提供高效的 async/await 整合。

該庫主要服務於 [GameFrameX](https://github.com/AlianBlank/GameFrameX) 作為子庫使用。

## 改動功能

1. 增加 `link.xml` 的裁剪過濾
2. 增加對 `Packages` 的支援
3. 增加延遲一幀的介面

## 快速開始

### 系統需求

- Unity 2018.4 或更高版本

### 安裝

任選以下方式之一：

1. 直接在 `manifest.json` 檔案中添加以下內容：
   ```json
   {"com.gameframex.unity.cysharp.unitask": "https://github.com/AlianBlank/com.gameframex.unity.cysharp.unitask.git"}
   ```

2. 在 Unity 的 `Packages Manager` 中使用 `Git URL` 的方式添加庫，地址為：
   ```
   https://github.com/AlianBlank/com.gameframex.unity.cysharp.unitask.git
   ```

3. 直接下載倉庫放置到 Unity 專案的 `Packages` 目錄下，會自動載入識別。

## 同步版本

基於 UniTask 提交：https://github.com/Cysharp/UniTask/commit/5cc97c7f0085624b6ef57853d70b404440060cef

## 文檔與資源

- UniTask 文檔: https://github.com/Cysharp/UniTask
- GameFrameX 文檔: https://gameframex.doc.alianblank.com
- 倉庫地址: https://github.com/GameFrameX/com.gameframex.unity.cysharp.unitask
- 問題回報: https://github.com/GameFrameX/com.gameframex.unity.cysharp.unitask/issues

## 開源協議

UniTask 遵循 [MIT](https://github.com/Cysharp/UniTask/blob/master/LICENSE) 許可證。
