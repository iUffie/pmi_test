using PMI.BDDM.Common.DataType;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class RetailAcceptanceAct : Staticdata.RetailAcceptanceAct
    {
        [BDDMPropertyInfo("Type", IsRequired = false, IsSecured = false)]
        public PrimitiveString Type { get; set; }
        [BDDMPropertyInfo("Migration Information", IsRequired = false, IsSecured = false)]
        public DocumentReference MigrationInformation { get; set; }
    }
}