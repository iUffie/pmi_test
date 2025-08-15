using PMI.BDDM.Common.DataType;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class ConsumableBrandVariant : PMI.BDDM.Staticdata.ConsumableBrandVariant
    {
        [BDDMPropertyInfo("Active", IsRequired = false, IsSecured = false)]
        public PrimitiveBoolean Active { get; set; }
        [BDDMPropertyInfo("Bundle", IsRequired = false, IsSecured = false)]
        public PrimitiveBoolean Bundle { get; set; }
        [BDDMPropertyInfo("Category", IsRequired = false, IsSecured = false)]
        public PrimitiveString Category { get; set; }
        [BDDMPropertyInfo("ColorHex", IsRequired = false, IsSecured = false)]
        public PrimitiveString ColorHex { get; set; }
        [BDDMPropertyInfo("Group", IsRequired = false, IsSecured = false)]
        public PrimitiveString Group { get; set; }
        [BDDMPropertyInfo("Position In Family", IsRequired = false, IsSecured = false)]
        public PrimitiveString PositionInFamily { get; set; }
        [BDDMPropertyInfo("Product Family", IsRequired = false, IsSecured = false)]
        public BrandFamilyReference ProductFamily { get; set; }
        [BDDMPropertyInfo("Product Family Rus", IsRequired = false, IsSecured = false)]
        public PrimitiveString ProductFamilyRus { get; set; }
        [BDDMPropertyInfo("Product Subcategory Rus", IsRequired = false, IsSecured = false)]
        public PrimitiveString ProductSubcategoryRus { get; set; }
        [BDDMPropertyInfo("Created By", IsRequired = false, IsSecured = false)]
        public GenericUserReference CreatedBy { get; set; }
        [BDDMPropertyInfo("Updated By", IsRequired = false, IsSecured = false)]
        public GenericUserReference UpdatedBy { get; set; }
    }
}
