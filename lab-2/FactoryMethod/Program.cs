using FactoryMethod.Platforms;
using FactoryMethod.Subscribitions;

namespace FactoryMethod
{
    class Program
    {
        private static void Main()
        {
            TestSubscriptionCreation<MobileApp>();
            TestSubscriptionCreation<ManagerCall>();
            TestSubscriptionCreation<WebSite>();
        }

        private static void TestSubscriptionCreation<T>() where T : SubscriptionCreator, new()
        {
            T subscriptionCreator = new();

            subscriptionCreator.CreateEducationalSubscribition().GetSubscriptionInfo();
            subscriptionCreator.CreatePremiumSubscription().GetSubscriptionInfo();
            subscriptionCreator.CreateDomesticSubscription().GetSubscriptionInfo();
        }
    }
}
