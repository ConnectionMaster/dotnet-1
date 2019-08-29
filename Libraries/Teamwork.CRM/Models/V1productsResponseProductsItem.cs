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
    /// Product
    /// </summary>
    /// <remarks>
    /// Product represents a product in the CRM system.
    /// </remarks>
    public partial class V1productsResponseProductsItem
    {
        /// <summary>
        /// Initializes a new instance of the V1productsResponseProductsItem
        /// class.
        /// </summary>
        public V1productsResponseProductsItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1productsResponseProductsItem
        /// class.
        /// </summary>
        /// <param name="avatar">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        /// <param name="createdBy">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        /// <param name="deletedBy">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        /// <param name="owner">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        /// <param name="prices">Prices related to the product.
        /// [Resource objects/entity
        /// models](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// for more details on relationships.</param>
        /// <param name="state">State of the product. Possible values include:
        /// 'active', 'inactive'</param>
        /// <param name="updatedBy">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        public V1productsResponseProductsItem(V1productsResponseProductsItemAvatar avatar = default(V1productsResponseProductsItemAvatar), System.DateTime? createdAt = default(System.DateTime?), V1productsResponseProductsItemCreatedBy createdBy = default(V1productsResponseProductsItemCreatedBy), System.DateTime? deletedAt = default(System.DateTime?), V1productsResponseProductsItemDeletedBy deletedBy = default(V1productsResponseProductsItemDeletedBy), int? id = default(int?), string name = default(string), V1productsResponseProductsItemOwner owner = default(V1productsResponseProductsItemOwner), IList<V1productsResponseProductsItemPricesItem> prices = default(IList<V1productsResponseProductsItemPricesItem>), string state = default(string), System.DateTime? updatedAt = default(System.DateTime?), V1productsResponseProductsItemUpdatedBy updatedBy = default(V1productsResponseProductsItemUpdatedBy), int? updatedSourceId = default(int?))
        {
            Avatar = avatar;
            CreatedAt = createdAt;
            CreatedBy = createdBy;
            DeletedAt = deletedAt;
            DeletedBy = deletedBy;
            Id = id;
            Name = name;
            Owner = owner;
            Prices = prices;
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
        /// Gets or sets [Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.
        /// </summary>
        [JsonProperty(PropertyName = "avatar")]
        public V1productsResponseProductsItemAvatar Avatar { get; set; }

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
        public V1productsResponseProductsItemCreatedBy CreatedBy { get; set; }

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
        public V1productsResponseProductsItemDeletedBy DeletedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets [Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.
        /// </summary>
        [JsonProperty(PropertyName = "owner")]
        public V1productsResponseProductsItemOwner Owner { get; set; }

        /// <summary>
        /// Gets or sets prices related to the product.
        /// [Resource objects/entity
        /// models](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// for more details on relationships.
        /// </summary>
        [JsonProperty(PropertyName = "prices")]
        public IList<V1productsResponseProductsItemPricesItem> Prices { get; set; }

        /// <summary>
        /// Gets or sets state of the product. Possible values include:
        /// 'active', 'inactive'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

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
        public V1productsResponseProductsItemUpdatedBy UpdatedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "updatedSourceId")]
        public int? UpdatedSourceId { get; set; }

    }
}
