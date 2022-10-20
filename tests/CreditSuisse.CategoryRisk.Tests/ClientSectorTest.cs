using CreditSuisse.CategoryRisk.Domain.Entity;
using System.Globalization;
using CreditSuisse.CategoryRisk.Domain.Business;

namespace CreditSuisse.CategoryRisk.Tests
{

    public class ClientSectorTest
    {
        [Fact]
        public void client_sector_Result_HIGHRISK()
        {
            int risk = 1000000;

            // Arrange            
            CultureInfo enUS = new CultureInfo("en-US");
            Trade trade = new Trade
            {
                Value = 2000000,
                ClientSector = "Private",
                NextPaymentDate = DateTime.ParseExact("12/29/2025", "MM/dd/yyyy", enUS, DateTimeStyles.None)
            };

            var r = RiskCalculator.ReturnRisk(trade, DateTime.Now);

            // Assert 
            Assert.Equal("HIGHRISK", r);
        }

        [Fact]
        public void client_sector_Result_MEDIUMRISK()
        {
            int risk = 1000000;

            // Arrange            
            CultureInfo enUS = new CultureInfo("en-US");
            Trade trade = new Trade
            {
                Value = 2000000,
                ClientSector = "Public",
                NextPaymentDate = DateTime.ParseExact("12/29/2025", "MM/dd/yyyy", enUS, DateTimeStyles.None)
            };

            var r = RiskCalculator.ReturnRisk(trade, DateTime.Now);
                    
            // Assert 
            Assert.Equal("MEDIUMRISK", r);
        }

        [Fact]
        public void client_sector_Result_EXPIRED()
        {
            // Arrange            
                       
            // Assert 
            Assert.Equal(30,  30);
        }
    }
}