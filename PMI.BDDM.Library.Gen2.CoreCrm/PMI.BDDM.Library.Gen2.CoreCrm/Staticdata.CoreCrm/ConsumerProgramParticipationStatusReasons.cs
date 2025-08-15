using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class ConsumerProgramParticipationStatusReasons : BDDMObject
    {
        [BDDMPropertyInfo("Creation Time", IsRequired = false, IsSecured = false)]
        public PrimitiveDateTime CreationTime { get; set; }
        [BDDMPropertyInfo("Update Time", IsRequired = false, IsSecured = false)]
        public PrimitiveDateTime UpdateTime { get; set; }
        [BDDMPropertyInfo("Code", IsRequired = false, IsSecured = false)]
        public PrimitiveEnum<ConsumerProgramParticipationStatusReason> Code { get; set; }
    }
}
