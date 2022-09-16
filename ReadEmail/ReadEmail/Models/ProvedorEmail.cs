using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReadEmail.Models
{
    [Table("ProvedorEmail")]
    public class ProvedorEmail
    {
        public string ServidorEntradaPop { get; set; }
        public int Porta { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
