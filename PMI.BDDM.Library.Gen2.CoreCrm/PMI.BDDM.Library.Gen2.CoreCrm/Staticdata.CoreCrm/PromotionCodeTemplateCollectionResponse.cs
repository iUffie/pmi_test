using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class PromotionCodeTemplateCollectionResponse : BDDMObject
    {
        public PrimitiveInteger Count { get; set; }
        public BDDMArray<PMI.BDDM.Transactionaldata.CoreCrm.PromotionCodeTemplate> Docs { get; set; }
    }
}
