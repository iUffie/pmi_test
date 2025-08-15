using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;
using PMI.BDDM.Transactionaldata;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class TemplatesToCreatingPromoCodeResponse : BDDMObject
    {
        public BDDMArray<PromotionCodeTemplateReference> PromotionCodeTemplates { get; set; }
    }
}
