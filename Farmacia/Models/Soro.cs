using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Farmacia.Models
{
    public class Soro
    {
        [Key]
        [Column("idSoro")]
        public int idSoro { get; set; }

        [Required(ErrorMessage = "Informe o nome do Soro")]
        public string nomeSoro { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o preço do Soro")]
        public decimal precoSoro { get; set; }

        [Required(ErrorMessage = "Informe a quantidade de stock do Soro")]
        public int stockSoro { get; set; }

        [Required(ErrorMessage = "Informe a data de fabrico do Soro")]
        public DateTime dataFabricoSoro { get; set; }

        [Required(ErrorMessage = "Informe a data de expiração do Soro")]
        public DateTime dataExpiracaoSoro { get; set; }

        [Required(ErrorMessage = "Informe a descrição do Soro")]
        public string descricaoSoro { get; set; } = string.Empty;
    }
}
