using PMI.BDDM.Common.DataType;
using PMI.BDDM.Staticdata;

namespace PMI.BDDM.Transactionaldata.CoreCrm;

public class RetailLendingOrder : Transactionaldata.RetailLendingOrder
{
    public new BDDMArray<ProductInstance> ReturnedProductInstances { get; set; }
}