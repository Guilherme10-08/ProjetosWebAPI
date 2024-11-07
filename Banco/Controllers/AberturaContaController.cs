using Banco.DataContext;
using Banco.Models;
using Banco.PopularBase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Banco.Controllers
{
    [Route("aberturaconta")]
    public class AberturaContaController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<AberturaConta>>> GetAll(AberturaConta aberturaConta, [FromServices] MyDataContext context)
        {
            try
            {
                var listaCliente = await context.AberturaContas.AsNoTracking().ToListAsync();

                //await Popular.PopularMinhaBase(context);

                if (!listaCliente.Any())
                {
                    return NotFound(new { message = "não foi encontrado nenhum cliente" });
                }
                else
                {
                    return Ok(listaCliente);
                }
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<AberturaConta>> GetOne(int id, [FromServices] MyDataContext context)
        {
            try
            {
                var cliente = await context.AberturaContas.AsNoTracking().FirstOrDefaultAsync(x => x.idCliente == id);

                if (cliente.idCliente == id)
                {
                    return Ok(cliente);
                }
                else
                {
                    return NotFound(new { message = "Não foi encontrado nenhum registro que corresponde ao id pasado na requisição" });

                }
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<AberturaConta>> Post([FromBody] AberturaConta aberturaConta, [FromServices] MyDataContext context)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                else
                {
                    context.AberturaContas.Add(aberturaConta);

                    await context.SaveChangesAsync();

                    return Ok($"{new { message = "Conta Criada com sucesso!" }} {aberturaConta}");
                }
            }
            catch
            {
                return BadRequest(ModelState);
            }
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<AberturaConta>> Put(int id, [FromBody] AberturaConta aberturaConta, [FromServices] MyDataContext context) 
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                if (aberturaConta.idCliente == id)
                {
                    context.Entry<AberturaConta>(aberturaConta).State = EntityState.Modified;

                    await context.SaveChangesAsync();

                    return Ok(new { message = "Dados atualizados com sucesso!" });
                }
                else
                {
                    return NotFound(new {message = "Não foi encontrado nenhum registro que corresponde ao id passado na requisição"});
                }
            }
            catch
            {
                return BadRequest(ModelState);
            }

        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<AberturaConta>> Delete(int id,[FromServices] MyDataContext context)
        {
            try
            {
                var cliente = await context.AberturaContas.FirstOrDefaultAsync(x => x.idCliente == id);

                if (cliente.idCliente == id)
                {
                    context.AberturaContas.Remove(cliente);

                    await context.SaveChangesAsync();

                    return Ok(new { message = "cliente removido com sucesso!" });

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
    }
}
