using PMI.BDDM.Common.DataType;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Transactionaldata.CoreCrm
{
    public class ConsumerBindingRequestItem : PMI.BDDM.Transactionaldata.ConsumerBindingRequestItem
    {
        [BDDMPropertyInfo("Error Code", Id = "EAID_8E706EDE_0AEA_4faf_BADA_84F2E711DD78", IsRequired = false, IsSecured = false)]
        public PrimitiveInteger ErrorCode { get; set; }
    }
}
