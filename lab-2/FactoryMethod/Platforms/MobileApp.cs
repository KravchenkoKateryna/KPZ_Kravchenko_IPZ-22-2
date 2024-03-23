using FactoryMethod.Subscribitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Platforms
{
    internal class MobileApp : SubscriptionCreator
    {
        public override EducationalSubscription CreateEducationalSubscribition()
        {
            Console.WriteLine("Creating educational subscribition with MobileApp");
            return base.CreateEducationalSubscribition();
        }

        public override PremiumSubscription CreatePremiumSubscription()
        {
            Console.WriteLine("Creating premium subscription with MobileApp");
            return base.CreatePremiumSubscription();
        }

        public override DomesticSubscription CreateDomesticSubscription()
        {
            Console.WriteLine("Creating domestic subscription with MobileApp");
            return base.CreateDomesticSubscription();
        }
    }
}
