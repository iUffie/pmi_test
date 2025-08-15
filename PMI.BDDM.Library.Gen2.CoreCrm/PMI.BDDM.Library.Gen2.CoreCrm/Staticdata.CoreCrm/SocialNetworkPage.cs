using PMI.BDDM.Common.DataType;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class SocialNetworkPage : Staticdata.SocialNetworkPage
    {
        [BDDMPropertyInfo("Creation Time", IsRequired = false, IsSecured = false)]
        public PrimitiveDateTime CreationTime { get; set; }

        [BDDMPropertyInfo("Update Time", IsRequired = false, IsSecured = false)]
        public PrimitiveDateTime UpdateTime { get; set; }
    }
}