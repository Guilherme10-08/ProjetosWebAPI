using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Frutticultura.Models
{
	[Table("fruta")]
	public class Frutta
	{
		[Key]
		public int idFrutta {  get; set; }

		[Required(ErrorMessage = "Campo Obrigatório!")]
		public string nomeFrutta { get; set; } = string.Empty;

		[Required(ErrorMessage = "Campo Obrigatório!")]
		public string descricaoFrutta { get; set; } = string.Empty;

		[Required]
		public Arvore? arvoreNome { get; set; }

	}
}
