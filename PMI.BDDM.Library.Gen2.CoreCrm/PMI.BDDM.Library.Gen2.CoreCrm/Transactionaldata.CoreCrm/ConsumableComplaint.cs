using PMI.BDDM.Common.DataType;
using PMI.BDDM.Staticdata;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Transactionaldata.CoreCrm
{
    public class ConsumableComplaint : PMI.BDDM.Transactionaldata.CoreCrm.ComplaintInfo
    {
        [BDDMPropertyInfo("Factory Comment", Id = "EAID_D932EED7_289B_4544_9FC0_DD15816AFDB0", IsRequired = true, IsSecured = false)]
        public PrimitiveString FactoryComment { get; set; }

        [BDDMPropertyInfo("Production Center", Id = "EAID_A7E23EB8_C013_4cf2_B225_463F3E9FE822", IsRequired = true, IsSecured = false)]
        public ProductionCenterReference ProductionCenter { get; set; }

        [BDDMPropertyInfo("Production Code", Id = "EAID_FA1B4375_FB6C_41ee_A841_0EE69BE0E1FE", IsRequired = true, IsSecured = false)]
        public PrimitiveString ProductionCode { get; set; }

        [BDDMPropertyInfo("Production Date", Id = "EAID_894B09BA_D9DE_4b8d_B557_0BDA5EE9D3ED", IsRequired = true, IsSecured = false)]
        public PrimitiveDateTime ProductionDate { get; set; }

        [BDDMPropertyInfo("Production Equipment", Id = "EAID_7D86416C_CD1E_4ff9_9ECD_EF614D743E68", IsRequired = true, IsSecured = false)]
        public PrimitiveString ProductionEquipment { get; set; }

        [BDDMPropertyInfo("Serial Number", Id = "EAID_C583042E_330F_4e53_82CB_21593410D9F7", IsRequired = true, IsSecured = false)]
        public PrimitiveString SerialNumber { get; set; }
    }
}
