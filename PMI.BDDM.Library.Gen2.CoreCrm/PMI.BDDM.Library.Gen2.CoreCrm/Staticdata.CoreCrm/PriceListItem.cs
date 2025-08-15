using PMI.BDDM.Common;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class PriceListItem : PMI.BDDM.Staticdata.PriceListItem
    {
        [BDDMPropertyInfo("Product Catalog Item", IsRequired = false, IsSecured = false)]
        public BusinessEntityReference ProductCatalogItem { get; set; }
        public GenericUserReference CreatedBy { get; set; }
        public GenericUserReference UpdatedBy { get; set; }
    }
}
