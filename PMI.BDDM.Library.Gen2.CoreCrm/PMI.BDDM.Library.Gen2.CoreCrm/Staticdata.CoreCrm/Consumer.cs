using PMI.BDDM.Common.DataType;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class Consumer : Staticdata.Consumer
    {
        [BDDMPropertyInfo("BitrixLink", Id = "EAID_397A6948_EDE5_482f_99D5_D3D0177E3B21", IsRequired = false, IsSecured = false)]
        public PrimitiveString BitrixLink { get; set; }
        [BDDMPropertyInfo("DeleteDate", Id = "EAID_397A6948_EDE5_482f_99D5_D3D0177E3B22", IsRequired = false, IsSecured = false)]
        public PrimitiveDateTime DeleteDate { get; set; }
        [BDDMPropertyInfo("DeleteReason", Id = "EAID_397A6948_EDE5_482f_99D5_D3D0177E3B23", IsRequired = false, IsSecured = false)]
        public PrimitiveString DeleteReason { get; set; }
        [BDDMPropertyInfo("DeleteType", Id = "EAID_397A6948_EDE5_482f_99D5_D3D0177E3B24", IsRequired = false, IsSecured = false)]
        public ConsumerDeleteType DeleteType { get; set; }
        public new BDDMArray<ConsumerProductAllocationInfo> ProductAllocation { get; set; }
    }
}
