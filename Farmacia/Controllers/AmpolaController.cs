using Farmacia.DataContext;
using Farmacia.Models;
using Farmacia.PopularDataBase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Farmacia.Controllers
{
    [Route("ampola")]
    public class AmpolaController:ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Ampola>>> GetAll([FromServices] MyDataContext context)
        {
            try
            {
                await Popular.PopularMinhaBase(context);

                var listaAmpola = await context.Ampolas.AsNoTracking().ToListAsync();

                return Ok(listaAmpola);
            }
            catch
            {
                return BadRequest(ModelState);
            }
            

        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Ampola>> GetOne(int id, [FromServices] MyDataContext context)
        {
            try
            {
                var ampola = await context.Ampolas.AsNoTracking().FirstOrDefaultAsync(x => x.idAmpola == id);

                if (ampola.idAmpola == id)
                {
                    return Ok(ampola);
                }
                else
                {
                    return NotFound();
                }
            }
            catch
            {
                return BadRequest(ModelState);
            }
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Ampola>> Post([FromBody] Ampola ampola, [FromServices] MyDataContext context)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                context.Ampolas.Add(ampola);

                await context.SaveChangesAsync();

                return Ok(new { message = "Produto inserido com sucesso!" });
            }
            catch
            {
                return BadRequest(ModelState);
            }
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<Ampola>> Put(int id, [FromBody] Ampola ampola, [FromServices] MyDataContext context)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                if (ampola.idAmpola == id)
                {
                    context.Entry<Ampola>(ampola).State = EntityState.Modified;

                    await context.SaveChangesAsync();

                    return Ok(new { message = "dados atualizados com sucesso!" });
                }
                else
                {
                    return NotFound();
                }
            }
            catch
            {
                return BadRequest(ModelState);
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<Ampola>> Delete(int id, [FromServices] MyDataContext context)
        {
            try
            {
                var ampola = await context.Ampolas.AsNoTracking().FirstOrDefaultAsync(x => x.idAmpola == id);

                if(ampola == null)
                {
                    return NotFound();
                }
                else
                {
                    context.Ampolas.Remove(ampola);

                    await context.SaveChangesAsync();

                    return Ok(new { message = "dados deletados com sucesso!" });
                }
            }
            catch
            {
                return BadRequest(ModelState);
            }
        }

    }
}
