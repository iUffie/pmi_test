using PMI.BDDM.Staticdata;

namespace PMI.BDDM.Transactionaldata.CoreCrm
{
    public class Conversation : PMI.BDDM.Transactionaldata.Conversation
    {
        public GenericProductReference Product { get; set; }
        public BrandFamilyReference Brand { get; set; }
        public ConversationAdditionalInfo AdditionalInfo { get; set; }
        public CallCenterChatReference Chat { get; set; }
    }
}
