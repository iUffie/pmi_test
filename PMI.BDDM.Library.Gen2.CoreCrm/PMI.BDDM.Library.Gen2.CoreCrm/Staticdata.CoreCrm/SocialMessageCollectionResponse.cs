using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;
using PMI.BDDM.Transactionaldata.CoreCrm;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class SocialMessageCollectionResponse : BDDMObject
    {
        public PrimitiveInteger Count { get; set; }
        public BDDMArray<SocialMessage> Docs { get; set; }
    }
}
