using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;
using PMI.BDDM.Staticdata;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Transactionaldata.CoreCrm
{
    public class SocialMessage : BDDMObject
    {
        [BDDMPropertyInfo("Code", IsRequired = false, IsSecured = false)]
        public PrimitiveString Code { get; set; }
        [BDDMPropertyInfo("Code Space", IsRequired = false, IsSecured = false)]
        public PrimitiveEnum<CodeSpace> CodeSpace { get; set; }
        [BDDMPropertyInfo("Message", IsRequired = false, IsSecured = false)]
        public PrimitiveString Message { get; set; }
        [BDDMPropertyInfo("Basis", IsRequired = false, IsSecured = false)]
        public BusinessEntityReference Basis { get; set; }
        [BDDMPropertyInfo("Parent", IsRequired = false, IsSecured = false)]
        public SocialMessageReference Parent { get; set; }
        [BDDMPropertyInfo("Created By", IsRequired = false, IsSecured = false)]
        public GenericUserReference CreatedBy { get; set; }
        [BDDMPropertyInfo("Update By", IsRequired = false, IsSecured = false)]
        public GenericUserReference UpdatedBy { get; set; }
        [BDDMPropertyInfo("Creation Time", IsRequired = false, IsSecured = false)]
        public PrimitiveDateTime CreationTime { get; set; }
        [BDDMPropertyInfo("Update Time", IsRequired = false, IsSecured = false)]
        public PrimitiveDateTime UpdateTime { get; set; }
    }
}
