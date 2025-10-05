# データ定義書

このドキュメントは「Tumisugi」アプリケーションのデータ構造を定義します。  
要件に基づき、Entity Framework Coreでの利用を想定しています。

---

## 1. テーブル一覧

| テーブル名 | 説明               |
|------------|--------------------|
| Games      | ゲーム情報を格納   |

---

## 2. テーブル定義

### 2.1. Games

| Column Name   | Data Type      | Nullable | Description                       |
|---------------|---------------|----------|-----------------------------------|
| Id            | int           | No       | Primary key (auto-increment)      |
| Title         | string (100)  | No       | Game title                        |
| Genre         | string (50)   | Yes      | Game genre                        |
| Status        | string (20)   | No       | Game status (e.g. Backlog, Playing, Cleared) |
| Memo          | string (500)  | Yes      | Free memo field                   |
| CreatedAt     | DateTime      | No       | Registration date                 |
| UpdatedAt     | DateTime      | Yes      | Last updated date                 |

---

## 3. 備考

- `Status`列は「Backlog」「Playing」「Cleared」などの値を想定しています。
- `Id`列は主キーで自動採番されます。
- 文字列長は暫定値です。必要に応じて調整してください。
- この定義はEF CoreのCode Firstを前提としています。

---