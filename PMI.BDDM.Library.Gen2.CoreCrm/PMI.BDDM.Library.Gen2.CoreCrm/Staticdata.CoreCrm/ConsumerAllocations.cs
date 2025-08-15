using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    [BDDMClassInfo("Consumer Allocations", Id = "EAID_83EC0B5C_B7EE_41c9_83B5_CDD9E0600906")]
    public class ConsumerAllocations : BusinessEntity
    {
        [BDDMCollectionPropertyInfo("Brand Allocations", Id = "EAID_2DB69A20_9E09_46b7_9AE7_BA7DF7FDCC12", IsRequired = false, IsSecured = false)]
        public BDDMArray<ConsumerBrandAllocation> BrandAllocations { get; set; }

        [BDDMPropertyInfo("Consumer", Id = "EAID_B92F5301_E37C_4c67_B4D8_3E18D4E32E59", IsRequired = true, IsSecured = false)]
        public ConsumerReference Consumer { get; set; }

        [BDDMCollectionPropertyInfo("Product Allocations", Id = "EAID_85C435F3_FEF5_4e03_98AF_9998E1ABBE87", IsRequired = false, IsSecured = false)]
        public BDDMArray<ConsumerProductAllocation> ProductAllocations { get; set; }
    }
}
