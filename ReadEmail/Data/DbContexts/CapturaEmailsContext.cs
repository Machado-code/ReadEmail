using Microsoft.EntityFrameworkCore;
using ELEmail.Models;

namespace ELEmail.Data.DbContexts
{
    public class CapturaEmailsContext
    {
        public void InitCreatingCmdCapturaEmails(ModelBuilder modelBuilder)
        {
            CreatingCmdCapturaEmails(modelBuilder);
        }

        private void CreatingCmdCapturaEmails(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CapturaEmails>(p =>
            {
                p.HasKey(e => e.IdCaptura);
                p.Property(e => e.IdCaptura).UseIdentityAlwaysColumn();

                p.Property(e => e.IdProvedor).HasColumnType("int");

                p.Property(e => e.IdConsumidor).HasColumnType("int");

                p.Property(e => e.DataCaptura).HasColumnType("timestamp");

                p.Property(e => e.HoraCaptura).HasColumnType("time");

                p.Property(e => e.DataEmailRebido).HasColumnType("timestamp");
                
                p.Property(e => e.HoraEmailRebido).HasColumnType("time");

                p.Property(e => e.IsFeriado).HasColumnType("bool");
                
                p.Property(e => e.IsForaRotina).HasColumnType("bool");

            });
        }
    }
}
