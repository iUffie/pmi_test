using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;
using PMI.BDDM.Staticdata;

namespace PMI.BDDM.Transactionaldata.CoreCrm
{
    public class PmSaveProductInspectionResultResponse : BDDMObject
    {
        public Activity ProductInspection { get; set; }

        public ConsumerProductInspectionRequestReference ConsumerRequest { get; set; }

        public PrimitiveBoolean OutOfStockAvailability { get; set; }

        public PrimitiveInteger ExpectedProductInstancesNumber { get; set; }

        public BDDMArray<ProductCategory> ExpectedProductElements { get; set; }
    }
}
