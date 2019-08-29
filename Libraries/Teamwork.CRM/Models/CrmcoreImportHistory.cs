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
    /// ImportHistory
    /// </summary>
    /// <remarks>
    /// ImportHistory represents an ImportHistory in the CRM system.
    /// </remarks>
    public partial class CrmcoreImportHistory
    {
        /// <summary>
        /// Initializes a new instance of the CrmcoreImportHistory class.
        /// </summary>
        public CrmcoreImportHistory()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CrmcoreImportHistory class.
        /// </summary>
        /// <param name="creator">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        /// <param name="errorReportFileUrl">Error report for failed imports or
        /// reasons for skipped rows.</param>
        /// <param name="fileType">Possible values include: 'xlsx'</param>
        /// <param name="kind">Possible values include: 'deals'</param>
        /// <param name="numberOfRowsProcessed">The number of rows successfully
        /// imported.</param>
        /// <param name="numberOfRowsSkipped">The number of rows skipped, see
        /// errorReportFileUrl for reasons.</param>
        /// <param name="state">Possible values include: 'pending', 'progress',
        /// 'complete', 'error'</param>
        public CrmcoreImportHistory(System.DateTime? createdAt = default(System.DateTime?), CrmcoreImportHistoryCreator creator = default(CrmcoreImportHistoryCreator), string errorReportFileUrl = default(string), string fileType = default(string), int? id = default(int?), string kind = default(string), string message = default(string), int? numberOfRowsProcessed = default(int?), int? numberOfRowsSkipped = default(int?), string state = default(string), System.DateTime? updatedAt = default(System.DateTime?))
        {
            CreatedAt = createdAt;
            Creator = creator;
            ErrorReportFileUrl = errorReportFileUrl;
            FileType = fileType;
            Id = id;
            Kind = kind;
            Message = message;
            NumberOfRowsProcessed = numberOfRowsProcessed;
            NumberOfRowsSkipped = numberOfRowsSkipped;
            State = state;
            UpdatedAt = updatedAt;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdAt")]
        public System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets [Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.
        /// </summary>
        [JsonProperty(PropertyName = "creator")]
        public CrmcoreImportHistoryCreator Creator { get; set; }

        /// <summary>
        /// Gets or sets error report for failed imports or reasons for skipped
        /// rows.
        /// </summary>
        [JsonProperty(PropertyName = "errorReportFileUrl")]
        public string ErrorReportFileUrl { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'xlsx'
        /// </summary>
        [JsonProperty(PropertyName = "fileType")]
        public string FileType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'deals'
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the number of rows successfully imported.
        /// </summary>
        [JsonProperty(PropertyName = "numberOfRowsProcessed")]
        public int? NumberOfRowsProcessed { get; set; }

        /// <summary>
        /// Gets or sets the number of rows skipped, see errorReportFileUrl for
        /// reasons.
        /// </summary>
        [JsonProperty(PropertyName = "numberOfRowsSkipped")]
        public int? NumberOfRowsSkipped { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'pending', 'progress',
        /// 'complete', 'error'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "updatedAt")]
        public System.DateTime? UpdatedAt { get; set; }

    }
}
