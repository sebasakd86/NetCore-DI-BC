namespace NetCore_DI.Services
{
    public class MarketForecaster : IMarketForecaster
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