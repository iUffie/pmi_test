using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;
using PMI.BDDM.Staticdata;

namespace PMI.BDDM.Transactionaldata.CoreCrm
{
    public class ConversationTopic : Transactionaldata.ConversationTopic
    {
        public PrimitiveString Code { get; set; }
        public PrimitiveEnum<CodeSpace> CodeSpace { get; set; }
        public ConversationReference Conversation { get; set; }
        public GenericUserReference UpdatedBy { get; set; }
        public PrimitiveDateTime UpdateTime { get; set; }
    }
}
