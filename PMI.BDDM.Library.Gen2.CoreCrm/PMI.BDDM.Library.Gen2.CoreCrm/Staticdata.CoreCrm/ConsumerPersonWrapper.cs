using PMI.BDDM.Common;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class ConsumerPersonWrapper : BDDMObject
    {
        public Consumer Consumer { get; set; }
        public Staticdata.Person Person { get; set; }
    }
}
