using PMI.BDDM.Common;
using PMI.BDDM.Common.DataType;

namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class ChangeListItem : BDDMObject
    {
        public PrimitiveString ColumnName { get; set; }

        public PrimitiveDateTime ChangeTime { get; set; }

        public PrimitiveString Event { get; set; }

        public GenericUserReference ChangedBy { get; set; }

        public PrimitiveString PreviousValue { get; set; }

        public PrimitiveString NewValue { get; set; }

        public GenericUserReference CreatedBy { get; set; }

        public GenericUserReference ModifiedBy { get; set; }

        public PrimitiveDateTime CreationTime { get; set; }

        public PrimitiveDateTime UpdateTime { get; set; }
    }
}
