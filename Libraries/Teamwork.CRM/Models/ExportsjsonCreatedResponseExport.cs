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
    /// Export
    /// </summary>
    /// <remarks>
    /// Export represents a export request stored in job queue.
    /// </remarks>
    public partial class ExportsjsonCreatedResponseExport
    {
        /// <summary>
        /// Initializes a new instance of the ExportsjsonCreatedResponseExport
        /// class.
        /// </summary>
        public ExportsjsonCreatedResponseExport()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExportsjsonCreatedResponseExport
        /// class.
        /// </summary>
        /// <param name="createdBy">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        /// <param name="deletedBy">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        /// <param name="updatedBy">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        public ExportsjsonCreatedResponseExport(int? bytes = default(int?), System.DateTime? createdAt = default(System.DateTime?), ExportsjsonCreatedResponseExportCreatedBy createdBy = default(ExportsjsonCreatedResponseExportCreatedBy), System.DateTime? deletedAt = default(System.DateTime?), ExportsjsonCreatedResponseExportDeletedBy deletedBy = default(ExportsjsonCreatedResponseExportDeletedBy), string downloadUrl = default(string), System.DateTime? expirationDate = default(System.DateTime?), string filterName = default(string), int? id = default(int?), string kind = default(string), string pipelineName = default(string), int? state = default(int?), System.DateTime? updatedAt = default(System.DateTime?), ExportsjsonCreatedResponseExportUpdatedBy updatedBy = default(ExportsjsonCreatedResponseExportUpdatedBy), int? updatedSourceId = default(int?))
        {
            Bytes = bytes;
            CreatedAt = createdAt;
            CreatedBy = createdBy;
            DeletedAt = deletedAt;
            DeletedBy = deletedBy;
            DownloadUrl = downloadUrl;
            ExpirationDate = expirationDate;
            FilterName = filterName;
            Id = id;
            Kind = kind;
            PipelineName = pipelineName;
            State = state;
            UpdatedAt = updatedAt;
            UpdatedBy = updatedBy;
            UpdatedSourceId = updatedSourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bytes")]
        public int? Bytes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdAt")]
        public System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets [Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.
        /// </summary>
        [JsonProperty(PropertyName = "createdBy")]
        public ExportsjsonCreatedResponseExportCreatedBy CreatedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deletedAt")]
        public System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Gets or sets [Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.
        /// </summary>
        [JsonProperty(PropertyName = "deletedBy")]
        public ExportsjsonCreatedResponseExportDeletedBy DeletedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "downloadUrl")]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "expirationDate")]
        public System.DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filterName")]
        public string FilterName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pipelineName")]
        public string PipelineName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public int? State { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "updatedAt")]
        public System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets [Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.
        /// </summary>
        [JsonProperty(PropertyName = "updatedBy")]
        public ExportsjsonCreatedResponseExportUpdatedBy UpdatedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "updatedSourceId")]
        public int? UpdatedSourceId { get; set; }

    }
}
