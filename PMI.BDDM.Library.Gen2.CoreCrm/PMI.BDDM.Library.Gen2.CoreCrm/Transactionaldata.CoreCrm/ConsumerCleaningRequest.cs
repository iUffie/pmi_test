namespace PMI.BDDM.Transactionaldata.CoreCrm
{
    public class ConsumerCleaningRequest : PMI.BDDM.Transactionaldata.ConsumerCleaningRequest
    {
        public PromotionCodeReference PromotionCodeFreeCleaning { get; set; }
        public PromotionCodeReference PromotionCodeCap { get; set; }
        public PromotionCodeReference PromotionCodeModule { get; set; }
        public RetailSaleOrderReference SaleOrder { get; set; }
        public ConsumerSurveyReference ConsumerSurvey { get; set; }
    }
}