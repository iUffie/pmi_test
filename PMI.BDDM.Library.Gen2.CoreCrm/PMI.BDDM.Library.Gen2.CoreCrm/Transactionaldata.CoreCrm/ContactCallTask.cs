using PMI.BDDM.Common;

namespace PMI.BDDM.Transactionaldata.CoreCrm
{
    public class ContactCallTask : RetailCallTaskType
    {
        public Staticdata.CoreCrm.Contact ContactInfo { get; set; }
        public BusinessEntityReference Trigger { get; set; }
    }
}
