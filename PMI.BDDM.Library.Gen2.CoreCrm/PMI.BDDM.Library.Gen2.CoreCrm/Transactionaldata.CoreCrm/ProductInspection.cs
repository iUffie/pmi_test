using PMI.BDDM.Common.DataType;
using PMI.BDDM.Staticdata;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Transactionaldata.CoreCrm
{
    public class ProductInspection : PMI.BDDM.Transactionaldata.ProductInspection
    {
        [BDDMPropertyInfo("Parent Product", Id = "EAID_E35F9622_B57B_4258_8654_5A680F976F01", IsRequired = false, IsSecured = false)]
        public GenericProductReference ParentProduct { get; set; }

        [BDDMPropertyInfo("Channel", Id = "EAID_E35F9622_B57B_4258_8654_5A680F976F32", IsRequired = false, IsSecured = false)]
        public PrimitiveEnum<ProductLocationSalesChannel> Channel { get; set; }
        [BDDMPropertyInfo("Updated By", IsRequired = false, IsSecured = false)]
        public GenericUserReference UpdatedBy { get; set; }
    }
}
