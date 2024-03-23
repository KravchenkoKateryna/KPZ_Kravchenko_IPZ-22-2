using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Subscribitions;

namespace FactoryMethod.Platforms
{
    abstract class SubscriptionCreator
    {
        public virtual EducationalSubscription CreateEducationalSubscribition() => new();

        public virtual PremiumSubscription CreatePremiumSubscription() => new();

        public virtual DomesticSubscription CreateDomesticSubscription() => new();
    }
}
