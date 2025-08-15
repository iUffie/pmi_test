using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;
using PMI.BDDM.Staticdata;

namespace PMI.BDDM.Transactionaldata.CoreCrm
{
    public class ProductInstanceButtonChangeStatusError : BDDMObject
    {
        public PrimitiveString Uid { get; set; }

        public int Code { get; set; }

        public PrimitiveString Message { get; set; }

        public DocumentReference ProductInstanceChangeRequest { get; set; }

        public PrimitiveString MessageDM { get; set; }
    }
}
