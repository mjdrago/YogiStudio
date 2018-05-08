using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YogiStudio
{
    public class Stripe
    {
        public static object StripeConfiguration { get; internal set; }

        public class StripeSettings
        {
            public string SecretKey { get; set; }
            public string PublishableKey { get; set; }
        }
    }
}