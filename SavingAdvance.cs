using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientProducts.Domain._Ddd;

namespace ClientProducts.Domain.ContractDetailAggregate
{
    public class SavingAdvance : ValueObject<SavingAdvance>
    {
        private int _regularPremiumTerm;
        private int _mustHaveNumContributions;
        private int _currentNumContributions;
        private int _monthlyContributionRest;
        private decimal _additionalContributionAmount;
        private int _contributionNumber;
        private decimal _contributionAmount;
        private decimal _yieldAmount;

        public SavingAdvance(ContractSOCData socData, int mustHaveNumContributions, int currentNumContributions)
        {
            _mustHaveNumContributions = mustHaveNumContributions;
            _currentNumContributions = currentNumContributions;
            _monthlyContributionRest = socData.SavingTerm - currentNumContributions;
            _additionalContributionAmount = socData.AdditionalContributions;
            _contributionNumber = socData.SavingTerm;
            _contributionAmount = socData.TotalContributions;
        }

        public int MustHaveNumContributions => _mustHaveNumContributions;
        public int CurrentNumContributions => _currentNumContributions;
        public int MonthlyContributionRest => _monthlyContributionRest;
        public decimal AdditionalContributionAmount => _additionalContributionAmount;
        public int ContributionNumber => _contributionNumber;
        public decimal ContributionAmount => _contributionAmount;
        public decimal YieldAmount => _yieldAmount;

        public SavingAdvance FillYieldAmount(decimal yieldAmount)
        {
            if(this._contributionNumber>0)
            { this._yieldAmount = yieldAmount; }
            
            return this;
        }

        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            throw new NotImplementedException();
        }
    }
}
