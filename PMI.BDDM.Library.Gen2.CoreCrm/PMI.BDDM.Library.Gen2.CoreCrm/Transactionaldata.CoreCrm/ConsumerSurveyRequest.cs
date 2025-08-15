using PMI.BDDM.Common.DataType;
using PMI.BDDM.Staticdata;
using PMI.BDDM.Staticdata.CoreCrm;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Transactionaldata.CoreCrm
{
    public class ConsumerSurveyRequest : PMI.BDDM.Transactionaldata.ConsumerSurveyRequest
    {
        [BDDMPropertyInfo("Created By", IsRequired = false, IsSecured = false)]
        public GenericUserReference CreatedBy { get; set; }
        [BDDMPropertyInfo("Update By", IsRequired = false, IsSecured = false)]
        public GenericUserReference UpdatedBy { get; set; }
        [BDDMPropertyInfo("Request", IsRequired = false, IsSecured = false)]
        public ConsumerRequestReference Request { get; set; }
        [BDDMPropertyInfo("Call", IsRequired = false, IsSecured = false)]
        public CallCenterCallReference Call { get; set; }
        [BDDMPropertyInfo("Chat", IsRequired = false, IsSecured = false)]
        public CallCenterChatReference Chat { get; set; }
        [BDDMPropertyInfo("Post Process Code", IsRequired = false, IsSecured = false)]
        public SurveyRequestPostProcess PostProcessCode { get; set; }
        [BDDMPropertyInfo("Status Update Date", IsRequired = false, IsSecured = false)]
        public PrimitiveDateTime StatusUpdateDate { get; set; }
        [BDDMPropertyInfo("Geo Unit", IsRequired = false, IsSecured = false)]
        public GeoUnitReference GeoUnit { get; set; }
        [BDDMPropertyInfo("Area", IsRequired = false, IsSecured = false)]
        public GeoUnitReference Area { get; set; }
        [BDDMPropertyInfo("Dispatch Randomizer", IsRequired = false, IsSecured = false)]
        public PrimitiveInteger DispatchRandomizer { get; set; }
        [BDDMPropertyInfo("Planned Send Date", IsRequired = false, IsSecured = false)]
        public PrimitiveDateTime PlannedSendDate { get; set; }
    }
}
