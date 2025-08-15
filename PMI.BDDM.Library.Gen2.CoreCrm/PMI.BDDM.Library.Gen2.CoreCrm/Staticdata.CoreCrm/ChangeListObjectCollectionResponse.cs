using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class ChangeListObjectCollectionResponse : BDDMObject
    {
        public BDDMArray<ChangeListObject> ChangeListTables { get; set; }
    }
}
