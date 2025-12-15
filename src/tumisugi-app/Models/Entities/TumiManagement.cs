using System;
using System.ComponentModel.DataAnnotations;

namespace tumisugi_app.Models.Entities
{
    public class TumiManagement
    {
        // 主キー
        [Key]
        public int Id { get; set; }
        // タイトル
        [Required]
        public string Name { get; set; } = null!;
        // ユーザID(将来つかうかも？)
        // public int UserId { get; } = 1;
        // // 
        // public int GenreMajorCode { get; } = 1;
        // public int GanreDetailCode { get; set; }
        
    }
}