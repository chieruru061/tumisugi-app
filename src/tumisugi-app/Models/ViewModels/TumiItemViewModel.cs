using System.ComponentModel.DataAnnotations;

namespace TumisugiApp.Models.ViewModels
{
    /// <summary>
    /// 積みリスト表示用ViewModel（リスト全体 + 検索条件）。
    /// </summary>
    public class TumiListViewModel
    {
        public IEnumerable<TumiItemViewModel> Items { get; set; } = new List<TumiItemViewModel>(); //積みリストを表現
        public TumiListRequestViewModel Request { get; set; } = new TumiListRequestViewModel();
    }

    /// <summary>
    /// お積みものViewModel. お積みもの1recordを表現する。
    /// </summary>
    public class TumiItemViewModel
    {
        [Required]
        public int TumId { get; set; } //key
        
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

        /// <summary>
    /// 積みリスト検索条件ViewModel（リクエストパラメータ用）。
    /// </summary>
    public class TumiListRequestViewModel
    {
        public int Page { get; set; } // ページ       
        public string? Sort { get; set; }  // ソート
        public string? SearchTitle { get; set; }  // タイトル検索
        public string? SelectedGenre { get; set; }  // ジャンル選択
        public string? SelectedPlatform { get; set; }  // プラットフォーム選択
        public string? SelectedStatus { get; set; }  // ステータス選択
    }
    
}