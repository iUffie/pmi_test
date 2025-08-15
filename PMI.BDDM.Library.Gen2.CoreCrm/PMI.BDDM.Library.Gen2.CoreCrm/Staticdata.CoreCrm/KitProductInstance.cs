using PMI.BDDM.Common.DataType;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class KitProductInstance : PMI.BDDM.Staticdata.KitProductInstance
    {
        [BDDMPropertyInfo("Previous Status", IsRequired = false, IsSecured = false)]
        public PrimitiveEnum<ProductInstanceStatus> PreviousStatus { get; set; }
        [BDDMPropertyInfo("External Creation Time", IsRequired = false, IsSecured = false)]
        public PrimitiveDateTime ExternalCreationTime { get; set; }
        [BDDMPropertyInfo("External Update Time", IsRequired = false, IsSecured = false)]
        public PrimitiveDateTime ExternalUpdateTime { get; set; }
        [BDDMPropertyInfo("Created By", IsRequired = false, IsSecured = false)]
        public GenericUserReference CreatedBy { get; set; }
        [BDDMPropertyInfo("Updated By", IsRequired = false, IsSecured = false)]
        public GenericUserReference UpdatedBy { get; set; }
        [BDDMPropertyInfo("Kit", IsRequired = false, IsSecured = false)]
        public ProductInstanceReference Kit { get; set; }
    }
}
