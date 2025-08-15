using PMI.BDDM.Common.DataType;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class ConsumerBrandAllocation : Staticdata.ConsumerBrandAllocation
    {
        [BDDMPropertyInfo("Code", IsRequired = false, IsSecured = false)]
        public PrimitiveString Code { get; set; }
    }
}
