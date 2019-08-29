// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Teamwork.CRM.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class V1patchActivityTypeRequestActivityType
    {
        /// <summary>
        /// Initializes a new instance of the
        /// V1patchActivityTypeRequestActivityType class.
        /// </summary>
        public V1patchActivityTypeRequestActivityType()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// V1patchActivityTypeRequestActivityType class.
        /// </summary>
        /// <param name="icon">Icon of the activity type. Possible values
        /// include: 'clock', 'phone', 'suitcase', 'email', 'event',
        /// 'to-do'</param>
        /// <param name="orderIndex">Position of the activity type in the set
        /// of all enabled types.
        /// Lower numbers come first when retrieving multiple elements at
        /// once.</param>
        public V1patchActivityTypeRequestActivityType(string icon = default(string), bool? isEnabled = default(bool?), string name = default(string), int? orderIndex = default(int?))
        {
            Icon = icon;
            IsEnabled = isEnabled;
            Name = name;
            OrderIndex = orderIndex;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets icon of the activity type. Possible values include:
        /// 'clock', 'phone', 'suitcase', 'email', 'event', 'to-do'
        /// </summary>
        [JsonProperty(PropertyName = "icon")]
        public string Icon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isEnabled")]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets position of the activity type in the set of all
        /// enabled types.
        /// Lower numbers come first when retrieving multiple elements at once.
        /// </summary>
        [JsonProperty(PropertyName = "orderIndex")]
        public int? OrderIndex { get; set; }

    }
}