using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;
using PMI.BDDM.Staticdata;

namespace PMI.BDDM.Transactionaldata.CoreCrm
{
    public class CallCenterChat : BDDMObject
    {
        public PrimitiveString Code { get; set; }
        public PrimitiveEnum<CodeSpace> CodeSpace { get; set; }
        public GenericUserReference CreatedBy { get; set; }
        public GenericUserReference UpdatedBy { get; set; }
        public InboundCommunicationChannel InboundCommunicationChannel { get; set; }
        public PrimitiveString CallCenterUserID { get; set; }
        public PrimitiveString Subject { get; set; }
        public ChatBotInfo ChatBot { get; set; }
        public Phone IncomingPhoneNumber { get; set; }
        public ActivityReference RelatedActivity { get; set; }
        public PrimitiveString WebimID { get; set; }
        public PrimitiveDecimal Duration { get; set; }
        public BDDMArray<ChatParticipant> Participants { get; set; }
        public PrimitiveEnum<ChatConversationStatus> Status { get; set; }
        public PrimitiveString Transcript { get; set; }
        public PrimitiveDecimal WaitDuration { get; set; }
        public PrimitiveDateTime EndDate { get; set; }
        public PrimitiveDateTime CreationTime { get; set; }
        public PrimitiveDateTime UpdateTime { get; set; }
        public PrimitiveBoolean TransferredToBot { get; set; }
    }
}
