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
    /// DealPagedReportMeta
    /// </summary>
    /// <remarks>
    /// DealPagedReportMeta fields
    /// </remarks>
    public partial class DealsCreatedjsonOKResponseMeta
    {
        /// <summary>
        /// Initializes a new instance of the DealsCreatedjsonOKResponseMeta
        /// class.
        /// </summary>
        public DealsCreatedjsonOKResponseMeta()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DealsCreatedjsonOKResponseMeta
        /// class.
        /// </summary>
        /// <param name="page">ReportPage</param>
        /// <param name="statuses">DealReportStatuses</param>
        public DealsCreatedjsonOKResponseMeta(DealsCreatedjsonOKResponseMetaPage page = default(DealsCreatedjsonOKResponseMetaPage), DealsCreatedjsonOKResponseMetaStatuses statuses = default(DealsCreatedjsonOKResponseMetaStatuses), int? totalQuantity = default(int?), double? totalValue = default(double?))
        {
            Page = page;
            Statuses = statuses;
            TotalQuantity = totalQuantity;
            TotalValue = totalValue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets reportPage
        /// </summary>
        /// <remarks>
        /// ReportPage contains the pagination data.
        /// </remarks>
        [JsonProperty(PropertyName = "page")]
        public DealsCreatedjsonOKResponseMetaPage Page { get; set; }

        /// <summary>
        /// Gets or sets dealReportStatuses
        /// </summary>
        /// <remarks>
        /// DealReportStatuses fields.
        /// </remarks>
        [JsonProperty(PropertyName = "statuses")]
        public DealsCreatedjsonOKResponseMetaStatuses Statuses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalQuantity")]
        public int? TotalQuantity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalValue")]
        public double? TotalValue { get; set; }

    }
}