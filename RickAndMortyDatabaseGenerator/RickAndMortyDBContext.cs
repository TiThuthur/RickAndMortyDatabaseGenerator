using Microsoft.EntityFrameworkCore;
using Rick;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMortyDatabaseGenerator
{
    public class RickAndMortyDBContext : DbContext
    {
        public DbSet<Characters> Characters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string databaseName = "RickAndMortyCharacters.db";
            optionsBuilder.UseSqlite($"Data Source={databaseName}");
        }
    }
}
