using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;

namespace PMI.BDDM.Transactionaldata.CoreCrm
{
    public class ConsumerWalletCardCollectionResponse : BDDMObject
    {
        public PrimitiveInteger Count { get; set; }
        public BDDMArray<PMI.BDDM.Staticdata.ConsumerWalletCard> Docs { get; set; }
    }
}