using Frutticultura.DataContext;
using Frutticultura.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Frutticultura.Controllers
{
	[Route("frutta")]
	public class FruttaController : ControllerBase
	{
		[HttpGet]
		[Route("")]
		public async Task<ActionResult<List<Frutta>>> GetAll([FromServices] MyContext context)
		{
			try
			{
				var ListaFrutas = await context.Fruttas.AsNoTracking().ToListAsync();

				return new List<Frutta>(ListaFrutas);

				//return Ok(ListaFrutas);
			}
			catch
			{
				return BadRequest(ModelState);
			}
			
		}

		[HttpGet]
		[Route("{id:int}")]
		public async Task<ActionResult<Frutta>> GetOne(int id, [FromServices] MyContext context)
		{
			var frutta = await context.Fruttas.AsNoTracking().FirstOrDefaultAsync(x => x.idFrutta == id);

			try
			{
				if (id == frutta.idFrutta)
				{
					return Ok(frutta);
				}
				else
				{
					return NotFound(new { message = "Não foram encontrados nenhum registro que corresponde ao id passado na requisaição!" });
				}
			}
			catch
			{
				return BadRequest(ModelState);
			}
			
		}

		[HttpPost]
		[Route("")]
		public async Task<ActionResult<Frutta>> Insert([FromBody] Frutta frutta, [FromServices] MyContext context)
		{
			try
			{
				if (!ModelState.IsValid)
				{
					return BadRequest(ModelState);
				}
				else
				{
					context.Fruttas.Add(frutta);

					await context.SaveChangesAsync();

					return Ok($"Dados inseridos com sucesso! {frutta}");
				}
			}
			catch
			{
				return BadRequest(new { message = "Upps...houve um erro ao fazer a requisição, verifique os dados e tente novamente!" });
			}
		}

		[HttpPut]
		[Route("{id:int}")]
		public async Task<ActionResult<Frutta>> Update(int id, [FromBody] Frutta frutta, [FromServices] MyContext context)
		{
			try
			{
				if (!ModelState.IsValid)
				{
					return BadRequest(ModelState);
				}
				else
				{
					var fr = await context.Fruttas.AsNoTracking().FirstOrDefaultAsync(x => x.idFrutta == id);

					if (fr.idFrutta == id)
					{
						context.Entry<Frutta>(frutta).State = EntityState.Modified;

						await context.SaveChangesAsync();

						return Ok("Dados atualizados com suceso");
					}
					else
					{
						return NotFound();
					}
					
				}
			}
			catch
			{
				return BadRequest(new { message = "Upps...houve um erro ao fazer a requisição, verifique os dados e tente novamente!" });
			}
		}

		[HttpDelete]
		[Route("{id:int}")]
		public async Task<ActionResult<Frutta>> Delete(int id, [FromServices] MyContext context)
		{
			try
			{
				var frutta = await context.Fruttas.AsNoTracking().FirstOrDefaultAsync(X => X.idFrutta == id);
				
				if (id == frutta.idFrutta)
				{
					context.Fruttas.Remove(frutta);

					await context.SaveChangesAsync();

					return Ok(new {message = "Dados deletados com sucesso!"});
				}
				else
				{
					return NotFound(new { message = "Não foram encontrados nenhum registro que corresponde ao id passado na requisaição!" });
				}
			}
			catch
			{
				return BadRequest(new { message = "Upps...houve um erro ao fazer a requisição, verifique os dados e tente novamente!" });
			}
		}
	}
}
