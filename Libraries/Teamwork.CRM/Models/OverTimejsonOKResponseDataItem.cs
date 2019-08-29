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
    /// OvertimeReportData
    /// </summary>
    /// <remarks>
    /// OvertimeReportData fields
    /// </remarks>
    public partial class OverTimejsonOKResponseDataItem
    {
        /// <summary>
        /// Initializes a new instance of the OverTimejsonOKResponseDataItem
        /// class.
        /// </summary>
        public OverTimejsonOKResponseDataItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OverTimejsonOKResponseDataItem
        /// class.
        /// </summary>
        /// <param name="groupedBy">ResourceIdentifier</param>
        public OverTimejsonOKResponseDataItem(OverTimejsonOKResponseDataItemGroupedBy groupedBy = default(OverTimejsonOKResponseDataItemGroupedBy), IList<OverTimejsonOKResponseDataItemPointsItem> points = default(IList<OverTimejsonOKResponseDataItemPointsItem>))
        {
            GroupedBy = groupedBy;
            Points = points;
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
        public OverTimejsonOKResponseDataItemGroupedBy GroupedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "points")]
        public IList<OverTimejsonOKResponseDataItemPointsItem> Points { get; set; }

    }
}
