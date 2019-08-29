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
    /// CustomField
    /// </summary>
    /// <remarks>
    /// CustomField is a custom field defined by a user.
    /// </remarks>
    public partial class CustomFieldsjsonCreatedResponseCustomField
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CustomFieldsjsonCreatedResponseCustomField class.
        /// </summary>
        public CustomFieldsjsonCreatedResponseCustomField()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CustomFieldsjsonCreatedResponseCustomField class.
        /// </summary>
        /// <param name="createdBy">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        /// <param name="deletedBy">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        /// <param name="fieldType">Type of the of the custom field value.
        /// Possible values include: 'text-short', 'text-long', 'number',
        /// 'select', 'multi-select', 'duration', 'url'</param>
        /// <param name="isMandatory">Mandatory is true if the custom field
        /// must have a value set, when the entity to which the custom field is
        /// assigned to, is created or updated.</param>
        /// <param name="isShownWhenAdding">Shown when adding is true when the
        /// custom field should be shown in the entity's form.</param>
        /// <param name="key">Key is the custom field's identifier used in the
        /// entities responses that include custom fields.</param>
        /// <param name="kind">Kind of entity this custom field is defined for.
        /// Possible values include: 'deals', 'contacts', 'companies'</param>
        /// <param name="options">Options for the custom field with `fieldType`
        /// "select" or "multi-select".</param>
        /// <param name="updatedBy">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        public CustomFieldsjsonCreatedResponseCustomField(System.DateTime? createdAt = default(System.DateTime?), CustomFieldsjsonCreatedResponseCustomFieldCreatedBy createdBy = default(CustomFieldsjsonCreatedResponseCustomFieldCreatedBy), System.DateTime? deletedAt = default(System.DateTime?), CustomFieldsjsonCreatedResponseCustomFieldDeletedBy deletedBy = default(CustomFieldsjsonCreatedResponseCustomFieldDeletedBy), string fieldType = default(string), int? id = default(int?), bool? isMandatory = default(bool?), bool? isShownWhenAdding = default(bool?), string key = default(string), string kind = default(string), string name = default(string), IList<string> options = default(IList<string>), System.DateTime? updatedAt = default(System.DateTime?), CustomFieldsjsonCreatedResponseCustomFieldUpdatedBy updatedBy = default(CustomFieldsjsonCreatedResponseCustomFieldUpdatedBy), int? updatedSourceId = default(int?))
        {
            CreatedAt = createdAt;
            CreatedBy = createdBy;
            DeletedAt = deletedAt;
            DeletedBy = deletedBy;
            FieldType = fieldType;
            Id = id;
            IsMandatory = isMandatory;
            IsShownWhenAdding = isShownWhenAdding;
            Key = key;
            Kind = kind;
            Name = name;
            Options = options;
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
        [JsonProperty(PropertyName = "createdAt")]
        public System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets [Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.
        /// </summary>
        [JsonProperty(PropertyName = "createdBy")]
        public CustomFieldsjsonCreatedResponseCustomFieldCreatedBy CreatedBy { get; set; }

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
        public CustomFieldsjsonCreatedResponseCustomFieldDeletedBy DeletedBy { get; set; }

        /// <summary>
        /// Gets or sets type of the of the custom field value. Possible values
        /// include: 'text-short', 'text-long', 'number', 'select',
        /// 'multi-select', 'duration', 'url'
        /// </summary>
        [JsonProperty(PropertyName = "fieldType")]
        public string FieldType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets mandatory is true if the custom field must have a
        /// value set, when the entity to which the custom field is
        /// assigned to, is created or updated.
        /// </summary>
        [JsonProperty(PropertyName = "isMandatory")]
        public bool? IsMandatory { get; set; }

        /// <summary>
        /// Gets or sets shown when adding is true when the custom field should
        /// be shown in the entity's form.
        /// </summary>
        [JsonProperty(PropertyName = "isShownWhenAdding")]
        public bool? IsShownWhenAdding { get; set; }

        /// <summary>
        /// Gets or sets key is the custom field's identifier used in the
        /// entities responses that include custom fields.
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets kind of entity this custom field is defined for.
        /// Possible values include: 'deals', 'contacts', 'companies'
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets options for the custom field with `fieldType` "select"
        /// or "multi-select".
        /// </summary>
        [JsonProperty(PropertyName = "options")]
        public IList<string> Options { get; set; }

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
        public CustomFieldsjsonCreatedResponseCustomFieldUpdatedBy UpdatedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "updatedSourceId")]
        public int? UpdatedSourceId { get; set; }

    }
}
