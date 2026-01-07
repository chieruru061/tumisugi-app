using System.ComponentModel.DataAnnotations;

namespace tumisugi_app.Models.Entities
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
        // 小分類
        public required ICollection<GenreDetail> Details { get; set;}
    }
}