using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Frutticultura.Models
{
    [Table("arvore")]
	public class Arvore
	{
        [Key]
        public int idArvore { get; set; }

        [Required(ErrorMessage = "Informe o nome da árvore")]
        public string nomeArvore { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe a descrição da árvore")]
        public string descricaoArvore { get; set; } = string.Empty;
    }
}
