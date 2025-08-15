using PMI.BDDM.Common.DataType;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class ConsumerProgramParticipation : PMI.BDDM.Staticdata.ConsumerProgramParticipation
    {
        [BDDMPropertyInfo("Last Recalculation Date", IsRequired = false, IsSecured = false)]
        public PrimitiveDateTime LastRecalculationDate { get; set; }
        [BDDMPropertyInfo("Created By", IsRequired = false, IsSecured = false)]
        public GenericUserReference CreatedBy { get; set; }
        [BDDMPropertyInfo("Updated By", IsRequired = false, IsSecured = false)]
        public GenericUserReference UpdatedBy { get; set; }
        [BDDMPropertyInfo("Participation Status Reasons", IsRequired = false, IsSecured = false)]
        public BDDMArray<ConsumerProgramParticipationStatusReasons> ParticipationStatusReasons { get; set; }
    }
}
