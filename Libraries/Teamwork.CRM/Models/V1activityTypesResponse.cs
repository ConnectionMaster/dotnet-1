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
    /// activityTypesResponse
    /// </summary>
    public partial class V1activityTypesResponse
    {
        /// <summary>
        /// Initializes a new instance of the V1activityTypesResponse class.
        /// </summary>
        public V1activityTypesResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1activityTypesResponse class.
        /// </summary>
        /// <param name="meta">ResponseMeta</param>
        public V1activityTypesResponse(IList<V1activityTypesResponseActivityTypesItem> activityTypes = default(IList<V1activityTypesResponseActivityTypesItem>), V1activityTypesResponseMeta meta = default(V1activityTypesResponseMeta))
        {
            ActivityTypes = activityTypes;
            Meta = meta;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityTypes")]
        public IList<V1activityTypesResponseActivityTypesItem> ActivityTypes { get; set; }

        /// <summary>
        /// Gets or sets responseMeta
        /// </summary>
        /// <remarks>
        /// ResponseMeta contains common meta data.
        /// </remarks>
        [JsonProperty(PropertyName = "meta")]
        public V1activityTypesResponseMeta Meta { get; set; }

    }
}