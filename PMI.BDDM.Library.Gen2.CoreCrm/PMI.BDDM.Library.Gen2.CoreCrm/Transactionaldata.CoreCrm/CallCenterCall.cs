using PMI.BDDM.Common.CoreCrm;
using PMI.BDDM.Common.DataType;
using PMI.BDDM.Staticdata;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Transactionaldata.CoreCrm
{
    public class CallCenterCall : Transactionaldata.CallCenterCall
    {
        public GenericUserReference CreatedBy { get; set; }
        public GenericUserReference UpdatedBy { get; set; }
        [BDDMPropertyInfo("Direction", IsRequired = false, IsSecured = false)]
        public PrimitiveEnum<CallDirection> Direction { get; set; }
        [BDDMPropertyInfo("Talk Time", IsRequired = false, IsSecured = false)]
        public PrimitiveString TalkTime { get; set; }
        [BDDMPropertyInfo("ATS Code", IsRequired = false, IsSecured = false)]
        public PrimitiveString ATSCode { get; set; }
        [BDDMPropertyInfo("Business Domain", IsRequired = false, IsSecured = false)]
        public PrimitiveEnum<DistributorRemunerationDomain> BusinessDomain { get; set; }
        [BDDMPropertyInfo("Call Center Type", IsRequired = false, IsSecured = false)]
        public PrimitiveEnum<Telephony> CallCenterType { get; set; }
        [BDDMPropertyInfo("Call Center User ID", IsRequired = false, IsSecured = false)]
        public PrimitiveString CallCenterUserID { get; set; }
        [BDDMPropertyInfo("Call Telephony Status", IsRequired = false, IsSecured = false)]
        public PrimitiveString CallTelephonyStatus { get; set; }
        [BDDMPropertyInfo("Caption", IsRequired = false, IsSecured = false)]
        public PrimitiveString Caption { get; set; }
        [BDDMPropertyInfo("Result", IsRequired = false, IsSecured = false)]
        public PrimitiveString Result { get; set; }
        [BDDMPropertyInfo("Click To Call", IsRequired = false, IsSecured = false)]
        public PrimitiveBoolean ClickToCall { get; set; }
    }
}
