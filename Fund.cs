using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientProducts.Domain._Ddd;

namespace ClientProducts.Domain.ContractDetailAggregate
{
    public class Fund : Entity<string>
    {
        private string _fundId;
        private string _fundName;
        private decimal _titles;
        private decimal _price;
        private decimal _valuation;
        private decimal _percentage;
        private bool _pendingOperation;

        public Fund(string fundId, decimal titles, double price, double valuation, decimal percentage, bool pending)
        {
            if(string.IsNullOrEmpty(fundId)) { throw new ArgumentException("fundId no puede ser nulo o vacío.");  }

            Id = fundId;
            _fundName = fundId;
            _titles = titles;
            _price = Convert.ToDecimal(price);
            _valuation = Convert.ToDecimal(valuation);
            _percentage = percentage;
            _pendingOperation = pending;
        }


        public string FundName => _fundName;
        public decimal Titles => _titles;
        public decimal Price => _price;
        public decimal Valuation => _valuation;
        public decimal Percentage => _percentage;
        public bool PendingOperation => _pendingOperation;
    }
}
