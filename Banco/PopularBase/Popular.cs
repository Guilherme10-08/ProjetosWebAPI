using Banco.DataContext;
using Banco.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Banco.PopularBase
{
    public class Popular
    {
        public static async Task PopularMinhaBase(MyDataContext context)
        {
            var listaCliente = new List<AberturaConta>()
            {
                new AberturaConta{ idCliente = 1, nomeCliente = "Guilherme Sebastião", numeroBilheteIdentidadeCliente = "0123456789LA", tipoMoedaCliente = "AOA", saldoContaCliente = 10000, numeroContaCliente = Guid.NewGuid().ToString().Substring(0,15), numeroIbanCliente = Guid.NewGuid().ToString().Substring(0,21), dataAberturaContaCliente = DateTime.Now},
                 new AberturaConta{ idCliente = 2, nomeCliente = "Leandra de Caprio", numeroBilheteIdentidadeCliente = "987456123LA", tipoMoedaCliente = "AOA", saldoContaCliente = 50000, numeroContaCliente = Guid.NewGuid().ToString().Substring(0,15), numeroIbanCliente = Guid.NewGuid().ToString().Substring(0,21), dataAberturaContaCliente = DateTime.Now},
                  new AberturaConta{ idCliente = 3, nomeCliente = "Valentina Rossi", numeroBilheteIdentidadeCliente = "555555555LA", tipoMoedaCliente = "AOA", saldoContaCliente = 10000, numeroContaCliente = Guid.NewGuid().ToString().Substring(0,15), numeroIbanCliente = Guid.NewGuid().ToString().Substring(0,21), dataAberturaContaCliente = DateTime.Now}
            };

            try
            {
                context.AberturaContas.AddRange(listaCliente.ToArray());

                await context.SaveChangesAsync();
            }
            catch
            {
                
            }

        }
    }
}
