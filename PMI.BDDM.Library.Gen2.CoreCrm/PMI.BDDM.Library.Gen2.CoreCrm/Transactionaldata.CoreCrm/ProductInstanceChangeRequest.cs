using PMI.BDDM.Staticdata;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Transactionaldata.CoreCrm
{
    public class ProductInstanceChangeRequest : PMI.BDDM.Transactionaldata.ProductInstanceChangeRequest
    {
        [BDDMPropertyInfo("Inbound Point", IsRequired = false, IsSecured = false)]
        public SalesPointReference InboundPoint { get; set; }
        [BDDMPropertyInfo("Resolve Legal Entity", IsRequired = false, IsSecured = false)]
        public LegalEntityReference ResolveLegalEntity { get; set; }
        [BDDMPropertyInfo("Resolve Point", IsRequired = false, IsSecured = false)]
        public SalesPointReference ResolvePoint { get; set; }
        [BDDMPropertyInfo("Closed By", IsRequired = false, IsSecured = false)]
        public GenericUserReference ClosedBy { get; set; }
    }
}
