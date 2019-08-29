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

    public partial class V1patchDealRequestDeal
    {
        /// <summary>
        /// Initializes a new instance of the V1patchDealRequestDeal class.
        /// </summary>
        public V1patchDealRequestDeal()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1patchDealRequestDeal class.
        /// </summary>
        /// <param name="company">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        /// <param name="contacts">Contacts related to the deal.
        /// See the meta description for usage of isMain property and
        /// [Resource objects/entity
        /// models](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// for more details on relationships.</param>
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
        /// <param name="lostReason">[Resource identifier
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
        /// <param name="stage">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        /// <param name="state">Possible values include: 'open', 'lost',
        /// 'won'</param>
        public V1patchDealRequestDeal(System.DateTime? closedAt = default(System.DateTime?), V1patchDealRequestDealCompany company = default(V1patchDealRequestDealCompany), IList<V1patchDealRequestDealContactsItem> contacts = default(IList<V1patchDealRequestDealContactsItem>), V1patchDealRequestDealCurrency currency = default(V1patchDealRequestDealCurrency), object custom = default(object), int? customValue = default(int?), System.DateTime? expectedCloseDate = default(System.DateTime?), V1patchDealRequestDealLostReason lostReason = default(V1patchDealRequestDealLostReason), V1patchDealRequestDealOwner owner = default(V1patchDealRequestDealOwner), IList<V1patchDealRequestDealProductsItem> products = default(IList<V1patchDealRequestDealProductsItem>), V1patchDealRequestDealStage stage = default(V1patchDealRequestDealStage), string state = default(string), V1patchDealRequestDealTeamworkProjects teamworkProjects = default(V1patchDealRequestDealTeamworkProjects), string title = default(string))
        {
            ClosedAt = closedAt;
            Company = company;
            Contacts = contacts;
            Currency = currency;
            Custom = custom;
            CustomValue = customValue;
            ExpectedCloseDate = expectedCloseDate;
            LostReason = lostReason;
            Owner = owner;
            Products = products;
            Stage = stage;
            State = state;
            TeamworkProjects = teamworkProjects;
            Title = title;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "closedAt")]
        public System.DateTime? ClosedAt { get; set; }

        /// <summary>
        /// Gets or sets [Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.
        /// </summary>
        [JsonProperty(PropertyName = "company")]
        public V1patchDealRequestDealCompany Company { get; set; }

        /// <summary>
        /// Gets or sets contacts related to the deal.
        /// See the meta description for usage of isMain property and
        /// [Resource objects/entity
        /// models](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// for more details on relationships.
        /// </summary>
        [JsonProperty(PropertyName = "contacts")]
        public IList<V1patchDealRequestDealContactsItem> Contacts { get; set; }

        /// <summary>
        /// Gets or sets [Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.
        /// </summary>
        [JsonProperty(PropertyName = "currency")]
        public V1patchDealRequestDealCurrency Currency { get; set; }

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
        [JsonProperty(PropertyName = "expectedCloseDate")]
        public System.DateTime? ExpectedCloseDate { get; set; }

        /// <summary>
        /// Gets or sets [Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.
        /// </summary>
        [JsonProperty(PropertyName = "lostReason")]
        public V1patchDealRequestDealLostReason LostReason { get; set; }

        /// <summary>
        /// Gets or sets [Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.
        /// </summary>
        [JsonProperty(PropertyName = "owner")]
        public V1patchDealRequestDealOwner Owner { get; set; }

        /// <summary>
        /// Gets or sets products related to the deal and their prices, no
        /// duplicates allowed.
        /// See the meta description for more info on price and
        /// [Resource objects/entity
        /// models](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// for more details on relationships.
        /// </summary>
        [JsonProperty(PropertyName = "products")]
        public IList<V1patchDealRequestDealProductsItem> Products { get; set; }

        /// <summary>
        /// Gets or sets [Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.
        /// </summary>
        [JsonProperty(PropertyName = "stage")]
        public V1patchDealRequestDealStage Stage { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'open', 'lost', 'won'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "teamworkProjects")]
        public V1patchDealRequestDealTeamworkProjects TeamworkProjects { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

    }
}