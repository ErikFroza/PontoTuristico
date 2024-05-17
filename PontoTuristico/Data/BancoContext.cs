using Microsoft.EntityFrameworkCore;
using PontoTuristico.Models;

namespace PontoTuristico.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<PontoTuristicoModel> PontoTuristico { get; set; }
    }
}
