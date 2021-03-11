using System;
using System.Collections.Generic;
using ClientProducts.Domain._Ddd;

namespace ClientProducts.Domain.ContractDetailAggregate
{
    public class TransactionTypes : ValueObject<TransactionTypes>
    {
        private int _tipoMercado;
        private int _tipoOperacion;
        private int _tipoOrden;

        public TransactionTypes(int tipoMercado, int tipoOperacion, int tipoOrden)
        {
            _tipoMercado = tipoMercado;
            _tipoOperacion = tipoOperacion;
            _tipoOrden = tipoOrden;
        }

        public int TipoMercado => _tipoMercado;
        public int TipoOperacion => _tipoOperacion;
        public int TipoOrden => _tipoOrden;

        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            throw new NotImplementedException();
        }
    }
}
