using CreditSuisse.CategoryRisk.Domain.Extensions.Base;

namespace CreditSuisse.CategoryRisk.Domain.Extensions.Risks
{
    /// <summary>
    /// Single Responsiblity Principle
    /// </summary>
    public  class RiskTypeHIGHRISK 
    {
        public string HIGHRISK { get; } 

        public RiskTypeHIGHRISK()
        {
            HIGHRISK = "HIGHRISK";
        }
    }
}
