using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class ProductInstanceWrapper : BDDMObject
    {
        public BDDMArray<KitProductInstance> KitProductInstance { get; set; }
        public BDDMArray<EquipmentProductInstance> EquipmentProductInstance { get; set; }
    }
}
