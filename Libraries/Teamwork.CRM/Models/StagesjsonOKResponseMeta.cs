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
    /// ResponseMeta
    /// </summary>
    /// <remarks>
    /// ResponseMeta contains common meta data.
    /// </remarks>
    public partial class StagesjsonOKResponseMeta
    {
        /// <summary>
        /// Initializes a new instance of the StagesjsonOKResponseMeta class.
        /// </summary>
        public StagesjsonOKResponseMeta()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StagesjsonOKResponseMeta class.
        /// </summary>
        /// <param name="page">Page</param>
        public StagesjsonOKResponseMeta(StagesjsonOKResponseMetaPage page = default(StagesjsonOKResponseMetaPage))
        {
            Page = page;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets page
        /// </summary>
        /// <remarks>
        /// Page contains the pagination data.
        /// </remarks>
        [JsonProperty(PropertyName = "page")]
        public StagesjsonOKResponseMetaPage Page { get; set; }

    }
}
