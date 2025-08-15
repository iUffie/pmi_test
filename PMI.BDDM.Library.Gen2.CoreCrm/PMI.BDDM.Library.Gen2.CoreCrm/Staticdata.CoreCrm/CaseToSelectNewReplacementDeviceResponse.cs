using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class CaseToSelectNewReplacementDeviceResponse : BDDMObject
    {
        public EquipmentBrandVariantReference NewProduct { get; set; }
        public BDDMArray<EquipmentBrandVariantReference> AlternativeProducts { get; set; }
    }
}
