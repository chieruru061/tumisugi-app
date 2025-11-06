# テーブル定義書

このドキュメントは「Tumisugi」アプリケーションのデータ構造を定義します。  
要件に基づき、Entity Framework Coreでの利用を想定しています。

---

## 1. テーブル一覧

| テーブル名  | 説明               |
|------------|--------------------|
| TUMI_MANAGE     | 積みものの情報を管理するテーブル。積んだアイテムが登録される。|
| TUMI_HISTORY    | 積みもの状態の期間が登録されるテーブル|
| - マスタテーブル -
| M_GENRE_MAJOR   | 積みもの大ジャンルのマスタ(geme, anime ...)|
| M_STATUS        | 積みもの状態のマスタ|
| M_PLATFORM      | 積みものプラットフォームのマスタ|
| M_GENRE_DETAIL  | 積みもの小ジャンルのマスタ(action, RPG ...)|

---

## 2. テーブル定義

### 2.1. TUMI_MANAGE テーブル

[トランザクションテーブル]
| Column Name   | Data Type     | Nullable | Description                       |
|---------------|---------------|----------|-----------------------------------|
| ID            | INTEGER       | No       | PK (auto-increment)               |
| NAME          | TEXT          | No       | 積みものタイトル                    |
| USER_CODE     | INTEGER       | No       | ログイン機能が実装された場合の拡張要素。今回は１固定                        |
| GENRE_MAJOR_CODE | INTEGER       | No       | FK (M_GENRE_MAJOR)                |
| GENRE_DETAIL_CODE| INTEGER       | No       | FK (M_GENRE_DETAIL)               |
| STATUS_CODE   | INTEGER       | No       | FK (M_STATUS)                     |
| PLATFORM_CODE | INTEGER       | No       | FK (M_PLATFORM)                   |
| MEMO          | TEXT          | YES      | メモ　　　　　　　　　　　　　　　　　|
| UPDATE_AT     | TEXT          | No       | 更新日付　　　　　　　　　　　　　　　|

### 2.2. TUMI_HISTORY テーブル

[トランザクションテーブル]
| Column Name   | Data Type     | Nullable | Description                       |
|---------------|---------------|----------|-----------------------------------|
| ID            | INTEGER       | No       | PK (auto-increment)               |
| TUMI_ID       | INTEGER       | No       | FK (TUMI_MANAGE)                  |
| STATUS_CODE   | TEXT          | No       | FK (M_STATUS)                     |
| UPDATE_AT     | TEXT          | No       | 更新日付                           |

### 2.3. M_GENRE_MAJOR テーブル

[マスタテーブル]
| Column Name   | Data Type     | Nullable | Description                       |
|---------------|---------------|----------|-----------------------------------|
| CODE          | INTEGER       | No       | PK (auto-increment)               |
| NAME          | TEXT          | No       |                                   |
| UPDATE_AT     | TEXT          | No       | 更新日付                           |

### 2.4. M_GENRE_DETAIL テーブル

[マスタテーブル]
| Column Name   | Data Type     | Nullable | Description                       |
|---------------|---------------|----------|-----------------------------------|
| CODE          | INTEGER       | No       | PK (auto-increment)               |
| MAJOR_CODE    | INTEGER       | No       | FK (M_GENRE_MAJOR)                |
| NAME          | TEXT          | No       |                                   |
| UPDATE_AT     | TEXT          | No       | 更新日付                           |

### 2.5. M_STATUS テーブル

[マスタテーブル]
| Column Name   | Data Type     | Nullable | Description                       |
|---------------|---------------|----------|-----------------------------------|
| CODE          | INTEGER       | No       | PK (auto-increment)               |
| NAME          | TEXT          | No       |                                   |
| UPDATE_AT     | TEXT          | No       | 更新日付                           |

### 2.6. M_PLATFORM テーブル

[マスタテーブル]
| Column Name   | Data Type     | Nullable | Description                       |
|---------------|---------------|----------|-----------------------------------|
| CODE          | INTEGER       | No       | PK (auto-increment)               |
| NAME          | TEXT          | No       |                                   |
| UPDATE_AT     | TEXT          | No       | 更新日付                           |
---

## 3. 備考

- `Status`列は「Backlog」「Playing」「Cleared」などの値を想定しています。
- `Id`列は主キーで自動採番されます。
- 文字列長は暫定値です。必要に応じて調整してください。
- この定義はEF CoreのCode Firstを前提としています。

---