using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using L01P02_2020_CP_601_2020_CD_602.Models;

namespace L01P02_2020_CP_601_2020_CD_602.Models
{
    public class blogContext : DbContext
    {
        public blogContext(DbContextOptions<blogContext> options) : base(options)
        {


        }
        public DbSet<usuarios> usuarios { get; set; }
        public DbSet<publicaciones> publicaciones { get; set; }
        public DbSet<L01P02_2020_CP_601_2020_CD_602.Models.calificaciones>? calificaciones { get; set; }
        public DbSet<L01P02_2020_CP_601_2020_CD_602.Models.comentarios>? comentarios { get; set; }
    }
}
