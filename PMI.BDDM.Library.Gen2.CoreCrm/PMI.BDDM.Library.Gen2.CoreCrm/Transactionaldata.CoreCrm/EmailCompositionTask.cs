using PMI.BDDM.Common.DataType;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Transactionaldata.CoreCrm
{
    public class EmailCompositionTask : PMI.BDDM.Transactionaldata.EmailCompositionTask
    {
        [BDDMPropertyInfo("Sender", IsRequired = false, IsSecured = false)]
        public PrimitiveString Sender { get; set; }
        [BDDMPropertyInfo("Recipient", IsRequired = false, IsSecured = false)]
        public PrimitiveString Recipient { get; set; }
        [BDDMPropertyInfo("Title", IsRequired = false, IsSecured = false)]
        public PrimitiveString Title { get; set; }
        [BDDMPropertyInfo("Email Send Status", IsRequired = false, IsSecured = false)]
        public PrimitiveString EmailSendStatus { get; set; }
        [BDDMPropertyInfo("Body", IsRequired = false, IsSecured = false)]
        public PrimitiveString Body { get; set; }
    }
}
