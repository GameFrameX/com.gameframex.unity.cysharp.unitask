<div align="center">
  <img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />
</div>

# Game Frame X UniTask

[![GitHub release](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.cysharp.unitask?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.cysharp.unitask/releases)
[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.cysharp.unitask?style=flat-square)](https://github.com/GameFrameX/com.gameframex.unity.cysharp.unitask/blob/main/LICENSE.md)
[![Documentation](https://img.shields.io/badge/Documentation-Online-blue?style=flat-square)](https://gameframex.doc.alianblank.com)

**인디 게임 개발자를 위한 올인원 솔루션 · 인디 개발자의 꿈을 실현**

[문서](https://gameframex.doc.alianblank.com) · [빠른 시작](#빠른-시작) · [QQ 그룹](https://qm.qq.com/q/5s5e1e6e6e)

**언어**: [English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | **한국어**

---

## 프로젝트 개요

Game Frame X UniTask는 [UniTask](https://github.com/Cysharp/UniTask)의 수정 버전으로 GameFrameX 프레임워크에 통합되었습니다. Unity에 효율적인 async/await 통합을 제공합니다.

이 라이브러리는 주로 [GameFrameX](https://github.com/AlianBlank/GameFrameX)의 서브모듈로 사용됩니다.

## 변경 사항

1. `link.xml` 스트리핑 필터 추가
2. `Packages` 지원 추가
3. 1프레임 지연 인터페이스 추가

## 빠른 시작

### 시스템 요구 사항

- Unity 2018.4 이상

### 설치

다음 방법 중 하나를 선택하세요:

1. 프로젝트의 `manifest.json` 파일에 다음 내용을 추가:
   ```json
   {"com.gameframex.unity.cysharp.unitask": "https://github.com/AlianBlank/com.gameframex.unity.cysharp.unitask.git"}
   ```

2. Unity의 Package Manager에서 `Git URL`을 사용하여 추가:
   ```
   https://github.com/AlianBlank/com.gameframex.unity.cysharp.unitask.git
   ```

3. 저장소를 다운로드하여 Unity 프로젝트의 `Packages` 디렉토리에 배치하면 자동으로 로드됩니다.

## 동기화 버전

UniTask 커밋 기반: https://github.com/Cysharp/UniTask/commit/5cc97c7f0085624b6ef57853d70b404440060cef

## 문서 및 자료

- UniTask 문서: https://github.com/Cysharp/UniTask
- GameFrameX 문서: https://gameframex.doc.alianblank.com
- 저장소: https://github.com/GameFrameX/com.gameframex.unity.cysharp.unitask
- 이슈: https://github.com/GameFrameX/com.gameframex.unity.cysharp.unitask/issues

## 라이선스

UniTask는 [MIT](https://github.com/Cysharp/UniTask/blob/master/LICENSE) 라이선스에 따라 배포됩니다.
