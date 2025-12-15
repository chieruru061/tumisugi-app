using System.ComponentModel.DataAnnotations;

namespace tumisugi_app.Models.Entities
{
    /// <summary>
    /// プラットフォームEntity
    /// </summary>
    public class Platform
    {
        // 主キー
        [Key]
        public int Code { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public string UpdateAt { get; set; } = null!;
    }
}