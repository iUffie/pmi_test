using PMI.BDDM.Common.DataType;
using PMI.BDDM.Staticdata;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Transactionaldata.CoreCrm
{
    public class ConsumerSurvey : PMI.BDDM.Transactionaldata.ConsumerSurvey
    {
        [BDDMPropertyInfo("Consumer Request", IsRequired = false, IsSecured = false)]
        public ConsumerRequestReference ConsumerRequest { get; set; }
        [BDDMPropertyInfo("Product Inspection", IsRequired = false, IsSecured = false)]
        public ProductInspectionReference ProductInspection { get; set; }
        [BDDMPropertyInfo("Conversation", IsRequired = false, IsSecured = false)]
        public ConversationReference Conversation { get; set; }
        [BDDMPropertyInfo("Json Answers", IsRequired = false, IsSecured = false)]
        public PrimitiveString JsonAnswers { get; set; }
        [BDDMPropertyInfo("Updated By", IsRequired = false, IsSecured = false)]
        public GenericUserReference UpdatedBy { get; set; }
        [BDDMPropertyInfo("Created By", IsRequired = false, IsSecured = false)]
        public GenericUserReference CreatedBy { get; set; }
    }
}
