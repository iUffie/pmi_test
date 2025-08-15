using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class ProductCatalogItem : BDDMObject
    {
        [BDDMPropertyInfo("Active", IsRequired = false, IsSecured = false)]
        public PrimitiveBoolean Active { get; set; }
        [BDDMPropertyInfo("Brand Variant", IsRequired = false, IsSecured = false)]
        public ProductCatalogVariantReference BrandVariant { get; set; }
        [BDDMPropertyInfo("Is Manual Edit", IsRequired = false, IsSecured = false)]
        public PrimitiveBoolean IsManualEdit { get; set; }
        [BDDMPropertyInfo("Link", IsRequired = false, IsSecured = false)]
        public PrimitiveString Link { get; set; }
        [BDDMPropertyInfo("UOM", IsRequired = false, IsSecured = false)]
        public PrimitiveEnum<QuantityUOM> UOM { get; set; }
        [BDDMPropertyInfo("Number Links", IsRequired = false, IsSecured = false)]
        public PrimitiveInteger NumberLinks { get; set; }
        [BDDMPropertyInfo("Code", IsRequired = false, IsSecured = false)]
        public PrimitiveString Code { get; set; }
        [BDDMPropertyInfo("Code Space", IsRequired = false, IsSecured = false)]
        public PrimitiveEnum<CodeSpace> CodeSpace { get; set; }
        [BDDMPropertyInfo("Created By", IsRequired = false, IsSecured = false)]
        public GenericUserReference CreatedBy { get; set; }
        [BDDMPropertyInfo("Updated By", IsRequired = false, IsSecured = false)]
        public GenericUserReference UpdatedBy { get; set; }
        [BDDMPropertyInfo("Creation Time", IsRequired = false, IsSecured = false)]
        public PrimitiveDateTime CreationTime { get; set; }
        [BDDMPropertyInfo("Update Time", IsRequired = false, IsSecured = false)]
        public PrimitiveDateTime UpdateTime { get; set; }
    }
}
