using PMI.BDDM.Staticdata;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Transactionaldata.CoreCrm;

public class ConsumerProductInstanceBinding : Transactionaldata.ConsumerProductInstanceBinding
{
    [BDDMPropertyInfo("Product Instance", IsRequired = true, IsSecured = false)]
    public new ProductInstance ProductInstance { get; set; }
}