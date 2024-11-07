using Farmacia.DataContext;
using Farmacia.Models;
using Farmacia.PopularDataBase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Farmacia.Controllers
{
    [Route("comprimido")]
    public class ComprimidoController:ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Comprimido>>> GetAll([FromServices] MyDataContext context)
        {
            try
            {
                await Popular.PopularMinhaBase(context);

                var comprimido = await context.Comprimidos.AsNoTracking().ToListAsync();

                return Ok(comprimido);
            }
            catch
            {
                return BadRequest(ModelState);
            }
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Comprimido>> GetOne(int id, [FromServices] MyDataContext context)
        {
            try
            {
                var comprimido = await context.Comprimidos.AsNoTracking().FirstOrDefaultAsync(x => x.idComprimido == id);

                if (comprimido.idComprimido == id)
                {
                    return Ok(comprimido);
                }
                else
                {
                    return NotFound(new { message = "Não foi encontrado nenhum registro que corresponde ao id passado na requisição" });
                }
            }
            catch
            {
                return BadRequest(ModelState);
            }
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Comprimido>> Post([FromBody] Comprimido comprimido, [FromServices] MyDataContext context)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                else
                {
                    context.Comprimidos.Add(comprimido);

                    await context.SaveChangesAsync();

                    return Ok(comprimido);
                }
            }
            catch
            {
                return BadRequest(new { message = "Upps algo deu errado, verifique os dados e tente novamente!" });
            }
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<Comprimido>> Put(int id, [FromBody] Comprimido comprimido, [FromServices] MyDataContext context)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                if (comprimido.idComprimido == id)
                {
                    context.Entry<Comprimido>(comprimido).State = EntityState.Modified;

                    await context.SaveChangesAsync();

                    return Ok(comprimido);
                }
                else
                {
                    return NotFound(new { message = "Não foi encontrado nenhum registro que corresponde ao id passado narequisição" });

                }
            }
            catch
            {
                return BadRequest(ModelState);
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<Comprimido>> Delete(int id, [FromServices] MyDataContext context)
        {
            try
            {
                var compri = await context.Comprimidos.AsNoTracking().FirstOrDefaultAsync(x => x.idComprimido == id);

                if (compri.idComprimido == id)
                {
                    context.Comprimidos.Remove(compri);

                    await context.SaveChangesAsync();

                    return Ok("Dados deletados com sucesso!");
                }
                else
                {
                    return NotFound(new { message = "Não foi encontrado nenhum dados que corresponde ao id passado na requisição!" });
                }
            }
            catch
            {
                return BadRequest(ModelState);
            }
        }
    }
}
