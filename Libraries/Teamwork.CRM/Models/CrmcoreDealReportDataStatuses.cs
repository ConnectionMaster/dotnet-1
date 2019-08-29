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
    public partial class CrmcoreDealReportDataStatuses
    {
        /// <summary>
        /// Initializes a new instance of the CrmcoreDealReportDataStatuses
        /// class.
        /// </summary>
        public CrmcoreDealReportDataStatuses()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CrmcoreDealReportDataStatuses
        /// class.
        /// </summary>
        /// <param name="lost">DealReportStatus</param>
        /// <param name="open">DealReportStatus</param>
        /// <param name="won">DealReportStatus</param>
        public CrmcoreDealReportDataStatuses(CrmcoreDealReportDataStatusesLost lost = default(CrmcoreDealReportDataStatusesLost), CrmcoreDealReportDataStatusesOpen open = default(CrmcoreDealReportDataStatusesOpen), CrmcoreDealReportDataStatusesWon won = default(CrmcoreDealReportDataStatusesWon))
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
        public CrmcoreDealReportDataStatusesLost Lost { get; set; }

        /// <summary>
        /// Gets or sets dealReportStatus
        /// </summary>
        /// <remarks>
        /// DealReportStatus fields
        /// </remarks>
        [JsonProperty(PropertyName = "open")]
        public CrmcoreDealReportDataStatusesOpen Open { get; set; }

        /// <summary>
        /// Gets or sets dealReportStatus
        /// </summary>
        /// <remarks>
        /// DealReportStatus fields
        /// </remarks>
        [JsonProperty(PropertyName = "won")]
        public CrmcoreDealReportDataStatusesWon Won { get; set; }

    }
}
