using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GruppeOppgaveFinal.Models
{
     public class UfoContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder options)

            // connect to sqlite database
            => options.UseSqlite(@"Data Source=C:\Users\senai\OneDrive\Skrivebord\GruppeOppgaveFinal\GruppeOppgaveFinal\DB\Ufo2.db");

        
        public DbSet<Observasjoner> observasjoner { get; set; }
    }
}
