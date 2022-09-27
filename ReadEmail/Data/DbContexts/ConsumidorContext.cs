using Microsoft.EntityFrameworkCore;
using ELEmail.Models;

namespace ELEmail.Data.DbContexts
{
    public class ConsumidorContext
    {
        public void InitCreatingCmdConsumidor(ModelBuilder modelBuilder)
        {
            CreatingCmdConsumidor(modelBuilder);
        }

        private void CreatingCmdConsumidor(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Consumidor>(p =>
            {
                p.HasKey(e => e.IdConsumidor);
                p.Property(e => e.IdConsumidor).UseIdentityAlwaysColumn();

                p.Property(e => e.IdEmail).HasColumnType("int");

                p.Property(e => e.Nome).HasColumnType("varchar(50)");

                p.Property(e => e.Telefone).HasColumnType("varchar(15)");

                p.Property(e => e.Email).HasColumnType("varchar(50)");
            });
        }
    }
}
