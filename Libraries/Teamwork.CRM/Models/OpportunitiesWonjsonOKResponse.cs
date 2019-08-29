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
    /// DealReportWithIncludes
    /// </summary>
    /// <remarks>
    /// DealReportWithIncludes defines reports result with included entities
    /// </remarks>
    public partial class OpportunitiesWonjsonOKResponse
    {
        /// <summary>
        /// Initializes a new instance of the OpportunitiesWonjsonOKResponse
        /// class.
        /// </summary>
        public OpportunitiesWonjsonOKResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OpportunitiesWonjsonOKResponse
        /// class.
        /// </summary>
        /// <param name="included">Included</param>
        /// <param name="meta">DealPagedReportMeta</param>
        public OpportunitiesWonjsonOKResponse(IList<OpportunitiesWonjsonOKResponseDataItem> data = default(IList<OpportunitiesWonjsonOKResponseDataItem>), object included = default(object), OpportunitiesWonjsonOKResponseMeta meta = default(OpportunitiesWonjsonOKResponseMeta))
        {
            Data = data;
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
        [JsonProperty(PropertyName = "data")]
        public IList<OpportunitiesWonjsonOKResponseDataItem> Data { get; set; }

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
        /// Gets or sets dealPagedReportMeta
        /// </summary>
        /// <remarks>
        /// DealPagedReportMeta fields
        /// </remarks>
        [JsonProperty(PropertyName = "meta")]
        public OpportunitiesWonjsonOKResponseMeta Meta { get; set; }

    }
}
