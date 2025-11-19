# アプリケーション設計

## 1. 概要
- 名称: Tumisugi（仮）
- 目的: 積みゲームや積みアニメを管理するためのアプリケーション。積みものと呼ぶ。
ASP.NET CoreとEF Coreの学習を第1とする
- 想定ユーザ: 単一ローカルユーザ(俺)

## 2. 技術スタック
- **Framework**: ASP.NET Core, EF Core
- **Language**: C#
- **Database**: SQLite
- **Frontend**: Razor(ASP.NET Core)

## 3. 画面一覧
- 画面: お積みもの一覧 [ワイヤーフレーム](wireframe/list.png)
- 画面: お積みもの追加 [ワイヤーフレーム](wireframe/add.png)
- 画面: お積みもの詳細 [ワイヤーフレーム](wireframe/detail.png)
- 画面: お積みもの削除 [ワイヤーフレーム](wireframe/delete.png)

## 4. DB設計
- [テーブル定義書](data/data_definition.md)

## 5. 機能設計
