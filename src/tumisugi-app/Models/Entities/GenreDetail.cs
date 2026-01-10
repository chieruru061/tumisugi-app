using System.ComponentModel.DataAnnotations;

namespace TumisugiApp.Models.Entities
{
    /// <summary>
    /// ジャンル・小分類Entity
    /// </summary>
    public class GenreDetail
    {
        // 主キー
        [Key]
        public int Code { get; set; }
        // GenreMajorの外部キー
        public int GenreMajorCode { get; set; }
        public required GenreMajor GenreMajor { get; set; }
        public required string Name { get; set; } = null!;
        public required string UpdateAt { get; set; } = null!;
    }
}