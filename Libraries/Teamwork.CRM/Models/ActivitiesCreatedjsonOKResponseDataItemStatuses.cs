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
    /// DealReportStatuses
    /// </summary>
    /// <remarks>
    /// DealReportStatuses fields.
    /// </remarks>
    public partial class ActivitiesCreatedjsonOKResponseDataItemStatuses
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ActivitiesCreatedjsonOKResponseDataItemStatuses class.
        /// </summary>
        public ActivitiesCreatedjsonOKResponseDataItemStatuses()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ActivitiesCreatedjsonOKResponseDataItemStatuses class.
        /// </summary>
        /// <param name="lost">DealReportStatus</param>
        /// <param name="open">DealReportStatus</param>
        /// <param name="won">DealReportStatus</param>
        public ActivitiesCreatedjsonOKResponseDataItemStatuses(ActivitiesCreatedjsonOKResponseDataItemStatusesLost lost = default(ActivitiesCreatedjsonOKResponseDataItemStatusesLost), ActivitiesCreatedjsonOKResponseDataItemStatusesOpen open = default(ActivitiesCreatedjsonOKResponseDataItemStatusesOpen), ActivitiesCreatedjsonOKResponseDataItemStatusesWon won = default(ActivitiesCreatedjsonOKResponseDataItemStatusesWon))
        {
            Lost = lost;
            Open = open;
            Won = won;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets dealReportStatus
        /// </summary>
        /// <remarks>
        /// DealReportStatus fields
        /// </remarks>
        [JsonProperty(PropertyName = "lost")]
        public ActivitiesCreatedjsonOKResponseDataItemStatusesLost Lost { get; set; }

        /// <summary>
        /// Gets or sets dealReportStatus
        /// </summary>
        /// <remarks>
        /// DealReportStatus fields
        /// </remarks>
        [JsonProperty(PropertyName = "open")]
        public ActivitiesCreatedjsonOKResponseDataItemStatusesOpen Open { get; set; }

        /// <summary>
        /// Gets or sets dealReportStatus
        /// </summary>
        /// <remarks>
        /// DealReportStatus fields
        /// </remarks>
        [JsonProperty(PropertyName = "won")]
        public ActivitiesCreatedjsonOKResponseDataItemStatusesWon Won { get; set; }

    }
}
