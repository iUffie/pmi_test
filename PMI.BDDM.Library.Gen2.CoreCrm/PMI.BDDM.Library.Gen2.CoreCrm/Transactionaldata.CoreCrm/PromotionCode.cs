using PMI.BDDM.Common.DataType;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Transactionaldata.CoreCrm
{
    public class PromotionCode : Transactionaldata.PromotionCode
    {
        [BDDMPropertyInfo("StatusReasonComment", IsRequired = false, IsSecured = false)]
        public PrimitiveString StatusReasonComment { get; set; }
    }
}
