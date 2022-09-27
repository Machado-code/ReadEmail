using Microsoft.EntityFrameworkCore;
using ELEmail.Data.DbContexts;
using ELEmail.Models;

namespace ELEmail.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        public DbSet<ProvedorEmail>? ProvedorEmail { get; set; }
        public DbSet<CapturaEmails>? CapturaEmails { get; set; }
        public DbSet<Consumidor>? Consumidor { get; set; }
        public DbSet<EmailConsumidor>? Email { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ProvedorEmailContext provedorEmailContext = new ProvedorEmailContext();
            provedorEmailContext.InitCreatingCmdProvedor(modelBuilder);

            CapturaEmailsContext capturaEmailsContext = new CapturaEmailsContext();
            capturaEmailsContext.InitCreatingCmdCapturaEmails(modelBuilder);

            ConsumidorContext consumidorContext = new ConsumidorContext();
            consumidorContext.InitCreatingCmdConsumidor(modelBuilder);

            EmailContext emailContext = new EmailContext();
            emailContext.InitCreatingCmdEmail(modelBuilder);
        }
    }
}

