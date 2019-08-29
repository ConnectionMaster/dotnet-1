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
    /// SearchableEntity
    /// </summary>
    /// <remarks>
    /// SearchableEntity defines entity of any type that is searchable.
    /// </remarks>
    public partial class CrmcoreSearchableEntity
    {
        /// <summary>
        /// Initializes a new instance of the CrmcoreSearchableEntity class.
        /// </summary>
        public CrmcoreSearchableEntity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CrmcoreSearchableEntity class.
        /// </summary>
        /// <param name="content">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        /// <param name="kind">Kind is the `content` type, but a **deals**
        /// entity `type` can be of `kind` *"leads"* / *"opportunities"*
        /// and **pipelines** entity `type` can be of `kind` *"lead-pipelines"*
        /// / *"opportunity-pipelines"*. Possible values include: 'activities',
        /// 'companies', 'contacts', 'files', 'leads', 'leads-pipeline',
        /// 'notes', 'opportunities', 'opportunities-pipeline
        /// products', 'stages', 'users'</param>
        /// <param name="title">Title is a string that represents the `content`
        /// entity.</param>
        public CrmcoreSearchableEntity(CrmcoreSearchableEntityContent content = default(CrmcoreSearchableEntityContent), string kind = default(string), string title = default(string))
        {
            Content = content;
            Kind = kind;
            Title = title;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets [Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.
        /// </summary>
        [JsonProperty(PropertyName = "content")]
        public CrmcoreSearchableEntityContent Content { get; set; }

        /// <summary>
        /// Gets or sets kind is the `content` type, but a **deals** entity
        /// `type` can be of `kind` *"leads"* / *"opportunities"*
        /// and **pipelines** entity `type` can be of `kind` *"lead-pipelines"*
        /// / *"opportunity-pipelines"*. Possible values include: 'activities',
        /// 'companies', 'contacts', 'files', 'leads', 'leads-pipeline',
        /// 'notes', 'opportunities', 'opportunities-pipeline
        /// products', 'stages', 'users'
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets title is a string that represents the `content`
        /// entity.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

    }
}
