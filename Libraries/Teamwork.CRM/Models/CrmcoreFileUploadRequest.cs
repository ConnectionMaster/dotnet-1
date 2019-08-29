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
    /// FileUploadRequest
    /// </summary>
    /// <remarks>
    /// FileUploadRequest represents a file upload request in the CRM system.
    /// </remarks>
    public partial class CrmcoreFileUploadRequest
    {
        /// <summary>
        /// Initializes a new instance of the CrmcoreFileUploadRequest class.
        /// </summary>
        public CrmcoreFileUploadRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CrmcoreFileUploadRequest class.
        /// </summary>
        /// <param name="target">ResourceIdentifier</param>
        public CrmcoreFileUploadRequest(IList<CrmcoreFileUploadRequestFilesItem> files = default(IList<CrmcoreFileUploadRequestFilesItem>), CrmcoreFileUploadRequestTarget target = default(CrmcoreFileUploadRequestTarget))
        {
            Files = files;
            Target = target;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "files")]
        public IList<CrmcoreFileUploadRequestFilesItem> Files { get; set; }

        /// <summary>
        /// Gets or sets resourceIdentifier
        /// </summary>
        /// <remarks>
        /// ResourceIdentifier identifies a relationship resource.
        /// </remarks>
        [JsonProperty(PropertyName = "target")]
        public CrmcoreFileUploadRequestTarget Target { get; set; }

    }
}
