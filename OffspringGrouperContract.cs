using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientProducts.Domain._Ddd;

namespace ClientProducts.Domain.ContractDetailAggregate
{
    public class OffspringGrouperContract : ValueObject<OffspringGrouperContract>
    {
        private int _productId;
        private string _grouperContractIdentifier;
        private int _grouperPlanId;
        private string _contributionContractId;
        private string _additionalContractId;
        private string _warningMessage;

        public OffspringGrouperContract(int productId, string grouperContractIdentifier, int grouperPlanId, string contributionContractId, string additionalContractId, string warningMessage)
        {
            _productId = productId;
            _grouperContractIdentifier = grouperContractIdentifier;
            _grouperPlanId = grouperPlanId;
            _contributionContractId = contributionContractId;
            _additionalContractId = additionalContractId;
            _warningMessage = warningMessage;
        }

        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            throw new NotImplementedException();
        }

        public int ProductId => _productId;
        public string GrouperContractIdentifier => _grouperContractIdentifier;
        public int GrouperPlanId => _grouperPlanId;
        public string ContributionContractId => _contributionContractId;
        public string AdditionalContractId => _additionalContractId;
        public string WarningMessage => _warningMessage;
    }
}
