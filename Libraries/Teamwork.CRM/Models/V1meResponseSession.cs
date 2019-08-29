// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Teamwork.CRM.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// sessionResponse
    /// </summary>
    public partial class V1meResponseSession
    {
        /// <summary>
        /// Initializes a new instance of the V1meResponseSession class.
        /// </summary>
        public V1meResponseSession()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1meResponseSession class.
        /// </summary>
        /// <param name="installation">ResourceIdentifier</param>
        /// <param name="urls">BillingURLs</param>
        /// <param name="user">ResourceIdentifier</param>
        public V1meResponseSession(IList<V1meResponseSessionFlagsItem> flags = default(IList<V1meResponseSessionFlagsItem>), int? id = default(int?), V1meResponseSessionInstallation installation = default(V1meResponseSessionInstallation), V1meResponseSessionUrls urls = default(V1meResponseSessionUrls), V1meResponseSessionUser user = default(V1meResponseSessionUser))
        {
            Flags = flags;
            Id = id;
            Installation = installation;
            Urls = urls;
            User = user;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "flags")]
        public IList<V1meResponseSessionFlagsItem> Flags { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets resourceIdentifier
        /// </summary>
        /// <remarks>
        /// ResourceIdentifier identifies a relationship resource.
        /// </remarks>
        [JsonProperty(PropertyName = "installation")]
        public V1meResponseSessionInstallation Installation { get; set; }

        /// <summary>
        /// Gets or sets billingURLs
        /// </summary>
        /// <remarks>
        /// BillingURLs is the urls need for billing
        /// </remarks>
        [JsonProperty(PropertyName = "urls")]
        public V1meResponseSessionUrls Urls { get; set; }

        /// <summary>
        /// Gets or sets resourceIdentifier
        /// </summary>
        /// <remarks>
        /// ResourceIdentifier identifies a relationship resource.
        /// </remarks>
        [JsonProperty(PropertyName = "user")]
        public V1meResponseSessionUser User { get; set; }

    }
}
