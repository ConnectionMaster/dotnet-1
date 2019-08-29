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
    /// Deal
    /// </summary>
    /// <remarks>
    /// Deal represents a deal in the CRM system.
    /// </remarks>
    public partial class V1dealsResponseDealsItem
    {
        /// <summary>
        /// Initializes a new instance of the V1dealsResponseDealsItem class.
        /// </summary>
        public V1dealsResponseDealsItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1dealsResponseDealsItem class.
        /// </summary>
        /// <param name="closedAt">Date the deal was closed (state:
        /// won/lost).</param>
        /// <param name="company">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        /// <param name="contacts">Contacts related to the deal.
        /// See the meta description for usage of isMain property and
        /// [Resource objects/entity
        /// models](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// for more details on relationships.</param>
        /// <param name="createdBy">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        /// <param name="currency">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        /// <param name="custom">Custom fields of the entity, which properties
        /// are accepted in here will depend
        /// on your settings. For more information see
        /// [dealing with custom
        /// fields](https://crmdev-teamwork.docs.stoplight.io/documentation/miscellaneous/custom-fields).</param>
        /// <param name="customValue">Custom value of the deal, this is
        /// combined with the products prices to
        /// calculate the totalValue of the deal.</param>
        /// <param name="deletedBy">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        /// <param name="isQualified">Qualified is true if the deal is linked
        /// to a stage whose pipeline has
        /// the isQualified attribute set to true.</param>
        /// <param name="lostReason">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        /// <param name="nextIncompleteActivity">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        /// <param name="owner">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        /// <param name="products">Products related to the deal and their
        /// prices, no duplicates allowed.
        /// See the meta description for more info on price and
        /// [Resource objects/entity
        /// models](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// for more details on relationships.</param>
        /// <param name="qualifiedBy">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        /// <param name="stage">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        /// <param name="state">State of the deal. Possible values include:
        /// 'open', 'lost', 'won'</param>
        /// <param name="teamworkProjects">Data relating to [Teamwork
        /// Projects](https://www.teamwork.com/project-management-software/)
        /// integrations.</param>
        /// <param name="totalValue">Total value of the deal in your currency.
        /// This is the customValue of
        /// the deal plus the sum of all its products prices.</param>
        /// <param name="updatedBy">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        public V1dealsResponseDealsItem(System.DateTime? closedAt = default(System.DateTime?), V1dealsResponseDealsItemCompany company = default(V1dealsResponseDealsItemCompany), IList<V1dealsResponseDealsItemContactsItem> contacts = default(IList<V1dealsResponseDealsItemContactsItem>), int? contactsCount = default(int?), System.DateTime? createdAt = default(System.DateTime?), V1dealsResponseDealsItemCreatedBy createdBy = default(V1dealsResponseDealsItemCreatedBy), V1dealsResponseDealsItemCurrency currency = default(V1dealsResponseDealsItemCurrency), object custom = default(object), int? customValue = default(int?), System.DateTime? deletedAt = default(System.DateTime?), V1dealsResponseDealsItemDeletedBy deletedBy = default(V1dealsResponseDealsItemDeletedBy), System.DateTime? expectedCloseDate = default(System.DateTime?), int? id = default(int?), bool? isQualified = default(bool?), V1dealsResponseDealsItemLostReason lostReason = default(V1dealsResponseDealsItemLostReason), V1dealsResponseDealsItemNextIncompleteActivity nextIncompleteActivity = default(V1dealsResponseDealsItemNextIncompleteActivity), V1dealsResponseDealsItemOwner owner = default(V1dealsResponseDealsItemOwner), IList<V1dealsResponseDealsItemProductsItem> products = default(IList<V1dealsResponseDealsItemProductsItem>), System.DateTime? qualifiedAt = default(System.DateTime?), V1dealsResponseDealsItemQualifiedBy qualifiedBy = default(V1dealsResponseDealsItemQualifiedBy), V1dealsResponseDealsItemStage stage = default(V1dealsResponseDealsItemStage), string state = default(string), object teamworkProjects = default(object), string title = default(string), int? totalValue = default(int?), System.DateTime? updatedAt = default(System.DateTime?), V1dealsResponseDealsItemUpdatedBy updatedBy = default(V1dealsResponseDealsItemUpdatedBy), int? updatedSourceId = default(int?))
        {
            ClosedAt = closedAt;
            Company = company;
            Contacts = contacts;
            ContactsCount = contactsCount;
            CreatedAt = createdAt;
            CreatedBy = createdBy;
            Currency = currency;
            Custom = custom;
            CustomValue = customValue;
            DeletedAt = deletedAt;
            DeletedBy = deletedBy;
            ExpectedCloseDate = expectedCloseDate;
            Id = id;
            IsQualified = isQualified;
            LostReason = lostReason;
            NextIncompleteActivity = nextIncompleteActivity;
            Owner = owner;
            Products = products;
            QualifiedAt = qualifiedAt;
            QualifiedBy = qualifiedBy;
            Stage = stage;
            State = state;
            TeamworkProjects = teamworkProjects;
            Title = title;
            TotalValue = totalValue;
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
        /// Gets or sets date the deal was closed (state: won/lost).
        /// </summary>
        [JsonProperty(PropertyName = "closedAt")]
        public System.DateTime? ClosedAt { get; set; }

        /// <summary>
        /// Gets or sets [Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.
        /// </summary>
        [JsonProperty(PropertyName = "company")]
        public V1dealsResponseDealsItemCompany Company { get; set; }

        /// <summary>
        /// Gets or sets contacts related to the deal.
        /// See the meta description for usage of isMain property and
        /// [Resource objects/entity
        /// models](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// for more details on relationships.
        /// </summary>
        [JsonProperty(PropertyName = "contacts")]
        public IList<V1dealsResponseDealsItemContactsItem> Contacts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactsCount")]
        public int? ContactsCount { get; set; }

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
        public V1dealsResponseDealsItemCreatedBy CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets [Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.
        /// </summary>
        [JsonProperty(PropertyName = "currency")]
        public V1dealsResponseDealsItemCurrency Currency { get; set; }

        /// <summary>
        /// Gets or sets custom fields of the entity, which properties are
        /// accepted in here will depend
        /// on your settings. For more information see
        /// [dealing with custom
        /// fields](https://crmdev-teamwork.docs.stoplight.io/documentation/miscellaneous/custom-fields).
        /// </summary>
        [JsonProperty(PropertyName = "custom")]
        public object Custom { get; set; }

        /// <summary>
        /// Gets or sets custom value of the deal, this is combined with the
        /// products prices to
        /// calculate the totalValue of the deal.
        /// </summary>
        [JsonProperty(PropertyName = "customValue")]
        public int? CustomValue { get; set; }

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
        public V1dealsResponseDealsItemDeletedBy DeletedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "expectedCloseDate")]
        public System.DateTime? ExpectedCloseDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets qualified is true if the deal is linked to a stage
        /// whose pipeline has
        /// the isQualified attribute set to true.
        /// </summary>
        [JsonProperty(PropertyName = "isQualified")]
        public bool? IsQualified { get; set; }

        /// <summary>
        /// Gets or sets [Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.
        /// </summary>
        [JsonProperty(PropertyName = "lostReason")]
        public V1dealsResponseDealsItemLostReason LostReason { get; set; }

        /// <summary>
        /// Gets or sets [Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.
        /// </summary>
        [JsonProperty(PropertyName = "nextIncompleteActivity")]
        public V1dealsResponseDealsItemNextIncompleteActivity NextIncompleteActivity { get; set; }

        /// <summary>
        /// Gets or sets [Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.
        /// </summary>
        [JsonProperty(PropertyName = "owner")]
        public V1dealsResponseDealsItemOwner Owner { get; set; }

        /// <summary>
        /// Gets or sets products related to the deal and their prices, no
        /// duplicates allowed.
        /// See the meta description for more info on price and
        /// [Resource objects/entity
        /// models](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// for more details on relationships.
        /// </summary>
        [JsonProperty(PropertyName = "products")]
        public IList<V1dealsResponseDealsItemProductsItem> Products { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "qualifiedAt")]
        public System.DateTime? QualifiedAt { get; set; }

        /// <summary>
        /// Gets or sets [Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.
        /// </summary>
        [JsonProperty(PropertyName = "qualifiedBy")]
        public V1dealsResponseDealsItemQualifiedBy QualifiedBy { get; set; }

        /// <summary>
        /// Gets or sets [Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.
        /// </summary>
        [JsonProperty(PropertyName = "stage")]
        public V1dealsResponseDealsItemStage Stage { get; set; }

        /// <summary>
        /// Gets or sets state of the deal. Possible values include: 'open',
        /// 'lost', 'won'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets data relating to [Teamwork
        /// Projects](https://www.teamwork.com/project-management-software/)
        /// integrations.
        /// </summary>
        [JsonProperty(PropertyName = "teamworkProjects")]
        public object TeamworkProjects { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets total value of the deal in your currency. This is the
        /// customValue of
        /// the deal plus the sum of all its products prices.
        /// </summary>
        [JsonProperty(PropertyName = "totalValue")]
        public int? TotalValue { get; set; }

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
        public V1dealsResponseDealsItemUpdatedBy UpdatedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "updatedSourceId")]
        public int? UpdatedSourceId { get; set; }

    }
}
