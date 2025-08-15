using PMI.BDDM.Common.DataType;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class ConsumerProgram : PMI.BDDM.Staticdata.ConsumerProgram
    {
        [BDDMPropertyInfo("Created By", IsRequired = false, IsSecured = false)]
        public GenericUserReference CreatedBy { get; set; }
        [BDDMPropertyInfo("Updated By", IsRequired = false, IsSecured = false)]
        public GenericUserReference UpdatedBy { get; set; }
        [BDDMPropertyInfo("Program Version Parameters", IsRequired = false, IsSecured = false)]
        public BDDMArray<ProgramVersionParameter> ProgramVersionParameters { get; set; }
        [BDDMPropertyInfo("Available Reward", IsRequired = false, IsSecured = false)]
        public BDDMArray<AvailableReward> AvailableRewards { get; set; }
    }
}
