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
    /// Activity
    /// </summary>
    /// <remarks>
    /// Activity represents an activity in the CRM system.
    /// </remarks>
    public partial class V1activityResponseActivity
    {
        /// <summary>
        /// Initializes a new instance of the V1activityResponseActivity class.
        /// </summary>
        public V1activityResponseActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1activityResponseActivity class.
        /// </summary>
        /// <param name="activityType">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        /// <param name="assignees">[To-many relationship
        /// array](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#to-many-relationships)
        /// which describes a list of resource identifier objects.</param>
        /// <param name="assigneesCount">Number of users assigned to the
        /// activity.</param>
        /// <param name="completedByUser">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        /// <param name="contacts">[To-many relationship
        /// array](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#to-many-relationships)
        /// which describes a list of resource identifier objects.</param>
        /// <param name="contactsCount">Number of contacts connected to the
        /// activity.</param>
        /// <param name="createdBy">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        /// <param name="custom">Custom fields of the entity, which properties
        /// are accepted in here will depend
        /// on your settings. For more information see
        /// [dealing with custom
        /// fields](https://crmdev-teamwork.docs.stoplight.io/documentation/miscellaneous/custom-fields).</param>
        /// <param name="deal">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        /// <param name="deletedBy">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        /// <param name="dueDate">The duration added to the startDate.</param>
        /// <param name="duration">Duration in minutes of how long the activity
        /// will take to complete.</param>
        /// <param name="updatedBy">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        public V1activityResponseActivity(V1activityResponseActivityActivityType activityType = default(V1activityResponseActivityActivityType), IList<V1activityResponseActivityAssigneesItem> assignees = default(IList<V1activityResponseActivityAssigneesItem>), int? assigneesCount = default(int?), System.DateTime? completedAt = default(System.DateTime?), V1activityResponseActivityCompletedByUser completedByUser = default(V1activityResponseActivityCompletedByUser), IList<V1activityResponseActivityContactsItem> contacts = default(IList<V1activityResponseActivityContactsItem>), int? contactsCount = default(int?), System.DateTime? createdAt = default(System.DateTime?), V1activityResponseActivityCreatedBy createdBy = default(V1activityResponseActivityCreatedBy), object custom = default(object), V1activityResponseActivityDeal deal = default(V1activityResponseActivityDeal), System.DateTime? deletedAt = default(System.DateTime?), V1activityResponseActivityDeletedBy deletedBy = default(V1activityResponseActivityDeletedBy), string description = default(string), System.DateTime? dueDate = default(System.DateTime?), int? duration = default(int?), int? id = default(int?), bool? isComplete = default(bool?), System.DateTime? startDate = default(System.DateTime?), string title = default(string), System.DateTime? updatedAt = default(System.DateTime?), V1activityResponseActivityUpdatedBy updatedBy = default(V1activityResponseActivityUpdatedBy), int? updatedSourceId = default(int?))
        {
            ActivityType = activityType;
            Assignees = assignees;
            AssigneesCount = assigneesCount;
            CompletedAt = completedAt;
            CompletedByUser = completedByUser;
            Contacts = contacts;
            ContactsCount = contactsCount;
            CreatedAt = createdAt;
            CreatedBy = createdBy;
            Custom = custom;
            Deal = deal;
            DeletedAt = deletedAt;
            DeletedBy = deletedBy;
            Description = description;
            DueDate = dueDate;
            Duration = duration;
            Id = id;
            IsComplete = isComplete;
            StartDate = startDate;
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
        /// Gets or sets [Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.
        /// </summary>
        [JsonProperty(PropertyName = "activityType")]
        public V1activityResponseActivityActivityType ActivityType { get; set; }

        /// <summary>
        /// Gets or sets [To-many relationship
        /// array](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#to-many-relationships)
        /// which describes a list of resource identifier objects.
        /// </summary>
        [JsonProperty(PropertyName = "assignees")]
        public IList<V1activityResponseActivityAssigneesItem> Assignees { get; set; }

        /// <summary>
        /// Gets or sets number of users assigned to the activity.
        /// </summary>
        [JsonProperty(PropertyName = "assigneesCount")]
        public int? AssigneesCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "completedAt")]
        public System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Gets or sets [Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.
        /// </summary>
        [JsonProperty(PropertyName = "completedByUser")]
        public V1activityResponseActivityCompletedByUser CompletedByUser { get; set; }

        /// <summary>
        /// Gets or sets [To-many relationship
        /// array](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#to-many-relationships)
        /// which describes a list of resource identifier objects.
        /// </summary>
        [JsonProperty(PropertyName = "contacts")]
        public IList<V1activityResponseActivityContactsItem> Contacts { get; set; }

        /// <summary>
        /// Gets or sets number of contacts connected to the activity.
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
        public V1activityResponseActivityCreatedBy CreatedBy { get; set; }

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
        /// Gets or sets [Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.
        /// </summary>
        [JsonProperty(PropertyName = "deal")]
        public V1activityResponseActivityDeal Deal { get; set; }

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
        public V1activityResponseActivityDeletedBy DeletedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the duration added to the startDate.
        /// </summary>
        [JsonProperty(PropertyName = "dueDate")]
        public System.DateTime? DueDate { get; set; }

        /// <summary>
        /// Gets or sets duration in minutes of how long the activity will take
        /// to complete.
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isComplete")]
        public bool? IsComplete { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "startDate")]
        public System.DateTime? StartDate { get; set; }

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
        public V1activityResponseActivityUpdatedBy UpdatedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "updatedSourceId")]
        public int? UpdatedSourceId { get; set; }

    }
}
