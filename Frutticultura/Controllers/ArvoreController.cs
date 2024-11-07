using Frutticultura.DataContext;
using Frutticultura.Models;
using Frutticultura.Preenchimento;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication;

namespace Frutticultura.Controllers
{
	[Route("arvore")]
	public class ArvoreController : ControllerBase
	{
		[HttpGet]
		[Route("")]
		public async Task<ActionResult<List<Arvore>>> GetAll([FromServices] MyContext context)
		{
			try
			{
				await Popular.PopulandoMinhaBase(context);

				var listaArvore = await context.Arvores.AsNoTracking().ToListAsync();

				return new List<Arvore>(listaArvore);
			}
			catch
			{
				return BadRequest(new { message = "Upps...algo deu errado!" });
			}

		}

		[HttpGet]
		[Route("{id:int}")]
		public async Task<ActionResult<Arvore>> GetOne(int id, [FromServices] MyContext context)
		{
			var arvore = await context.Arvores.AsNoTracking().FirstOrDefaultAsync(x => x.idArvore == id);

			if (arvore.idArvore == id)
			{
				return Ok(arvore);
			}
			else
			{
				return NotFound(new { message = "Não foi encontrado nenhum registro que corresponde ao id passado na requisão" + id });
			}

		}

		[HttpPost]
		[Route("")]
		public async Task<ActionResult<Arvore>> Post(Arvore arvore, [FromServices] MyContext context)
		{
			try
			{
				if (!ModelState.IsValid)
				{
					return BadRequest(ModelState);
				}

				else
				{
					context.Arvores.Add(arvore);

					await context.SaveChangesAsync();

					return Ok(new { message = "Dados inseridos com sucesso!" });
				}
			}
			catch
			{
				return BadRequest();
			}
		}

		[HttpPut]
		[Route("{id:int}")]
		public async Task<ActionResult<Arvore>> Put(int id, [FromBody] Arvore arvore, [FromServices] MyContext context)
		{
			var arvor = await context.Arvores.FirstOrDefaultAsync(x => x.idArvore == id);

			try
			{
				if (!ModelState.IsValid)
				{
					return BadRequest(ModelState);
				}

				if (arvor.idArvore == id)
				{
					context.Entry<Arvore>(arvore).State = EntityState.Modified;

					await context.SaveChangesAsync();

					return Ok(new { message = "Dados atualizados com sucesso!" });
				}
				else
				{
					return NotFound(new { message = "Não foram encontrados nenhum registro que corresponde ao id passado na requisição!" });
				}
			}
			catch
			{
				return BadRequest(new { message = "Upps...algo deu errado" });
			}
		}

		[HttpDelete]
		[Route("{id:int}")]
		public async Task<ActionResult<Arvore>> Delete(int id, [FromServices] MyContext context)
		{
			var arvore = await context.Arvores.FirstOrDefaultAsync(x => x.idArvore == id);
			try
			{
				context.Arvores.Remove(arvore);

				await context.SaveChangesAsync();

				return Ok(new { message = "Dados deletados com sucesso" });
			}
			catch
			{
				return NotFound(new { message = "Não foram encontrados nenhum registro que corresponde ao id passado na requisição!" });
			}
		}

	}
}
