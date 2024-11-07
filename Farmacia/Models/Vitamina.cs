
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Farmacia.Models
{
    public class Vitamina
    {
        [Key]
        [Column("idVitamina")]
        public int idVitamina { get; set; }

        [Required(ErrorMessage = "Informe o nome da Vitamina")]
        public string nomeVitamina { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o preço da Vitamina")]
        public decimal precoVitamina { get; set; }

        [Required(ErrorMessage = "Informe a quantidade de stock da Vitamina")]
        public int stockVitamina { get; set; }

        [Required(ErrorMessage = "Informe a data de fabrico da Vitamina")]
        public DateTime dataFabricoVitamina { get; set; }

        [Required(ErrorMessage = "Informe a data de expiração da Vitamina")]
        public DateTime dataExpiracaoVitamina { get; set; }

        [Required(ErrorMessage = "Informe a descrição da Vitamina")]
        public string descricaoVitamina { get; set; } = string.Empty;
    }
}
