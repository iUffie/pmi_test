using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;
using PMI.BDDM.Staticdata;

namespace PMI.BDDM.Transactionaldata.CoreCrm
{
    public class ProductInstanceBindingRequest : BDDMObject
    {
        public PrimitiveString Code { get; set; }
        public PrimitiveEnum<CodeSpace> CodeSpace { get; set; }
        public BusinessEntityReference ProductInstanceBinding { get; set; }
        public PrimitiveDateTime RequiredSaleDate { get; set; }
        public BusinessEntityReference ConsumerRequest { get; set; }
        public PrimitiveEnum<ConsumerProductInstanceBindingStatus> RequiredStatus { get; set; }
        public GenericUserReference CreatedBy { get; set; }
        public GenericUserReference UpdatedBy { get; set; }
        public PrimitiveDateTime CreationTime { get; set; }
        public PrimitiveDateTime UpdateTime { get; set; }
    }
}
