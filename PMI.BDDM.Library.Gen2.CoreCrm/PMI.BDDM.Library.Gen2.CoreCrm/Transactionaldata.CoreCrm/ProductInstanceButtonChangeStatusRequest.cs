using PMI.BDDM.Common;
using PMI.BDDM.Staticdata;

namespace PMI.BDDM.Transactionaldata.CoreCrm
{
    public class ProductInstanceButtonChangeStatusRequest : BDDMObject
    {
        public ADUserReference User { get; set; }

        public EquipmentProductInstance EquipmentProductInstance { get; set; }
    }
}
