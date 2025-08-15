using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class ConsumerHasVulnerableDeviceCollectionResponse : BDDMObject
    {
        public PrimitiveInteger Count { get; set; }
        public BDDMArray<Transactionaldata.Metrics.CoreCrm.ConsumerHasVulnerableDevice> Docs { get; set; }
    }
}
