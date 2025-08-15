using PMI.BDDM.Common.DataType;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Transactionaldata.CoreCrm
{
    public class ConsumableInspectionItem : ProductInspectionItem
    {
        [BDDMPropertyInfo("Data Matrix Code", Id = "EAID_DA94854E_305D_4fa0_A563_F9B003839CBE", IsRequired = true, IsSecured = false)]
        public PrimitiveString DataMatrixCode { get; set; }

        [BDDMPropertyInfo("Serial Number", Id = "EAID_00D94396_4737_4e91_92D4_FB614BBC76F6", IsRequired = true, IsSecured = false)]
        public PrimitiveString SerialNumber { get; set; }
    }
}
