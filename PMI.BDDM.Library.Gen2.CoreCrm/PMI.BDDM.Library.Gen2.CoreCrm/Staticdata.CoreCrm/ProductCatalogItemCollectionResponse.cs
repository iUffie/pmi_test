using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class ProductCatalogItemCollectionResponse : BDDMObject
    {
        public PrimitiveInteger Count { get; set; }
        public BDDMArray<ProductCatalogItem> Docs { get; set; }
    }
}
