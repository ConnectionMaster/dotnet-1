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
    public partial class LeadsQualifiedjsonOKResponseDataItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LeadsQualifiedjsonOKResponseDataItem class.
        /// </summary>
        public LeadsQualifiedjsonOKResponseDataItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LeadsQualifiedjsonOKResponseDataItem class.
        /// </summary>
        /// <param name="groupedBy">ResourceIdentifier</param>
        /// <param name="statuses">DealReportStatuses</param>
        public LeadsQualifiedjsonOKResponseDataItem(LeadsQualifiedjsonOKResponseDataItemGroupedBy groupedBy = default(LeadsQualifiedjsonOKResponseDataItemGroupedBy), int? quantity = default(int?), LeadsQualifiedjsonOKResponseDataItemStatuses statuses = default(LeadsQualifiedjsonOKResponseDataItemStatuses), double? value = default(double?))
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
        public LeadsQualifiedjsonOKResponseDataItemGroupedBy GroupedBy { get; set; }

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
        public LeadsQualifiedjsonOKResponseDataItemStatuses Statuses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public double? Value { get; set; }

    }
}
