using System.ComponentModel.DataAnnotations;

namespace TumisugiApp.Models.Entities
{
    public class TumiHistory
    {
        // 主キー
        [Key]
        public int Id { get; set; }
        // 積みID 外部キー
        public required int TumiId { get; set; }
        public required TumiManagement TumiManage { get; set; }
        // 状態
        public required int StatusCode { get; set; }
        public required Status Status { get; set; }
        // 更新日付
        public required string UpdateAt { get; set; } = null!;
    }
}