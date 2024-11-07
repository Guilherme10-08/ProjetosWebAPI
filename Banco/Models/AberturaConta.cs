
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Banco.Models
{
    [Table("aberturaconta")]
    public class AberturaConta
    {
        [Key]
        [Column("idCliente")]
        public int idCliente { get; set; }

        [Required(ErrorMessage = "Informe o nome completo do cliente")]
        public string nomeCliente { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o número de bilhete de identidade do cliente")]
        public string numeroBilheteIdentidadeCliente { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o tipo de moeda")]
        public string tipoMoedaCliente { get; set; } = string.Empty;

        [Required(ErrorMessage = "A conta precisa de um saldo inicial de pelo menos 5 mil kz")]
        [Range(5000,(500000000*2),ErrorMessage = "A conta precisa de um saldo inicial de pelo menos 5 mil kz")]  
        public decimal saldoContaCliente { get; set; }
       
        public string numeroContaCliente { get; set; } = Guid.NewGuid().ToString().Substring(0, 15);
        public string numeroIbanCliente { get; set; } = Guid.NewGuid().ToString().Substring(0, 21);
        public DateTime dataAberturaContaCliente { get; set; } = DateTime.Now;
    }
}
