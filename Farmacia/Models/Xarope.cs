
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Farmacia.Models
{
    public class Xarope
    {
        [Key]
        [Column("idXarope")]
        public int idXarope { get; set; }

        [Required(ErrorMessage = "Informe o nome do xarope")]
        public string nomeXarope { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o preço do xarope")]
        public decimal precoXarope { get; set; }

        [Required(ErrorMessage = "Informe a quantidade de stock do xarope")]
        public int stockXarope { get; set; }

        [Required(ErrorMessage = "Informe a data de fabrico do xarope")]
        public DateTime dataFabricoXarope { get; set; }

        [Required(ErrorMessage = "Informe a data de expiração do xarope")]
        public DateTime dataExpiracaoXarope { get; set; }

        [Required(ErrorMessage = "Informe a descrição do xarope")]
        public string descricaoXarope { get; set; } = string.Empty;
    }
}
