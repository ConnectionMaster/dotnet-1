// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Teamwork.CRM.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// BillingURLs
    /// </summary>
    /// <remarks>
    /// BillingURLs is the urls need for billing
    /// </remarks>
    public partial class SubscriptionUrlsjsonOKResponseUrls
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SubscriptionUrlsjsonOKResponseUrls class.
        /// </summary>
        public SubscriptionUrlsjsonOKResponseUrls()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SubscriptionUrlsjsonOKResponseUrls class.
        /// </summary>
        public SubscriptionUrlsjsonOKResponseUrls(string checkout = default(string))
        {
            Checkout = checkout;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "checkout")]
        public string Checkout { get; set; }

    }
}
