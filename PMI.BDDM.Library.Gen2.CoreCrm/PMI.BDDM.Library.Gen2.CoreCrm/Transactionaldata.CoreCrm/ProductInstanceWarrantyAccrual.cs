using PMI.BDDM.Common.DataType;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Transactionaldata.CoreCrm
{
    public class ProductInstanceWarrantyAccrual : PMI.BDDM.Transactionaldata.ProductInstanceWarrantyAccrual
    {
        [BDDMPropertyInfo("Activity Change Date", IsRequired = true, IsSecured = false)]
        public PrimitiveDateTime ActivityChangeDate { get; set; }
    }
}
