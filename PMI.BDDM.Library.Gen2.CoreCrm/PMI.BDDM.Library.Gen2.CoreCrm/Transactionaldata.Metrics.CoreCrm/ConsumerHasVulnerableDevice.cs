using PMI.BDDM.Common.DataType;
using PMI.BDDM.Staticdata;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Transactionaldata.Metrics.CoreCrm
{
    public class ConsumerHasVulnerableDevice : PMI.BDDM.Transactionaldata.Metrics.ConsumerHasVulnerableDevice
    {
        [BDDMPropertyInfo("Name", IsRequired = false, IsSecured = false)]
        public PrimitiveString Name { get; set; }
        [BDDMPropertyInfo("Last Recalculation Date", IsRequired = false, IsSecured = false)]
        public PrimitiveDateTime LastRecalculationDate { get; set; }
        [BDDMPropertyInfo("Target Time", IsRequired = false, IsSecured = false)]
        public PrimitiveDateTime TargetTime { get; set; }
        [BDDMPropertyInfo("Created By", IsRequired = false, IsSecured = false)]
        public GenericUserReference CreatedBy { get; set; }
        [BDDMPropertyInfo("Updated By", IsRequired = false, IsSecured = false)]
        public GenericUserReference UpdatedBy { get; set; }
        [BDDMPropertyInfo("Trigger Metric", IsRequired = false, IsSecured = false)]
        public TriggerMetric TriggerMetric { get; set; }
    }
}
