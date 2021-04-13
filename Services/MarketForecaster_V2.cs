namespace NetCore_DI.Services
{
    /// <summary>
    /// New SUPER Version of the market forecaster.
    /// </summary>
    public class MarketForecaster_V2
    {
        public MarketResult GetMarketPrediction()
        {
            return new MarketResult
            {
                MarketCondition = Models.MarketCondition.Volatile
            };
        }
    }
}