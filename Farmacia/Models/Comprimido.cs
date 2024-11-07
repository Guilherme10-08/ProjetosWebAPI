using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Farmacia.Models
{
    [Table("comprimido")]
    public class Comprimido
    {
        [Key]
        [Column("idComprimido")]
        public int idComprimido { get; set; }

        [Required(ErrorMessage = "Informe o nome do comprimido")]
        public string nomeComprimido { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o preço do comprimido")]
        public decimal precoComprimido { get; set; }

        [Required(ErrorMessage = "Informe a quantidade de stock do comprimido")]
        public int stockComprimido { get; set; }

        [Required(ErrorMessage = "Informe a data de fabrico do comprimido")]
        public DateTime dataFabricoComprimido { get; set; }

        [Required(ErrorMessage = "Informe a data de expiração do comprimido")]
        public DateTime dataExpiracaoComprimido { get; set; }

        [Required(ErrorMessage = "Informe a descrição do comprimido")]
        public string descricaoComprimido { get; set; } = string.Empty;

    }
}
