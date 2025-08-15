using PMI.BDDM.Tools;

namespace PMI.BDDM.Transactionaldata.CoreCrm
{
    public class ProductInspectionPossibleSolution : PMI.BDDM.Transactionaldata.ProductInspectionPossibleSolution
    {
        [BDDMCollectionPropertyInfo("Item", Id = "EAID_95D09DFF_F8FF_4311_9F8F_7BF0BC540720", IsRequired = false, IsSecured = false)]
        public ProductInspectionItemReference Item { get; set; }
    }
}
