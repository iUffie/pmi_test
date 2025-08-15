using PMI.BDDM.Staticdata;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Transactionaldata.CoreCrm
{
    public abstract class ComplaintInfo : PMI.BDDM.Transactionaldata.ComplaintInfo
    {
        public ComplaintCallNeeded CallNeeded { get; set; }
        [BDDMPropertyInfo("Product", IsRequired = false, IsSecured = false)]
        public BrandVariant Product { get; set; }
        [BDDMPropertyInfo("ProductStick", IsRequired = false, IsSecured = false)]
        public BrandVariant ProductStick { get; set; }
    }
}
