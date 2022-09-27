using Microsoft.EntityFrameworkCore;
using ELEmail.Models;

namespace ELEmail.Data.DbContexts
{
    public class EmailContext
    {
        public void InitCreatingCmdEmail(ModelBuilder modelBuider)
        {
            CreatingCmdEmail(modelBuider);
        }

        private void CreatingCmdEmail(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmailConsumidor>(p =>
            {
                p.HasKey(e => e.IdEmail);
                p.Property(e => e.IdEmail).UseIdentityAlwaysColumn();

                p.Property(e => e.Data).HasColumnType("timestamp");

                p.Property(e => e.Assunto).HasColumnType("varchar(100)");

                p.Property(e => e.Mensagem).HasColumnType("varchar(200)");

                p.Property(e => e.Loja).HasColumnType("varchar(50)");

                p.Property(e => e.Carro).HasColumnType("varchar(30)");

                p.Property(e => e.Modelo).HasColumnType("varchar(30)");
            });
        }
    }
}
