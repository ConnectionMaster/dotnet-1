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
    /// Page
    /// </summary>
    /// <remarks>
    /// Page contains the pagination data.
    /// </remarks>
    public partial class DealsjsonOKResponseMetaPage
    {
        /// <summary>
        /// Initializes a new instance of the DealsjsonOKResponseMetaPage
        /// class.
        /// </summary>
        public DealsjsonOKResponseMetaPage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DealsjsonOKResponseMetaPage
        /// class.
        /// </summary>
        public DealsjsonOKResponseMetaPage(int? count = default(int?), int? pageOffset = default(int?), int? pageSize = default(int?))
        {
            Count = count;
            PageOffset = pageOffset;
            PageSize = pageSize;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int? Count { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pageOffset")]
        public int? PageOffset { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pageSize")]
        public int? PageSize { get; set; }

    }
}
