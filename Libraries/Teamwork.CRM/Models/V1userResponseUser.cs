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
    /// User
    /// </summary>
    /// <remarks>
    /// User represents a user in the CRM system.
    /// </remarks>
    public partial class V1userResponseUser
    {
        /// <summary>
        /// Initializes a new instance of the V1userResponseUser class.
        /// </summary>
        public V1userResponseUser()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1userResponseUser class.
        /// </summary>
        /// <param name="avatar">ResourceIdentifier</param>
        /// <param name="createdBy">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        /// <param name="deletedBy">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        /// <param name="state">State of the user.</param>
        /// <param name="timezone">ResourceIdentifier</param>
        /// <param name="updatedBy">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        public V1userResponseUser(V1userResponseUserAvatar avatar = default(V1userResponseUserAvatar), System.DateTime? createdAt = default(System.DateTime?), V1userResponseUserCreatedBy createdBy = default(V1userResponseUserCreatedBy), System.DateTime? deletedAt = default(System.DateTime?), V1userResponseUserDeletedBy deletedBy = default(V1userResponseUserDeletedBy), IList<V1userResponseUserEmailAddressesItem> emailAddresses = default(IList<V1userResponseUserEmailAddressesItem>), string firstName = default(string), int? id = default(int?), bool? isAdmin = default(bool?), bool? isGlobalAdmin = default(bool?), bool? isProjectsContact = default(bool?), string lastName = default(string), IList<V1userResponseUserPhoneNumbersItem> phoneNumbers = default(IList<V1userResponseUserPhoneNumbersItem>), int? state = default(int?), V1userResponseUserTimezone timezone = default(V1userResponseUserTimezone), string title = default(string), System.DateTime? updatedAt = default(System.DateTime?), V1userResponseUserUpdatedBy updatedBy = default(V1userResponseUserUpdatedBy), int? updatedSourceId = default(int?))
        {
            Avatar = avatar;
            CreatedAt = createdAt;
            CreatedBy = createdBy;
            DeletedAt = deletedAt;
            DeletedBy = deletedBy;
            EmailAddresses = emailAddresses;
            FirstName = firstName;
            Id = id;
            IsAdmin = isAdmin;
            IsGlobalAdmin = isGlobalAdmin;
            IsProjectsContact = isProjectsContact;
            LastName = lastName;
            PhoneNumbers = phoneNumbers;
            State = state;
            Timezone = timezone;
            Title = title;
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
        /// Gets or sets resourceIdentifier
        /// </summary>
        /// <remarks>
        /// ResourceIdentifier identifies a relationship resource.
        /// </remarks>
        [JsonProperty(PropertyName = "avatar")]
        public V1userResponseUserAvatar Avatar { get; set; }

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
        public V1userResponseUserCreatedBy CreatedBy { get; set; }

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
        public V1userResponseUserDeletedBy DeletedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailAddresses")]
        public IList<V1userResponseUserEmailAddressesItem> EmailAddresses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isAdmin")]
        public bool? IsAdmin { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isGlobalAdmin")]
        public bool? IsGlobalAdmin { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isProjectsContact")]
        public bool? IsProjectsContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "phoneNumbers")]
        public IList<V1userResponseUserPhoneNumbersItem> PhoneNumbers { get; set; }

        /// <summary>
        /// Gets or sets state of the user.
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public int? State { get; set; }

        /// <summary>
        /// Gets or sets resourceIdentifier
        /// </summary>
        /// <remarks>
        /// ResourceIdentifier identifies a relationship resource.
        /// </remarks>
        [JsonProperty(PropertyName = "timezone")]
        public V1userResponseUserTimezone Timezone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

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
        public V1userResponseUserUpdatedBy UpdatedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "updatedSourceId")]
        public int? UpdatedSourceId { get; set; }

    }
}