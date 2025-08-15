using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;
using PMI.BDDM.Staticdata;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Transactionaldata.CoreCrm
{
    public class ConversationAdditionalInfo : BDDMObject
    {
        [BDDMPropertyInfo("First Queue Assignment Date", IsRequired = false, IsSecured = false)]
        public PrimitiveDateTime FirstQueueAssignmentDate { get; set; }
        [BDDMPropertyInfo("First Queue Assigned", IsRequired = false, IsSecured = false)]
        public RequestProcessingQueue FirstQueueAssigned { get; set; }
        [BDDMPropertyInfo("First Transfer Date", IsRequired = false, IsSecured = false)]
        public PrimitiveDateTime FirstTransferDate { get; set; }
        [BDDMPropertyInfo("First User Agent To Queue", IsRequired = false, IsSecured = false)]
        public GenericUserReference FirstUserAgentToQueue { get; set; }
        [BDDMPropertyInfo("First User Queue To Agent", IsRequired = false, IsSecured = false)]
        public GenericUserReference FirstUserQueueToAgent { get; set; }
        [BDDMPropertyInfo("Planned Delete Date", IsRequired = false, IsSecured = false)]
        public PrimitiveDateTime PlannedDeleteDate { get; set; }
        [BDDMPropertyInfo("Last Queue Assignment Date", IsRequired = false, IsSecured = false)]
        public RequestProcessingQueue LastQueueAssignmentDate { get; set; }
        [BDDMPropertyInfo("First Queue To Agent Assigned", IsRequired = false, IsSecured = false)]
        public RequestProcessingQueue FirstQueueToAgentAssigned { get; set; }
        [BDDMPropertyInfo("First Email Sending Date", IsRequired = false, IsSecured = false)]
        public PrimitiveDateTime FirstEmailSendingDate { get; set; }
        [BDDMPropertyInfo("First Contact Email Time", IsRequired = false, IsSecured = false)]
        public PrimitiveInteger FirstContactEmailTime { get; set; }
        [BDDMPropertyInfo("Attachment Exists", IsRequired = false, IsSecured = false)]
        public PrimitiveBoolean AttachmentExists { get; set; }
    }
}
