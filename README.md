# TumiSugi - お積みもの管理アプリ

ASP.NET Core MVC の学習を目的とした個人開発プロジェクトです。

お積みもの（積読や後回しにしているタスク）を管理・検索・分類するための Web アプリケーション。

## Quick Links

- 📋 **[ドキュメント](docs/README.md)**: 要件定義、設計、機能仕様、データ定義

## Project Structure

```
tumisugi-app/
├── README.md (このファイル)
├── docs/
│   ├── README.md (ドキュメント索引)
│   ├── requirements.md (要件定義書)
│   ├── design.md (設計情報)
│   ├── Functional/ (機能仕様)
│   │   ├── Functional_List.md (一覧機能)
│   │   └── Functional_add.md (追加機能)
│   │   └── ...
│   ├── Wireframe/ (ワイヤーフレーム)
│   │   ├── List.md
│   │   ├── Add.md
│   │   └── ...
│   └── Data/
│       └── data_definition.md (DB スキーマ)
├── src/ (ASP.NET Core MVC プロジェクト - 実装予定)
└── ...
```

## 技術スタック

- **言語**: C#
- **フレームワーク**: ASP.NET Core MVC
- **ビュー**: Razor View
- **データベース**: SQLite
- **ORM**: Entity Framework Core

## 開発進捗

- [ ] プロジェクト初期化
- [ ] DB スキーマ設計
- [ ] 一覧機能（検索・ソート・ページング）
- [ ] 追加機能
- [ ] 詳細・編集・削除機能
- [ ] ユーザー認証（TODO）
- [ ] ログ機能（TODO）

## Notes

このプロジェクトは個人学習目的です。詳細は [docs/README.md](docs/README.md) を参照してください。