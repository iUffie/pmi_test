using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;
using PMI.BDDM.Staticdata;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Transactionaldata.CoreCrm
{
    public class TextAnswer : PMI.BDDM.Transactionaldata.TextAnswer
    {
        [BDDMPropertyInfo("Consumer Survey", IsRequired = false, IsSecured = false)]
        public ConsumerSurveyReference ConsumerSurvey { get; set; }
        [BDDMPropertyInfo("Created By", IsRequired = false, IsSecured = false)]
        public GenericUserReference CreatedBy { get; set; }
        [BDDMPropertyInfo("Updated By", IsRequired = false, IsSecured = false)]
        public GenericUserReference UpdatedBy { get; set; }
        [BDDMPropertyInfo("Code", IsRequired = false, IsSecured = false)]
        public PrimitiveString Code { get; set; }
        [BDDMPropertyInfo("Code Space", IsRequired = false, IsSecured = false)]
        public PrimitiveEnum<CodeSpace> CodeSpace { get; set; }
    }
}
