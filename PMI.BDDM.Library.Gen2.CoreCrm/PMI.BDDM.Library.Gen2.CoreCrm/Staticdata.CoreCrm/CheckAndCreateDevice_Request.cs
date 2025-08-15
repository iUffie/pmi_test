using PMI.BDDM.Common.DataType;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class CheckAndCreateDevice_Request : ProductInstance.CheckAndCreateDevice_Request
    {
        public PrimitiveString CheckiTrack { get; set; }
        public GenericProductReference Product { get; set; }
    }
}
