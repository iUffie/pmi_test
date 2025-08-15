using PMI.BDDM.Common.DataType;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class ConsumerProgramRewardAccrual : PMI.BDDM.Staticdata.ConsumerProgramRewardAccrual
    {
        [BDDMPropertyInfo("Code", IsRequired = false, IsSecured = false)]
        public PrimitiveString Code { get; set; }
        [BDDMPropertyInfo("Update Date", IsRequired = false, IsSecured = false)]
        public PrimitiveDateTime UpdateDate { get; set; }
    }
}
