using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;
using PMI.BDDM.Staticdata;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Transactionaldata.Metrics.CoreCrm
{
    public class TriggerMetric : BDDMObject
    {
        [BDDMPropertyInfo("Basis", IsRequired = false, IsSecured = false)]
        public BusinessEntityReference Basis { get; set; }
        [BDDMPropertyInfo("Sale Point", IsRequired = false, IsSecured = false)]
        public SalesPointReference SalePoint { get; set; }
        [BDDMPropertyInfo("Channel", IsRequired = false, IsSecured = false)]
        public PrimitiveEnum<ProductLocationSalesChannel> Channel { get; set; }
        [BDDMPropertyInfo("Close Date", IsRequired = false, IsSecured = false)]
        public PrimitiveDateTime CloseDate { get; set; }
        [BDDMPropertyInfo("Updated By", IsRequired = false, IsSecured = false)]
        public GenericUserReference UpdatedBy { get; set; }
    }
}
