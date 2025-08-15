using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class ProductInstanceChangeRequestCollectionResponse : BDDMObject
    {
        public PrimitiveInteger Count { get; set; }
        public BDDMArray<PMI.BDDM.Transactionaldata.CoreCrm.ProductInstanceChangeRequest> Docs { get; set; }
    }
}
