namespace FactoryMethod.Subscribitions
{
    sealed class DomesticSubscription : Subscribition
    {
        public DomesticSubscription()
        {
            _channels = ["DS1", "DS2", "DS3"];
            _monthlyFee = 300;
            _subscribitionPeriod = TimeSpan.FromDays(45);
        }
    }
}
