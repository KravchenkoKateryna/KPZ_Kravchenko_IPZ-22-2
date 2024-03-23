using FactoryMethod.Subscribitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Platforms
{
    sealed class ManagerCall : SubscriptionCreator
    {
        public override EducationalSubscription CreateEducationalSubscribition()
        {
            Console.WriteLine("Creating educational subscribition with ManagerCall");
            return base.CreateEducationalSubscribition();
        }

        public override PremiumSubscription CreatePremiumSubscription()
        {
            Console.WriteLine("Creating premium subscription with ManagerCall");
            return base.CreatePremiumSubscription();
        }

        public override DomesticSubscription CreateDomesticSubscription()
        {
            Console.WriteLine("Creating domestic subscription with ManagerCall");
            return base.CreateDomesticSubscription();
        }
    }
}
