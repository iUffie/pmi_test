using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class BrandVariantWrapper : BDDMObject
    {
        public BDDMArray<ConsumableBrandVariant> ConsumableBrandVariant { get; set; }
        public BDDMArray<EquipmentBrandVariant> EquipmentBrandVariant { get; set; }
    }
}
