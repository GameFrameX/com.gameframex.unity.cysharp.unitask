<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X UniTask

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.cysharp.unitask)](https://github.com/GameFrameX/com.gameframex.unity.cysharp.unitask/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.cysharp.unitask)](https://github.com/GameFrameX/com.gameframex.unity.cysharp.unitask/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

インディゲーム開発者向けオールインワンソリューション · インディ開発者の夢を支援

<br />

[ドキュメント](https://gameframex.doc.alianblank.com) · [クイックスタート](#クイックスタート) · QQグループ: 467608841 / 233840761

<br />

[English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | **日本語** | [한국어](README.ko.md)

</div>
## プロジェクト概要

Game Frame X UniTask は [UniTask](https://github.com/Cysharp/UniTask) の修正版で、GameFrameX フレームワークに統合されています。Unity に効率的な async/await 統合を提供します。

このライブラリは主に [GameFrameX](https://github.com/AlianBlank/GameFrameX) のサブモジュールとして使用されます。

## 変更内容

1. `link.xml` ストリッピングフィルターを追加
2. `Packages` サポートを追加
3. 1フレーム遅延インターフェースを追加

## クイックスタート

### 動作環境

- Unity 2018.4 以上

### インストール

以下のいずれかの方法を選択してください：

1. プロジェクトの `manifest.json` ファイルに以下を追加：
   ```json
   {"com.gameframex.unity.cysharp.unitask": "https://github.com/AlianBlank/com.gameframex.unity.cysharp.unitask.git"}
   ```

2. Unity の Package Manager で `Git URL` を使用：
   ```
   https://github.com/AlianBlank/com.gameframex.unity.cysharp.unitask.git
   ```

3. リポジトリをダウンロードして Unity プロジェクトの `Packages` ディレクトリに配置。自動的にロードされます。

## 同期バージョン

UniTask コミットベース: https://github.com/Cysharp/UniTask/commit/5cc97c7f0085624b6ef57853d70b404440060cef

## ドキュメントとリソース

- UniTask ドキュメント: https://github.com/Cysharp/UniTask
- GameFrameX ドキュメント: https://gameframex.doc.alianblank.com
- リポジトリ: https://github.com/GameFrameX/com.gameframex.unity.cysharp.unitask
- イシュー: https://github.com/GameFrameX/com.gameframex.unity.cysharp.unitask/issues

## ライセンス

UniTask は [MIT](https://github.com/Cysharp/UniTask/blob/master/LICENSE) ライセンスの下で公開されています。
