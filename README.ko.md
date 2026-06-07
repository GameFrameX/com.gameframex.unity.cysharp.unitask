<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X UniTask

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.cysharp.unitask)](https://github.com/GameFrameX/com.gameframex.unity.cysharp.unitask/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.cysharp.unitask)](https://github.com/GameFrameX/com.gameframex.unity.cysharp.unitask/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

인디 게임 개발자를 위한 올인원 솔루션 · 인디 개발자의 꿈을 실현

<br />

[문서](https://gameframex.doc.alianblank.com) · [빠른 시작](#빠른-시작) · QQ 그룹: 467608841 / 233840761

<br />

[English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | **한국어**

</div>

## 프로젝트 개요

Game Frame X UniTask는 [UniTask](https://github.com/Cysharp/UniTask)의 수정 버전으로 GameFrameX 프레임워크에 통합되었습니다. Unity에 효율적인 async/await 통합을 제공합니다.

이 라이브러리는 주로 [GameFrameX](https://github.com/AlianBlank/GameFrameX)의 서브모듈로 사용됩니다.

## 변경 사항

1. `link.xml` 스트리핑 필터 추가
2. `Packages` 지원 추가
3. 1프레임 지연 인터페이스 추가

## 빠른 시작

### 설치

Unity 프로젝트의 `Packages/manifest.json`을 편집하여 `scopedRegistries` 섹션을 추가하세요:

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

`scopes`는 이 레지스트리를 통해 어떤 패키지를 해석할지 제어합니다. `com.gameframex`로 시작하는 패키지만 이 레지스트리에서 가져옵니다.

Then add the package to `dependencies`:

```json
{
  "dependencies": {
    "com.gameframex.unity.cysharp.unitask": "2.6.0"
  }
}
```


## 동기화 버전

UniTask 커밋 기반: https://github.com/Cysharp/UniTask/commit/5cc97c7f0085624b6ef57853d70b404440060cef

## 문서 및 자료

- UniTask 문서: https://github.com/Cysharp/UniTask
- GameFrameX 문서: https://gameframex.doc.alianblank.com
- 저장소: https://github.com/GameFrameX/com.gameframex.unity.cysharp.unitask
- 이슈: https://github.com/GameFrameX/com.gameframex.unity.cysharp.unitask/issues


## 의존성

| 패키지 | 설명 |
|--------|------|
| (无) | - |


## 커뮤니티 및 지원

- QQ 그룹: 467608841 / 233840761

## 변경 로그

[Releases](https://github.com/GameFrameX/gameframex/com.gameframex.unity.cysharp.unitask/releases)에서 변경 로그를 확인하세요.
## 라이선스

UniTask는 [MIT](https://github.com/Cysharp/UniTask/blob/master/LICENSE) 라이선스에 따라 배포됩니다.
