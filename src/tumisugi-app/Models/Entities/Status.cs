using System.ComponentModel.DataAnnotations;

namespace TumisugiApp.Models.Entities
{
    /// <summary>
    /// 積み状態Entity
    /// </summary>
    public class Status
    {
        // 主キー
        [Key]
        public int Code { get; set; }
        public required string Name { get; set; } = null!;
        public required string UpdateAt { get; set; } = null!;
    }
}