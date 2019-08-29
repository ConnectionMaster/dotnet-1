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
    /// FileThumbnail
    /// </summary>
    /// <remarks>
    /// FileThumbnail represents a thumbnail of a uploaded file in the CRM
    /// system
    /// </remarks>
    public partial class IdjsonOKResponseFileThumbnailsItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// IdjsonOKResponseFileThumbnailsItem class.
        /// </summary>
        public IdjsonOKResponseFileThumbnailsItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// IdjsonOKResponseFileThumbnailsItem class.
        /// </summary>
        /// <param name="createdBy">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        /// <param name="deletedBy">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        /// <param name="fileId">ResourceIdentifier</param>
        /// <param name="updatedBy">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        public IdjsonOKResponseFileThumbnailsItem(int? constraint = default(int?), System.DateTime? createdAt = default(System.DateTime?), IdjsonOKResponseFileThumbnailsItemCreatedBy createdBy = default(IdjsonOKResponseFileThumbnailsItemCreatedBy), System.DateTime? deletedAt = default(System.DateTime?), IdjsonOKResponseFileThumbnailsItemDeletedBy deletedBy = default(IdjsonOKResponseFileThumbnailsItemDeletedBy), IdjsonOKResponseFileThumbnailsItemFileId fileId = default(IdjsonOKResponseFileThumbnailsItemFileId), int? height = default(int?), int? id = default(int?), string publicPath = default(string), string s3Path = default(string), System.DateTime? updatedAt = default(System.DateTime?), IdjsonOKResponseFileThumbnailsItemUpdatedBy updatedBy = default(IdjsonOKResponseFileThumbnailsItemUpdatedBy), int? updatedSourceId = default(int?), int? width = default(int?))
        {
            Constraint = constraint;
            CreatedAt = createdAt;
            CreatedBy = createdBy;
            DeletedAt = deletedAt;
            DeletedBy = deletedBy;
            FileId = fileId;
            Height = height;
            Id = id;
            PublicPath = publicPath;
            S3Path = s3Path;
            UpdatedAt = updatedAt;
            UpdatedBy = updatedBy;
            UpdatedSourceId = updatedSourceId;
            Width = width;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "constraint")]
        public int? Constraint { get; set; }

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
        public IdjsonOKResponseFileThumbnailsItemCreatedBy CreatedBy { get; set; }

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
        public IdjsonOKResponseFileThumbnailsItemDeletedBy DeletedBy { get; set; }

        /// <summary>
        /// Gets or sets resourceIdentifier
        /// </summary>
        /// <remarks>
        /// ResourceIdentifier identifies a relationship resource.
        /// </remarks>
        [JsonProperty(PropertyName = "fileId")]
        public IdjsonOKResponseFileThumbnailsItemFileId FileId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public int? Height { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "publicPath")]
        public string PublicPath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "s3Path")]
        public string S3Path { get; set; }

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
        public IdjsonOKResponseFileThumbnailsItemUpdatedBy UpdatedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "updatedSourceId")]
        public int? UpdatedSourceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "width")]
        public int? Width { get; set; }

    }
}
