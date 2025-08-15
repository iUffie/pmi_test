using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class RetailCallTaskCallCenterCollectionResponse : BDDMObject
    {
        public PrimitiveInteger Count { get; set; }
        public BDDMArray<PMI.BDDM.Transactionaldata.CoreCrm.RetailCallTask> Docs { get; set; }
    }
}
