using PMI.BDDM.Common.DataType;
using PMI.BDDM.Staticdata;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Transactionaldata.CoreCrm
{
    public class ProductInstanceInspectionItem : ProductInspectionItem
    {
        [BDDMPropertyInfo("Product Generation", Id = "EAID_6D261231_BF41_4d44_9A92_87FAF4096C46", IsRequired = true, IsSecured = false)]
        public RRPProductGeneration ProductGeneration { get; set; }

        [BDDMPropertyInfo("Product Instance", Id = "EAID_95BE7E3E_D181_4050_AFC9_0BFCC8CA5E1D", IsRequired = false, IsSecured = false)]
        public ProductInstanceReference ProductInstance { get; set; }

        [BDDMPropertyInfo("Serial Number", Id = "EAID_1564B6A4_9239_4ee0_886D_ED81DFE65DBE", IsRequired = false, IsSecured = false)]
        public PrimitiveString SerialNumber { get; set; }

        [BDDMPropertyInfo("Warranty End Date", Id = "EAID_2D2B3C3F_AAF9_4672_B3F8_0E4EAB12D046", IsRequired = false, IsSecured = false)]
        public PrimitiveDateTime WarrantyEndDate { get; set; }

        [BDDMPropertyInfo("Warranty Status", Id = "EAID_3341B90E_1361_4fba_BCEE_01BD030C5937", IsRequired = false, IsSecured = false)]
        public PrimitiveEnum<WarrantyAvailabilityStatus> WarrantyStatus { get; set; }
    }
}
