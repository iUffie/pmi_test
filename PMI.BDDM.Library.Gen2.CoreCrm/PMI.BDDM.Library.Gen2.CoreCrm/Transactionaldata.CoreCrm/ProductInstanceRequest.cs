using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;
using PMI.BDDM.Staticdata;

namespace PMI.BDDM.Transactionaldata.CoreCrm
{
    public class ProductInstanceRequest : BDDMObject
    {
        public PrimitiveString Code { get; set; }
        public PrimitiveEnum<CodeSpace> CodeSpace { get; set; }
        public GenericUserReference CreatedBy { get; set; }
        public GenericUserReference UpdatedBy { get; set; }
        public PrimitiveDateTime CreationTime { get; set; }
        public PrimitiveDateTime UpdateTime { get; set; }
        public ProductInstanceReference ProductInstance { get; set; }
        public PrimitiveEnum<ProductInstanceBindingSource> Source { get; set; }
        public ConsumerRequestReference ConsumerRequest { get; set; }
        public PrimitiveDateTime SaleDate { get; set; }
        public GenericUserReference User { get; set; }
        public PrimitiveBoolean CheckedInDM { get; set; }
        public PrimitiveString MessageDM { get; set; }
        public PrimitiveEnum<ProductInstanceStatus> TargetStatus { get; set; }
        public PrimitiveString Result { get; set; }
        public PrimitiveBoolean StolenOrLost { get; set; }
        public SalesPointReference SalePoint { get; set; }
    }
}
