using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class GroupRoleCollectionResponse : BDDMObject
    {
        public BDDMArray<GroupRole> Group { get; set; }
    }
}
