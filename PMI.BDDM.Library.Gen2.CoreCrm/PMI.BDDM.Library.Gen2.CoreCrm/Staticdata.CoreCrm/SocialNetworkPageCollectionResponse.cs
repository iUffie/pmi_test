using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class SocialNetworkPageCollectionResponse : BDDMObject
    {
        public PrimitiveInteger Count { get; set; }
        public BDDMArray<SocialNetworkPage> Docs { get; set; }
    }
}
