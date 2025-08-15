using PMI.BDDM.Common.CoreCrm;
using PMI.BDDM.Common.DataType;
using PMI.BDDM.Staticdata.CoreCrm;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Transactionaldata.CoreCrm
{
    public class RetailCallTask : PMI.BDDM.Transactionaldata.RetailCallTask
    {
        [BDDMPropertyInfo("Title", IsRequired = false, IsSecured = false)]
        public PrimitiveString Title { get; set; }
        [BDDMPropertyInfo("Mobile Phone", IsRequired = false, IsSecured = false)]
        public PrimitiveString MobilePhone { get; set; }
        [BDDMPropertyInfo("Recall Date", IsRequired = false, IsSecured = false)]
        public PrimitiveDateTime RecallDate { get; set; }
        [BDDMPropertyInfo("Task Cancel Attempts Count", IsRequired = false, IsSecured = false)]
        public PrimitiveInteger TaskCancelAttemptsCount { get; set; }
        [BDDMPropertyInfo("Call Center Message", IsRequired = false, IsSecured = false)]
        public BDDMArray<CallCenterMessage> CallCenterMessage { get; set; }
    }
}
