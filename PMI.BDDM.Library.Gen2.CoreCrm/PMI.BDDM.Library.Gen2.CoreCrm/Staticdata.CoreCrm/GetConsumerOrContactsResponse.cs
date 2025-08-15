using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class GetConsumerOrContactsResponse : BDDMObject
    {
        public BDDMArray<ContactReference> Contacts { get; set; }
        public ConsumerReference Consumer { get; set; }
    }
}
