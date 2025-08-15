using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class Contact : Staticdata.Contact
    {
        public PrimitiveString Code { get; set; }
        public PrimitiveEnum<CodeSpace> CodeSpace { get; set; }
        public PrimitiveString IDSoMe { get; set; }
        public PrimitiveInteger Age { get; set; }
        public GenericUserReference CreatedBy { get; set; }
        public GenericUserReference UpdatedBy { get; set; }
        public PrimitiveDateTime CreationTime { get; set; }
        public PrimitiveDateTime UpdateTime { get; set; }
    }
}
