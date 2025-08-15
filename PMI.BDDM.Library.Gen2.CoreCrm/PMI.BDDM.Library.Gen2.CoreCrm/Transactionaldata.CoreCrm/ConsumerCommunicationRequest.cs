using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;
using PMI.BDDM.Staticdata;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Transactionaldata.CoreCrm
{
    public class ConsumerCommunicationRequest : Transactionaldata.ConsumerCommunicationRequest
    {
        [BDDMPropertyInfo("RelatedTo", IsRequired = false, IsSecured = false)]
        public BusinessEntityReference RelatedTo { get; set; }
        [BDDMPropertyInfo("CreatedBy", IsRequired = false, IsSecured = false)]
        public GenericUserReference CreatedBy { get; set; }
        [BDDMPropertyInfo("UpdatedBy", IsRequired = false, IsSecured = false)]
        public GenericUserReference UpdatedBy { get; set; }
        [BDDMPropertyInfo("PublishingFailed", IsRequired = false, IsSecured = false)]
        public PrimitiveBoolean PublishingFailed { get; set; }
    }
}
