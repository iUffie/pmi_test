using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class EquipmentProductionProductCollectionResponse : BDDMObject
    {
        public PrimitiveInteger Count { get; set; }
        public BDDMArray<EquipmentProductionProduct> Docs { get; set; }
    }
}
