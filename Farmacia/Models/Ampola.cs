using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Farmacia.Models
{
    public class Ampola
    {
        [Key]
        [Column("idAmpola")]
        public int idAmpola { get; set; }

        [Required(ErrorMessage = "Informe o nome da Ampola")]
        public string nomeAmpola { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o preço da Ampola")]
        public decimal precoAmpola { get; set; }

        [Required(ErrorMessage = "Informe a quantidade de stock da Ampola")]
        public int stockAmpola { get; set; }

        [Required(ErrorMessage = "Informe a data de fabrico da Ampola")]
        public DateTime dataFabricoAmpola { get; set; }

        [Required(ErrorMessage = "Informe a data de expiração da Ampola")]
        public DateTime dataExpiracaoAmpola { get; set; }

        [Required(ErrorMessage = "Informe a descrição da Ampola")]
        public string descricaoAmpola { get; set; } = string.Empty;
    }
}
