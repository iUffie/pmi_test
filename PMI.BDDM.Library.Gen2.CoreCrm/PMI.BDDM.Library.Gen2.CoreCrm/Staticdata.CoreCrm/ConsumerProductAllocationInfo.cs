using PMI.BDDM.Common.DataType;
using PMI.BDDM.Staticdata;
using PMI.BDDM.Tools;

namespace PMI.BDDM.Staticdata.CoreCrm;

public class ConsumerProductAllocationInfo : Staticdata.ConsumerProductAllocationInfo
{
    [BDDMPropertyInfo("BrandFamily", IsRequired = false, IsSecured = false)]
    public BrandFamilyReference BrandFamily { get; set; }
}