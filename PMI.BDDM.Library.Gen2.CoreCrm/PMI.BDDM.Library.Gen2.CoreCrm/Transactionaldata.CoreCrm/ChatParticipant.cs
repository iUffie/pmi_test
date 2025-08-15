using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;

namespace PMI.BDDM.Transactionaldata.CoreCrm
{
    public class ChatParticipant : BDDMObject
    {
        public PrimitiveDecimal AverageResponseTime { get; set; }
        public PrimitiveDecimal AverageFirstResponseTime { get; set; }
        public PrimitiveDecimal MaximumResponseTime { get; set; }
        public IndividualType Participant { get; set; }
    }
}
