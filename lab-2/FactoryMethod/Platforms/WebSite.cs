using FactoryMethod.Subscribitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Platforms
{
    internal class WebSite : SubscriptionCreator
    {
        public override EducationalSubscription CreateEducationalSubscribition()
        {
            Console.WriteLine("Creating educational subscribition with WebSite");
            return base.CreateEducationalSubscribition();
        }

        public override PremiumSubscription CreatePremiumSubscription()
        {
            Console.WriteLine("Creating premium subscription with WebSite");
            return base.CreatePremiumSubscription();
        }

        public override DomesticSubscription CreateDomesticSubscription()
        {
            Console.WriteLine("Creating domestic subscription with WebSite");
            return base.CreateDomesticSubscription();
        }
    }
}
