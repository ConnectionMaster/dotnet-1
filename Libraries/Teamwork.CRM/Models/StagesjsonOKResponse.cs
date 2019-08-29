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
    /// stagesResponse
    /// </summary>
    public partial class StagesjsonOKResponse
    {
        /// <summary>
        /// Initializes a new instance of the StagesjsonOKResponse class.
        /// </summary>
        public StagesjsonOKResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StagesjsonOKResponse class.
        /// </summary>
        /// <param name="included">Included</param>
        /// <param name="meta">ResponseMeta</param>
        public StagesjsonOKResponse(object included = default(object), StagesjsonOKResponseMeta meta = default(StagesjsonOKResponseMeta), IList<StagesjsonOKResponseStagesItem> stages = default(IList<StagesjsonOKResponseStagesItem>))
        {
            Included = included;
            Meta = meta;
            Stages = stages;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

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
        public StagesjsonOKResponseMeta Meta { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stages")]
        public IList<StagesjsonOKResponseStagesItem> Stages { get; set; }

    }
}
