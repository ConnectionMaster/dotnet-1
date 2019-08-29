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
    /// ImportsListResponse
    /// </summary>
    /// <remarks>
    /// ImportsListResponse is the response to the get import history.
    /// </remarks>
    public partial class V1ImportsListResponse
    {
        /// <summary>
        /// Initializes a new instance of the V1ImportsListResponse class.
        /// </summary>
        public V1ImportsListResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1ImportsListResponse class.
        /// </summary>
        /// <param name="included">Included</param>
        /// <param name="meta">ResponseMeta</param>
        public V1ImportsListResponse(IList<V1ImportsListResponseImportsItem> imports = default(IList<V1ImportsListResponseImportsItem>), object included = default(object), V1ImportsListResponseMeta meta = default(V1ImportsListResponseMeta))
        {
            Imports = imports;
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
        [JsonProperty(PropertyName = "imports")]
        public IList<V1ImportsListResponseImportsItem> Imports { get; set; }

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
        public V1ImportsListResponseMeta Meta { get; set; }

    }
}
