using CreditSuisse.CategoryRisk.Domain.Extensions.Base;

namespace CreditSuisse.CategoryRisk.Domain.Extensions.Risks
{
    /// <summary>
    /// Single Responsiblity Principle
    /// </summary>
    public class RiskTypeEXPIRED 
    {
        public string EXPIRED { get; }

        public RiskTypeEXPIRED()
        {
            EXPIRED = "EXPIRED";
        }        
    }
}
