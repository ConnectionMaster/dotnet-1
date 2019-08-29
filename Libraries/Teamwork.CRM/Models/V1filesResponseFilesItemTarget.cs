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
    /// [Resource identifier
    /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
    /// which describes a relationship to another entity.
    /// </summary>
    public partial class V1filesResponseFilesItemTarget
    {
        /// <summary>
        /// Initializes a new instance of the V1filesResponseFilesItemTarget
        /// class.
        /// </summary>
        public V1filesResponseFilesItemTarget()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1filesResponseFilesItemTarget
        /// class.
        /// </summary>
        /// <param name="id">The id related entity.</param>
        /// <param name="type">The type of the related entity, e.g
        /// "users".</param>
        public V1filesResponseFilesItemTarget(int? id = default(int?), string type = default(string))
        {
            Id = id;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the id related entity.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets the type of the related entity, e.g "users".
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
