using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class EquipmentProductionProduct : PMI.BDDM.Staticdata.EquipmentProductionProduct
    {
        [BDDMPropertyInfo("Source", IsRequired = false, IsSecured = false)]
        public PrimitiveString Source { get; set; }
        [BDDMPropertyInfo("Created By", IsRequired = false, IsSecured = false)]
        public GenericUserReference CreatedBy { get; set; }
        [BDDMPropertyInfo("Updated By", IsRequired = false, IsSecured = false)]
        public GenericUserReference UpdatedBy { get; set; }
        [BDDMPropertyInfo("UOM", IsRequired = false, IsSecured = false)]
        public PrimitiveEnum<QuantityUOM> UOM { get; set; }
        [BDDMPropertyInfo("EANCarton", IsRequired = false, IsSecured = false)]
        public PrimitiveString EANCarton { get; set; }
    }
}
