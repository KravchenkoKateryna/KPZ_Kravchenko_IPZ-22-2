namespace FactoryMethod.Subscribitions
{
    sealed class EducationalSubscription : Subscribition
    {
        public EducationalSubscription()
        {
            _channels = ["ED1", "ED2", "ED3", "ED4"];
            _monthlyFee = 150;
            _subscribitionPeriod = TimeSpan.FromDays(60);
        }
    }
}
