using System.ComponentModel.DataAnnotations;

namespace TumisugiApp.Models.Entities
{
    public class TumiManagement
    {
        // 主キー
        [Key]
        public int Id { get; set; }
        // タイトル
        public required string Name { get; set; } = null!;
        // ユーザID(将来つかうかも？)
        public int UserId { get; } = 1;
        // 大きな単位でのジャンル
        // var1.0はゲームのみを扱う
        public required int GenreMajorCode { get; set;}
        public required GenreMajor? GenreMajor { get; set; }
        // 詳細分類
        public required int GanreDetailCode { get; set; }
        public required GenreDetail? GenreDetail { get; set; }
        // 状態
        public required int StatusCode { get; set; }
        public required Status? Status { get; set; }
        // プラットフォーム
        public required int PlatformCode { get; set; }
        public required Platform? Platform { get; set; }
        // メモ
        public string? Memo { get; set; }
        // 更新日付
        public required string UpdateAt { get; set; } = null!;
        // TumiHistory
        public ICollection<TumiHistory>? Histories { get; set; }
    }
}