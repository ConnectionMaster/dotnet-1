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
    /// dealsResponse
    /// </summary>
    public partial class DealsjsonOKResponse
    {
        /// <summary>
        /// Initializes a new instance of the DealsjsonOKResponse class.
        /// </summary>
        public DealsjsonOKResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DealsjsonOKResponse class.
        /// </summary>
        /// <param name="included">Included</param>
        /// <param name="meta">ResponseMeta</param>
        public DealsjsonOKResponse(IList<DealsjsonOKResponseDealsItem> deals = default(IList<DealsjsonOKResponseDealsItem>), object included = default(object), DealsjsonOKResponseMeta meta = default(DealsjsonOKResponseMeta))
        {
            Deals = deals;
            Included = included;
            Meta = meta;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deals")]
        public IList<DealsjsonOKResponseDealsItem> Deals { get; set; }

        /// <summary>
        /// Gets or sets included
        /// </summary>
        /// <remarks>
        /// Included contains all the side-loaded data of a response.
        /// See [including related
        /// entities](https://crmdev-teamwork.docs.stoplight.io/documentation/general/related-entities).
        /// </remarks>
        [JsonProperty(PropertyName = "included")]
        public object Included { get; set; }

        /// <summary>
        /// Gets or sets responseMeta
        /// </summary>
        /// <remarks>
        /// ResponseMeta contains common meta data.
        /// </remarks>
        [JsonProperty(PropertyName = "meta")]
        public DealsjsonOKResponseMeta Meta { get; set; }

    }
}