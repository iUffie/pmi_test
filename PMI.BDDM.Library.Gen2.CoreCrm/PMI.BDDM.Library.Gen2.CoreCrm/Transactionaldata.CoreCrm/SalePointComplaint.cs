using PMI.BDDM.Common.DataType;
using PMI.BDDM.Staticdata;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Transactionaldata.CoreCrm
{
    public class SalePointComplaint : PMI.BDDM.Transactionaldata.CoreCrm.ComplaintInfo
    {
        [BDDMPropertyInfo("Sale Point", Id = "EAID_7C539D64_9E8F_46f4_820E_0E51EF5654F9", IsRequired = true, IsSecured = false)]
        public SalesPointReference SalePoint { get; set; }

        [BDDMPropertyInfo("City", Id = "EAID_7C539D64_9E8F_46f4_820E_0E51EF5654F9", IsRequired = false, IsSecured = false)]
        public PrimitiveString City { get; set; }
    }
}
