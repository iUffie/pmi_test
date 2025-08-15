using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class CallCenterMessage : BDDMObject
    {
        public PrimitiveString Request { get; set; }
        public PrimitiveString Response { get; set; }
        public PrimitiveDateTime CreationTime { get; set; }
        public GenericUserReference CreatedBy { get; set; }
    }
}
