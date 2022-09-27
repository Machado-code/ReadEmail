using System.ComponentModel.DataAnnotations.Schema;

namespace ELEmail.Models
{
    [Table("Consumidor")]
    public class Consumidor
    {
        public int IdConsumidor { get; set; }
        public int IdEmail { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
