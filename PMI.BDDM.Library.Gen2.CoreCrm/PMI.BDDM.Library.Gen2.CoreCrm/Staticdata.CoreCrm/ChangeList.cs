using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class ChangeList : BDDMObject
    {
        public ChangeListRecord Object { get; set; }
        public BDDMArray<ChangeListItem> ChangeListItem { get; set; }
    }
}
