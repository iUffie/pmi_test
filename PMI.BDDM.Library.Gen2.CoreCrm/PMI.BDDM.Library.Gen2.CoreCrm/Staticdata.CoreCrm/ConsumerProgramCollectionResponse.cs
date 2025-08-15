using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class ConsumerProgramCollectionResponse : BDDMObject
    {
        public PrimitiveInteger Count { get; set; }
        public BDDMArray<ConsumerProgram> Docs { get; set; }
    }
}