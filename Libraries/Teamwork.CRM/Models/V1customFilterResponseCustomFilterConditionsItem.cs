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
    /// CustomFilterCondition
    /// </summary>
    /// <remarks>
    /// CustomFilterCondition represents an stored twapi.filter in the db
    /// </remarks>
    public partial class V1customFilterResponseCustomFilterConditionsItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// V1customFilterResponseCustomFilterConditionsItem class.
        /// </summary>
        public V1customFilterResponseCustomFilterConditionsItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// V1customFilterResponseCustomFilterConditionsItem class.
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
        public V1customFilterResponseCustomFilterConditionsItem(string alias = default(string), System.DateTime? createdAt = default(System.DateTime?), V1customFilterResponseCustomFilterConditionsItemCreatedBy createdBy = default(V1customFilterResponseCustomFilterConditionsItemCreatedBy), System.DateTime? deletedAt = default(System.DateTime?), V1customFilterResponseCustomFilterConditionsItemDeletedBy deletedBy = default(V1customFilterResponseCustomFilterConditionsItemDeletedBy), string operatorProperty = default(string), string target = default(string), System.DateTime? updatedAt = default(System.DateTime?), V1customFilterResponseCustomFilterConditionsItemUpdatedBy updatedBy = default(V1customFilterResponseCustomFilterConditionsItemUpdatedBy), int? updatedSourceId = default(int?), string value = default(string))
        {
            Alias = alias;
            CreatedAt = createdAt;
            CreatedBy = createdBy;
            DeletedAt = deletedAt;
            DeletedBy = deletedBy;
            OperatorProperty = operatorProperty;
            Target = target;
            UpdatedAt = updatedAt;
            UpdatedBy = updatedBy;
            UpdatedSourceId = updatedSourceId;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "alias")]
        public string Alias { get; set; }

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
        public V1customFilterResponseCustomFilterConditionsItemCreatedBy CreatedBy { get; set; }

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
        public V1customFilterResponseCustomFilterConditionsItemDeletedBy DeletedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "operator")]
        public string OperatorProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public string Target { get; set; }

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
        public V1customFilterResponseCustomFilterConditionsItemUpdatedBy UpdatedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "updatedSourceId")]
        public int? UpdatedSourceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}
