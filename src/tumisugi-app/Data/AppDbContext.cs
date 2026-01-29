using Microsoft.EntityFrameworkCore;
using TumisugiApp.Models.Entities;

namespace TumisugiApp.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<TumiManagement> TumiManagements { get; set; }
        public DbSet<TumiHistory> TumiHistories { get; set; }
        public DbSet<GenreMajor> GetGenreMajors { get; set; }
        public DbSet<GenreDetail> GetGenreDetails { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<Status> Statuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Master table
            modelBuilder.Entity<GenreMajor>().HasData(
                // Codeは自動採番ではあるが、直接insertもできるらしい
                new GenreMajor { Code = 1, Name = "Game", UpdateAt = "2026-01-28 00:00:00"},
                new GenreMajor { Code = 2, Name = "Anime", UpdateAt = "2026-01-28 00:00:00"},
                new GenreMajor { Code = 3, Name = "Book", UpdateAt = "2026-01-28 00:00:00"}
            );

            modelBuilder.Entity<GenreDetail>().HasData(
                new GenreDetail { Code = 1, GenreMajorCode = 1, Name = "RPG", UpdateAt = "2026-01-28 00:00:00"},
                new GenreDetail { Code = 2, GenreMajorCode = 1, Name = "アクション", UpdateAt = "2026-01-28 00:00:00"},
                new GenreDetail { Code = 3, GenreMajorCode = 1, Name = "アドベンチャー", UpdateAt = "2026-01-28 00:00:00"},
                new GenreDetail { Code = 4, GenreMajorCode = 1, Name = "ストラテジ", UpdateAt = "2026-01-28 00:00:00"},
                new GenreDetail { Code = 5, GenreMajorCode = 1, Name = "レース", UpdateAt = "2026-01-28 00:00:00"},
                new GenreDetail { Code = 6, GenreMajorCode = 1, Name = "音ゲー", UpdateAt = "2026-01-28 00:00:00"},
                new GenreDetail { Code = 7, GenreMajorCode = 1, Name = "STG", UpdateAt = "2026-01-28 00:00:00"},
                new GenreDetail { Code = 8, GenreMajorCode = 1, Name = "カード", UpdateAt = "2026-01-28 00:00:00"},
                new GenreDetail { Code = 9, GenreMajorCode = 1, Name = "ギャルゲ", UpdateAt = "2026-01-28 00:00:00"},
                new GenreDetail { Code = 99, GenreMajorCode = 1, Name = "その他", UpdateAt = "2026-01-28 00:00:00"}
            );

            modelBuilder.Entity<Status>().HasData(
                new Status { Code = 1, Name = "未購入", UpdateAt = "2026-01-28 00:00:00"},
                new Status { Code = 2, Name = "未プレイ", UpdateAt = "2026-01-28 00:00:00"},
                new Status { Code = 3, Name = "放置中", UpdateAt = "2026-01-28 00:00:00"},
                new Status { Code = 4, Name = "プレイ中", UpdateAt = "2026-01-28 00:00:00"},
                new Status { Code = 5, Name = "積み解消", UpdateAt = "2026-01-28 00:00:00"}
            );

            modelBuilder.Entity<Platform>().HasData(
                new Platform { Code = 1, Name = "PC", UpdateAt = "2026-01-28 00:00:00"},
                new Platform { Code = 2, Name = "PlayStation", UpdateAt = "2026-01-28 00:00:00"},
                new Platform { Code = 3, Name = "Switch", UpdateAt = "2026-01-28 00:00:00"},
                new Platform { Code = 4, Name = "Mobile", UpdateAt = "2026-01-28 00:00:00"},
                new Platform { Code = 5, Name = "Web", UpdateAt = "2026-01-28 00:00:00"},
                new Platform { Code = 6, Name = "others", UpdateAt = "2026-01-28 00:00:00"}
            );

            // Transaction table
            modelBuilder.Entity<TumiManagement>().HasData(
                new TumiManagement
                {
                    Id = 1,
                    Name = "Fate/StayNight",
                    GenreMajorCode = 1,
                    GanreDetailCode = 1,
                    StatusCode = 3,
                    PlatformCode = 1,
                    Memo = "セイバールートのみクリアしているが他ルートもやりたい...",
                    UpdateAt = "2026-01-28 00:00:00"                                   
                }
            );

            modelBuilder.Entity<TumiHistory>().HasData(
                new TumiHistory { Id = 1, TumiId = 1, StatusCode = 3, UpdateAt = "2026-01-28 00:00:00"}
            );
        }
    }
}