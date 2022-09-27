using System.ComponentModel.DataAnnotations.Schema;

namespace ELEmail.Models
{
    [Table("CapturaEmails")]
    public class CapturaEmails
    {
        public int IdCaptura { get; set; }
        public int IdProvedor { get; set; }
        public int IdConsumidor { get; set; }
        public DateTime DataCaptura { get; set; }
        public TimeOnly HoraCaptura { get; set; }
        public DateTime DataEmailRebido { get; set; }
        public TimeOnly HoraEmailRebido { get; set; }
        public bool IsFeriado { get; set; }
        public bool IsForaRotina { get; set; }
    }
}
