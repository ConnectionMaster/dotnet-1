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

    public partial class V1patchActivityRequestActivity
    {
        /// <summary>
        /// Initializes a new instance of the V1patchActivityRequestActivity
        /// class.
        /// </summary>
        public V1patchActivityRequestActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1patchActivityRequestActivity
        /// class.
        /// </summary>
        /// <param name="activityType">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        /// <param name="assignees">[To-many relationship
        /// array](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#to-many-relationships)
        /// which describes a list of resource identifier objects.</param>
        /// <param name="contacts">[To-many relationship
        /// array](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#to-many-relationships)
        /// which describes a list of resource identifier objects.</param>
        /// <param name="duration">Duration in minutes of how long the activity
        /// will take to complete.
        /// This combined with the startDate will calculate the
        /// dueDate.</param>
        public V1patchActivityRequestActivity(V1patchActivityRequestActivityActivityType activityType = default(V1patchActivityRequestActivityActivityType), IList<V1patchActivityRequestActivityAssigneesItem> assignees = default(IList<V1patchActivityRequestActivityAssigneesItem>), IList<V1patchActivityRequestActivityContactsItem> contacts = default(IList<V1patchActivityRequestActivityContactsItem>), string description = default(string), int? duration = default(int?), bool? isComplete = default(bool?), System.DateTime? startDate = default(System.DateTime?), string title = default(string))
        {
            ActivityType = activityType;
            Assignees = assignees;
            Contacts = contacts;
            Description = description;
            Duration = duration;
            IsComplete = isComplete;
            StartDate = startDate;
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
        [JsonProperty(PropertyName = "activityType")]
        public V1patchActivityRequestActivityActivityType ActivityType { get; set; }

        /// <summary>
        /// Gets or sets [To-many relationship
        /// array](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#to-many-relationships)
        /// which describes a list of resource identifier objects.
        /// </summary>
        [JsonProperty(PropertyName = "assignees")]
        public IList<V1patchActivityRequestActivityAssigneesItem> Assignees { get; set; }

        /// <summary>
        /// Gets or sets [To-many relationship
        /// array](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#to-many-relationships)
        /// which describes a list of resource identifier objects.
        /// </summary>
        [JsonProperty(PropertyName = "contacts")]
        public IList<V1patchActivityRequestActivityContactsItem> Contacts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets duration in minutes of how long the activity will take
        /// to complete.
        /// This combined with the startDate will calculate the dueDate.
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public int? Duration { get; set; }

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

    }
}
