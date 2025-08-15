using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;

namespace PMI.BDDM.Transactionaldata.CoreCrm
{
    public class PartnerPromoRewardCollectionResponse : BDDMObject
    {
        public PrimitiveInteger Count { get; set; }
        public BDDMArray<PartnerPromoOffer> Docs { get; set; }
    }
}
