using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ELEmail.Models
{
    [Table("ProvedorEmail")]
    public class ProvedorEmail
    {
        public int IdProvedor { get; set; }
        public string IdCliente { get; set; }
        public string Provedor { get; set; }
        public bool Ssl { get; set; }
        public bool Tsl { get; set; }
        public int Porta { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
