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
    /// DealReportStatus
    /// </summary>
    /// <remarks>
    /// DealReportStatus fields
    /// </remarks>
    public partial class CrmcoreDealPagedReportMetaStatusesLost
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CrmcoreDealPagedReportMetaStatusesLost class.
        /// </summary>
        public CrmcoreDealPagedReportMetaStatusesLost()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CrmcoreDealPagedReportMetaStatusesLost class.
        /// </summary>
        public CrmcoreDealPagedReportMetaStatusesLost(int? quantity = default(int?), double? value = default(double?))
        {
            Quantity = quantity;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quantity")]
        public int? Quantity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public double? Value { get; set; }

    }
}
