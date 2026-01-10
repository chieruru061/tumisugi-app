using System.ComponentModel.DataAnnotations;

namespace TumisugiApp.Models.Entities
{
    /// <summary>
    /// プラットフォームEntity
    /// </summary>
    public class Platform
    {
        // 主キー
        [Key]
        public int Code { get; set; }
        public required string Name { get; set; } = null!;
        public required string UpdateAt { get; set; } = null!;
    }
}