namespace FactoryMethod.Subscribitions
{
    sealed class PremiumSubscription : Subscribition
    {
        public PremiumSubscription()
        {
            _monthlyFee = 400;
            _channels = ["PS1", "PS2", "PS3", "PS4", "PS5", "PS6"];
            _subscribitionPeriod = TimeSpan.FromDays(30);
        }
    }
}
