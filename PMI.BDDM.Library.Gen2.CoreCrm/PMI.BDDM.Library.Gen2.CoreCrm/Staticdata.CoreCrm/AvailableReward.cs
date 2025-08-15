using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;
using PMI.BDDM.Tools;
using PMI.BDDM.Transactionaldata;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class AvailableReward : BDDMObject
    {
        [BDDMPropertyInfo("Reward", IsRequired = false, IsSecured = false)]
        public RetailPromoOfferTemplateReference Reward { get; set; }
        [BDDMPropertyInfo("Message To Consumer", IsRequired = false, IsSecured = false)]
        public PrimitiveString MessageToConsumer { get; set; }
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
