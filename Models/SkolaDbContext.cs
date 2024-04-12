using Avancerad.Net_Labb1.Klasser;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Avancerad.Net_Labb1.Models
{
    public class SkolaDbContext : DbContext

    {
       
        public DbSet<Klass> Klasser { get; set; }
        public DbSet<Lärare> Lärare { get; set; }
        public DbSet<Student> Studenter { get; set; }
        public DbSet<Ämne> Ämnen { get; set; }
        public DbSet<Kopplingstabell> Kopplingstabeller { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source = HUSIC;Initial Catalog = SkolaDbContext;Integrated Security=True;TrustServerCertificate=Yes;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ämne>().HasData(new Ämne { ÄmneId = 1, ÄmneNamn = "Mattematik" });
            modelBuilder.Entity<Ämne>().HasData(new Ämne { ÄmneId = 2, ÄmneNamn = "C#" });
            modelBuilder.Entity<Ämne>().HasData(new Ämne { ÄmneId = 3, ÄmneNamn = "Phyton" });
            modelBuilder.Entity<Ämne>().HasData(new Ämne { ÄmneId = 4, ÄmneNamn = "GoLang" });

            modelBuilder.Entity<Klass>().HasData(new Klass { KlassId = 1, KlassNamn = "SUT23" });
            modelBuilder.Entity<Klass>().HasData(new Klass { KlassId = 2, KlassNamn = "SUT22" });

            modelBuilder.Entity<Lärare>().HasData(new Lärare { LärarId = 1, LärarNamn = "Anas" });
            modelBuilder.Entity<Lärare>().HasData(new Lärare { LärarId = 2, LärarNamn = "Tobias" });
            modelBuilder.Entity<Lärare>().HasData(new Lärare { LärarId = 3, LärarNamn = "Lennart" });
            modelBuilder.Entity<Lärare>().HasData(new Lärare { LärarId = 4, LärarNamn = "Ali" });

            modelBuilder.Entity<Student>().HasData(new Student { StudentId = 1, StudentNamn = "Ermin" });
            modelBuilder.Entity<Student>().HasData(new Student { StudentId = 2, StudentNamn = "Oskar" });
            modelBuilder.Entity<Student>().HasData(new Student { StudentId = 3, StudentNamn = "Ludde" });
            modelBuilder.Entity<Student>().HasData(new Student { StudentId = 4, StudentNamn = "Johan" });
            modelBuilder.Entity<Student>().HasData(new Student { StudentId = 5, StudentNamn = "Aska" });
            modelBuilder.Entity<Student>().HasData(new Student { StudentId = 6, StudentNamn = "Simon" });
            modelBuilder.Entity<Student>().HasData(new Student { StudentId = 7, StudentNamn = "Ali" });
            modelBuilder.Entity<Student>().HasData(new Student { StudentId = 8, StudentNamn = "Mohamed" });
            modelBuilder.Entity<Student>().HasData(new Student { StudentId = 9, StudentNamn = "Shahram" });
            modelBuilder.Entity<Student>().HasData(new Student { StudentId = 10, StudentNamn = "Ortiz" });
            modelBuilder.Entity<Student>().HasData(new Student { StudentId = 11, StudentNamn = "Markus" });
            modelBuilder.Entity<Student>().HasData(new Student { StudentId = 12, StudentNamn = "Fredrik" });

   
            modelBuilder.Entity<Kopplingstabell>().HasData(
                new Kopplingstabell { Id = 1, LärarId = 1, ÄmneId = 1, StudentId = 1, KlassId = 1 },
                new Kopplingstabell { Id = 2, LärarId = 2, ÄmneId = 1, StudentId = 2, KlassId = 1 },
                new Kopplingstabell { Id = 3, LärarId = 3, ÄmneId = 1, StudentId = 3, KlassId = 1 },
                new Kopplingstabell { Id = 4, LärarId = 4, ÄmneId = 2, StudentId = 4, KlassId = 1 },
                new Kopplingstabell { Id = 5, LärarId = 1, ÄmneId = 2, StudentId = 5, KlassId = 1 },
                new Kopplingstabell { Id = 6, LärarId = 2, ÄmneId = 2, StudentId = 6, KlassId = 1 },
                new Kopplingstabell { Id = 7, LärarId = 3, ÄmneId = 3, StudentId = 7, KlassId = 2 },
                new Kopplingstabell { Id = 8, LärarId = 4, ÄmneId = 3, StudentId = 8, KlassId = 2 },
                new Kopplingstabell { Id = 9, LärarId = 1, ÄmneId = 3, StudentId = 9, KlassId = 2 },
                new Kopplingstabell { Id = 10, LärarId = 2, ÄmneId = 4, StudentId = 10, KlassId = 2 },
                new Kopplingstabell { Id = 11, LärarId = 3, ÄmneId = 4, StudentId = 11, KlassId = 2 },
                new Kopplingstabell { Id = 12, LärarId = 4, ÄmneId = 4, StudentId = 12, KlassId = 2 }

                );
        }
    }
}
