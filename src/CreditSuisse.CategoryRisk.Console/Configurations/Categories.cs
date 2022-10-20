using CreditSuisse.CategoryRisk.Domain.Business;
using CreditSuisse.CategoryRisk.Domain.Entity;
using System.Linq;

namespace CreditSuisse.CategoryRisk.Console.Configurations
{
    public class Categories
    {
        private List<ITrade> listPortifolio;
              

        public Categories(List<ITrade> listPortifolio)
        {
            this.listPortifolio = listPortifolio;
        }

        public List<string> GetCategories(DateTime CurrencyData) => (from trade in listPortifolio
                                                                     select RiskCalculator.ReturnRisk(trade, CurrencyData)).ToList();
    }
}
