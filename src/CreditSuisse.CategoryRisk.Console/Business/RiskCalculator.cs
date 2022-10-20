using CreditSuisse.CategoryRisk.Domain.Entity;
using CreditSuisse.CategoryRisk.Domain.Extensions.Risks;
using static CreditSuisse.CategoryRisk.Domain.Extensions.Base.Enumeration;


namespace CreditSuisse.CategoryRisk.Domain.Business
{
    public static class RiskCalculator
    {
        public static string ReturnRisk(ITrade trade, DateTime CurrencyData)
        {
            // HIGHRISK
            switch (trade.Value)
            {
                case > 1000000 when trade.ClientSector.Equals(TypeSector.Private.ToString()):
                    return new RiskTypeHIGHRISK().HIGHRISK.ToString();

                case > 1000000 when trade.ClientSector.Equals(TypeSector.Public.ToString()):
                    return new RiskTypeMEDIUMRISK().MEDIUMRISK.ToString();
            }

            //EXPIRED
            int days = trade.NextPaymentDate.Subtract(CurrencyData).Days;
            if (days < 30)
            {
                return new RiskTypeEXPIRED().EXPIRED.ToString();
            }   

            // PEP - for second questionn

            return "Not found risk for Trade.";
        }
    }
}
