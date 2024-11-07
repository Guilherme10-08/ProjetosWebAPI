using Farmacia.DataContext;
using Farmacia.Models;

namespace Farmacia.PopularDataBase
{
    public class Popular
    {
        public static async Task PopularMinhaBase(MyDataContext context)
        {
           
            var AmpolaLista = new List<Ampola>()
            {
                new Ampola{idAmpola = 1, nomeAmpola = "Diclofenac", precoAmpola = 200, stockAmpola = 100, dataFabricoAmpola = DateTime.Now, dataExpiracaoAmpola = DateTime.Now.AddYears(5)},
                new Ampola{idAmpola = 2, nomeAmpola = "Arthemeter", precoAmpola = 300, stockAmpola = 100, dataFabricoAmpola = DateTime.Now, dataExpiracaoAmpola = DateTime.Now.AddYears(5)},
                new Ampola{idAmpola = 3, nomeAmpola = "Dexametazona", precoAmpola = 500, stockAmpola = 100, dataFabricoAmpola = DateTime.Now, dataExpiracaoAmpola = DateTime.Now.AddYears(5)},
                new Ampola{idAmpola = 4, nomeAmpola = "Dipirona", precoAmpola = 250, stockAmpola = 100, dataFabricoAmpola = DateTime.Now, dataExpiracaoAmpola = DateTime.Now.AddYears(5)}
            };

            try
            {
                context.AddRange(AmpolaLista.ToArray());

                await context.SaveChangesAsync();
            }
            catch
            {

            }
           

        }
    }
}
