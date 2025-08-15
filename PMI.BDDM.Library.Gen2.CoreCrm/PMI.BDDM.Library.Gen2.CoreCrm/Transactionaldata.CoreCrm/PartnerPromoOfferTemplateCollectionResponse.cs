using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;

namespace PMI.BDDM.Transactionaldata.CoreCrm
{
    public class PartnerPromoOfferTemplateCollectionResponse : BDDMObject
    {
        public PrimitiveInteger Count { get; set; }
        public BDDMArray<PartnerPromoOfferTemplate> Docs { get; set; }
    }
}
