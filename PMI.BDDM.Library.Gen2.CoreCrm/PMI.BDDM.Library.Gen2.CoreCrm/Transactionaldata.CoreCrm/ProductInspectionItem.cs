using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;
using PMI.BDDM.Staticdata;

namespace PMI.BDDM.Transactionaldata.CoreCrm
{
    public abstract class ProductInspectionItem : PMI.BDDM.Transactionaldata.ProductInspectionItem
    {
        public PrimitiveString Code { get; set; }
        public PrimitiveEnum<CodeSpace> CodeSpace { get; set; }
        public ProductInspectionReference ProductInspection { get; set; }
        public PrimitiveBoolean WorksProperly { get; set; }
        public PrimitiveDateTime CreationTime { get; set; }
        public PrimitiveDateTime UpdateTime { get; set; }
        public GenericUserReference CreatedBy { get; set; }
        public GenericUserReference UpdatedBy { get; set; }
    }
}
