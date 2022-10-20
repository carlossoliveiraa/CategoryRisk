using CreditSuisse.CategoryRisk.Console.Configurations;
using CreditSuisse.CategoryRisk.Domain.Entity;
using System.Globalization;
using System;

namespace CreditSuisse.CategoryRisk.Tests
{
    public class CategoriesTest
    {
        [Fact]
        public void countList_Categories_Sum()
        {
            // Arrange
            List<ITrade> listPortifolio;
            CultureInfo enUS = new CultureInfo("en-US");
           
            Trade xx1 = new Trade
            {
                Value = 2000000,
                ClientSector = "Private",
                NextPaymentDate = DateTime.ParseExact("12/29/2025", "MM/dd/yyyy", enUS, DateTimeStyles.None)
            };
            Trade xx2 = new Trade
            {
                Value = 400000,
                ClientSector = "Public",
                NextPaymentDate = DateTime.ParseExact("07/01/2020", "MM/dd/yyyy", enUS, DateTimeStyles.None)
            };
            Trade xx3 = new Trade
            {
                Value = 5000000,
                ClientSector = "Public",
                NextPaymentDate = DateTime.ParseExact("01/02/2024", "MM/dd/yyyy", enUS, DateTimeStyles.None)
            };
            Trade xx4 = new Trade
            {
                Value = 3000000,
                ClientSector = "Public",
                NextPaymentDate = DateTime.ParseExact("10/26/2023", "MM/dd/yyyy", enUS, DateTimeStyles.None)
            };

            listPortifolio = new List<ITrade>() { xx1, xx2, xx3, xx4 };

            var categories = new Categories(listPortifolio);
             
            // Assert
            Assert.Equal(4, categories.GetCategories(DateTime.Now).Count());
        }
    }
}