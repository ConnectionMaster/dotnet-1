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
    /// OvertimeReportDataMeta
    /// </summary>
    /// <remarks>
    /// OvertimeReportDataMeta fields
    /// </remarks>
    public partial class CrmcoreOvertimeReportDataMeta
    {
        /// <summary>
        /// Initializes a new instance of the CrmcoreOvertimeReportDataMeta
        /// class.
        /// </summary>
        public CrmcoreOvertimeReportDataMeta()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CrmcoreOvertimeReportDataMeta
        /// class.
        /// </summary>
        public CrmcoreOvertimeReportDataMeta(string timeUnit = default(string))
        {
            TimeUnit = timeUnit;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timeUnit")]
        public string TimeUnit { get; set; }

    }
}