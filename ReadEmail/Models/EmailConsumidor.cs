using System.ComponentModel.DataAnnotations.Schema;

namespace ELEmail.Models
{
    [Table("cmd_email_consumidor")]
    public class EmailConsumidor
    {
        public int IdEmail { get; set; }
        public DateTime Data { get; set; }
        public string? Assunto { get; set; }
        public string? Mensagem { get; set; }
        public string? Loja { get; set; }
        public string? Carro { get; set; }
        public string? Modelo { get; set; }
    }
}
