using System.ComponentModel.DataAnnotations;

namespace TumisugiApp.Models.Entities
{
    /// <summary>
    /// ジャンル・大分類Entity
    /// </summary>
    public class GenreMajor
    {
        // 主キー
        [Key]
        public int Code { get; set; }
        public required string Name { get; set; } = null!;
        public required string UpdateAt { get; set; } = null!;
        // 小分類　子リレーションでは必須にする必要がない。Seed作成時にも邪魔になるからNullableに変更
        public ICollection<GenreDetail>? Details { get; set;}
    }
}

// 学習メモ
/*
- DBデザインが変更される場合は再度migrationが必要。子リレーションをnullableにしただけでは何も変わらないため、不要
- ナビゲーションプロパティはnullableとするのがふさわしい。Seed作成時にも邪魔になるため。
*/