using Microsoft.EntityFrameworkCore;
using TumisugiApp.Models.Entities;

namespace TumisugiApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<TumiManagement> TumiManagements { get; set; }
        public DbSet<TumiHistory> TumiHistories { get; set; }
        public DbSet<GenreMajor> GetGenreMajors { get; set; }
        public DbSet<GenreDetail> GetGenreDetails { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<Status> Statuses { get; set; }
    }
}