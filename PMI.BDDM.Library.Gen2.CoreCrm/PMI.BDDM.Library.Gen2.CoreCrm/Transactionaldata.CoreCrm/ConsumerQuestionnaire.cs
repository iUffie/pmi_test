using PMI.BDDM.Common.DataType;
using PMI.BDDM.Staticdata;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Transactionaldata.CoreCrm
{
    public class ConsumerQuestionnaire : PMI.BDDM.Transactionaldata.ConsumerQuestionnaire
    {
        [BDDMPropertyInfo("Json", IsRequired = false, IsSecured = false)]
        public PrimitiveString Json { get; set; }
        [BDDMPropertyInfo("Created By", IsRequired = false, IsSecured = false)]
        public GenericUserReference CreatedBy { get; set; }
        [BDDMPropertyInfo("Updated By", IsRequired = false, IsSecured = false)]
        public GenericUserReference UpdatedBy { get; set; }
    }
}
