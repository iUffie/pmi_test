namespace PMI.BDDM.Staticdata.CoreCrm
{
    public class UserTrackAction : Staticdata.UserTrackAction
    {
        public GenericUserReference CreatedBy { get; set; }
        public GenericUserReference UpdatedBy { get; set; }
    }
}
