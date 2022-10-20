using CreditSuisse.CategoryRisk.Domain.Extensions.Base;

namespace CreditSuisse.CategoryRisk.Domain.Extensions.Risks
{
    /// <summary>
    /// Single Responsiblity Principle
    /// </summary>
    public class RiskTypeMEDIUMRISK 
    {
        public string MEDIUMRISK { get; }

        public RiskTypeMEDIUMRISK()
        {
            MEDIUMRISK = "MEDIUMRISK";
        }      
    }
}
