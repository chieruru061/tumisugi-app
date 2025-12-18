using System.ComponentModel.DataAnnotations;

namespace tumisugi_app.Models.Entities
{
    /// <summary>
    /// ジャンル・小分類Entity
    /// </summary>
    public class GenreMajor
    {
        // 主キー
        [Key]
        public int Code { get; set; }
        public required string Name { get; set; } = null!;
        public required string UpdateAt { get; set; } = null!;
        public required ICollection<GenreDetail> GenreDeitails { get; set;}
    }
}