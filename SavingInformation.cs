using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientProducts.Domain._Ddd;

namespace ClientProducts.Domain.ContractDetailAggregate
{
    public class SavingInformation : ValueObject<SavingInformation>
    {
        private string _savingReason;
        private decimal _savingGoal;
        private int _savingTerm;
        private decimal _commitedAmount;
        private string _contributionPeriodicity = "N/A";
        private decimal _currentLifeInsuranceAmount;
        private string _terminationDate;
        private string _paymentType = "N/A";

        public SavingInformation(ContractSOCData socInfo)
        {
            _savingReason = socInfo.SavingReason;
            _savingGoal = socInfo.SavingGoal;
            _savingTerm = socInfo.SavingTerm;
            _commitedAmount = socInfo.CommitedAmount;
            _currentLifeInsuranceAmount = socInfo.CurrentLifeInsuranceAmount;
            _terminationDate = socInfo.TerminationDate;
        }

        public string SavingReason => _savingReason;
        public decimal SavingGoal => _savingGoal;
        public int SavingTerm => _savingTerm;
        public decimal CommitedAmount => _commitedAmount;
        public decimal CurrentLifeInsuranceAmount => _currentLifeInsuranceAmount;
        public string ContributionPeriodicity => _contributionPeriodicity;
        public string TerminationDate => _terminationDate;
        public string PaymentType => _paymentType;


        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            return new List<object>
            {
                SavingReason,
                SavingGoal,
                SavingTerm,
                CommitedAmount,
                CurrentLifeInsuranceAmount,
                ContributionPeriodicity,
                TerminationDate,
                PaymentType
            };
        }
    }
}
