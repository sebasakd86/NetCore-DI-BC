namespace NetCore_DI.Services
{
    public class MarketForecaster
    {
        public MarketResult GetMarketPrediction()
        {
            return new MarketResult
            {
                MarketCondition = Models.MarketCondition.StableUp
            };
        }
    }
}