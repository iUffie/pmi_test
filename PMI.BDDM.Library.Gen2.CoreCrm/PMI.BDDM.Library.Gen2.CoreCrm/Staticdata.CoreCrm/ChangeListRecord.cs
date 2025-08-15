using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class ChangeListRecord : BDDMObject
    {
        public PrimitiveString Code { get; set; }
        public PrimitiveString Record { get; set; }
    }
}
