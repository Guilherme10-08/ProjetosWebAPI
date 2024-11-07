using Frutticultura.DataContext;
using Frutticultura.Models;
using Microsoft.AspNetCore.Mvc;
using Mysqlx;

namespace Frutticultura.Preenchimento
{
	public class Popular
	{
		public static async Task PopulandoMinhaBase(MyContext myContext)
		{
			var ListaArvore = new List<Arvore>()
			{
				new Arvore{idArvore = 1, nomeArvore = "Mangueira", descricaoArvore = "Árvore Mangueira"},
				new Arvore{idArvore = 2, nomeArvore = "Bananeira", descricaoArvore = "Árvore Baneneira"}
			};

			try
			{
				myContext.Arvores.AddRange(ListaArvore.ToArray());

				await myContext.SaveChangesAsync();
			}
			catch
			{

			}

		} 
	}
}
