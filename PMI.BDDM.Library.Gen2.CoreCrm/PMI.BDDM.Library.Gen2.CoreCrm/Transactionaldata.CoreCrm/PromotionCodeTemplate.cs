using PMI.BDDM.Common.DataType;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Transactionaldata.CoreCrm
{
    public class PromotionCodeTemplate : PMI.BDDM.Transactionaldata.PromotionCodeTemplate
    {
        [BDDMPropertyInfo("Create By Button Available", IsRequired = false, IsSecured = false)]
        public PrimitiveBoolean CreateByButtonAvailable { get; set; }
    }
}
