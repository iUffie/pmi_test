using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;

namespace PMI.BDDM.Transactionaldata.CoreCrm
{
    public class TalkCollectionResponse : BDDMObject
    {
        public PrimitiveInteger Count { get; set; }
        public BDDMArray<PMI.BDDM.Transactionaldata.CoreCrm.Conversation> Docs { get; set; }
    }
}
