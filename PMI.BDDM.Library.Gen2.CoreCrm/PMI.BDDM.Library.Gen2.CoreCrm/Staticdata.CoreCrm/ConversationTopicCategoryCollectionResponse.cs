using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;
using PMI.BDDM.Transactionaldata;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class ConversationTopicCategoryCollectionResponse : BDDMObject
    {
        public PrimitiveInteger Count { get; set; }
        public BDDMArray<ConversationTopicCategory> Docs { get; set; }
    }
}
