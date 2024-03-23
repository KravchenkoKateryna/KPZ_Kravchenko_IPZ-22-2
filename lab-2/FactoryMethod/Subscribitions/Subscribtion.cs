namespace FactoryMethod.Subscribitions
{
    abstract class Subscribition
    {
        protected decimal _monthlyFee;
        protected string[] _channels;
        protected TimeSpan _subscribitionPeriod;

        public void GetSubscriptionInfo()
        {
            Console.WriteLine("=================== Information about subscription ===================");
            Console.WriteLine($"Subscribition Type: {GetType().Name}");
            Console.WriteLine($"Monthly fee: {_monthlyFee}");
            Console.WriteLine($"Period of subscription : {_subscribitionPeriod}");
            Console.WriteLine($"Channels are available in subscription: {string.Join(", ", _channels)}");
            Console.WriteLine("======================================================================");
            Console.WriteLine(Environment.NewLine);
        }
    }
}
