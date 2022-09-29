using Microsoft.EntityFrameworkCore;
using ELEmail.Models;

namespace ELEmail.Data.DbContexts
{
    public class ProvedorEmailContext
    {
        public void InitCreatingCmdProvedor(ModelBuilder modelBuilder)
        {
            CreatingCmdProvedorEmail(modelBuilder);
        }

        private void CreatingCmdProvedorEmail(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProvedorEmail>(p =>
            {
                p.HasKey(e => e.IdProvedor);
                p.Property(e => e.IdProvedor).UseIdentityAlwaysColumn();

                p.Property(e => e.Cliente).HasColumnType("varchar(30)");

                p.Property(e => e.Provedor).HasColumnType("varchar(30)");

                p.Property(e => e.Ssl).HasColumnType("boolean");

                p.Property(e => e.Tsl).HasColumnType("boolean");

                p.Property(e => e.Porta).HasColumnType("int");
            });
        }
    }
}
