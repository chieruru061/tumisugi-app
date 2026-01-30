using System.ComponentModel.DataAnnotations;

namespace TumisugiApp.Models.ViewModels
{
    /// <summary>
    /// お積みものViewModel
    /// </summary>
    public class TumiItemViewModel
    {
        [Required]
        public int TumId { get; set; }
        
        [Required]
        [StringLength(100)]
        public required string Title { get; set; }

        [Required]
        public required string GanreName { get; set; }

        [Required]
        public required string PlatformName { get; set; }

        [Required]
        public required string StatusName { get; set; }
    }
}