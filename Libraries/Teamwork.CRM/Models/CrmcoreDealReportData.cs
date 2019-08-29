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
    /// DealReportData
    /// </summary>
    /// <remarks>
    /// DealReportData fields
    /// </remarks>
    public partial class CrmcoreDealReportData
    {
        /// <summary>
        /// Initializes a new instance of the CrmcoreDealReportData class.
        /// </summary>
        public CrmcoreDealReportData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CrmcoreDealReportData class.
        /// </summary>
        /// <param name="groupedBy">ResourceIdentifier</param>
        /// <param name="statuses">DealReportStatuses</param>
        public CrmcoreDealReportData(CrmcoreDealReportDataGroupedBy groupedBy = default(CrmcoreDealReportDataGroupedBy), int? quantity = default(int?), CrmcoreDealReportDataStatuses statuses = default(CrmcoreDealReportDataStatuses), double? value = default(double?))
        {
            GroupedBy = groupedBy;
            Quantity = quantity;
            Statuses = statuses;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resourceIdentifier
        /// </summary>
        /// <remarks>
        /// ResourceIdentifier identifies a relationship resource.
        /// </remarks>
        [JsonProperty(PropertyName = "groupedBy")]
        public CrmcoreDealReportDataGroupedBy GroupedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quantity")]
        public int? Quantity { get; set; }

        /// <summary>
        /// Gets or sets dealReportStatuses
        /// </summary>
        /// <remarks>
        /// DealReportStatuses fields.
        /// </remarks>
        [JsonProperty(PropertyName = "statuses")]
        public CrmcoreDealReportDataStatuses Statuses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public double? Value { get; set; }

    }
}