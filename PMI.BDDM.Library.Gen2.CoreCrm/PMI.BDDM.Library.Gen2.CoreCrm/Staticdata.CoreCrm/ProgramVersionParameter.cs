using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class ProgramVersionParameter : BDDMObject
    {
        [BDDMPropertyInfo("Product Generation", IsRequired = false, IsSecured = false)]
        public RRPProductGeneration ProductGeneration { get; set; }
        [BDDMPropertyInfo("Device Update Min", IsRequired = false, IsSecured = false)]
        public PrimitiveString DeviceUpdateMin { get; set; }
        [BDDMPropertyInfo("Logical Operator Min", IsRequired = false, IsSecured = false)]
        public PrimitiveString LogicalOperatorMin { get; set; }
        [BDDMPropertyInfo("Device Update Max", IsRequired = false, IsSecured = false)]
        public PrimitiveString DeviceUpdateMax { get; set; }
        [BDDMPropertyInfo("Logical Operator Max", IsRequired = false, IsSecured = false)]
        public PrimitiveString LogicalOperatorMax { get; set; }
        [BDDMPropertyInfo("Period Type", IsRequired = false, IsSecured = false)]
        public PrimitiveEnum<TimePeriod> PeriodType { get; set; }
        [BDDMPropertyInfo("Created By", IsRequired = false, IsSecured = false)]
        public GenericUserReference CreatedBy { get; set; }
        [BDDMPropertyInfo("Updated By", IsRequired = false, IsSecured = false)]
        public GenericUserReference UpdatedBy { get; set; }
        [BDDMPropertyInfo("Creation Time", IsRequired = false, IsSecured = false)]
        public PrimitiveDateTime CreationTime { get; set; }
        [BDDMPropertyInfo("Update Time", IsRequired = false, IsSecured = false)]
        public PrimitiveDateTime UpdateTime { get; set; }
    }
}
