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
    /// activityTypeResponse
    /// </summary>
    public partial class IdjsonOKResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the IdjsonOKResponseModel class.
        /// </summary>
        public IdjsonOKResponseModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IdjsonOKResponseModel class.
        /// </summary>
        /// <param name="activityType">ActivityType</param>
        public IdjsonOKResponseModel(IdjsonOKResponseActivityType activityType = default(IdjsonOKResponseActivityType))
        {
            ActivityType = activityType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets activityType
        /// </summary>
        /// <remarks>
        /// ActivityType represents an activity type in the CRM system.
        /// </remarks>
        [JsonProperty(PropertyName = "activityType")]
        public IdjsonOKResponseActivityType ActivityType { get; set; }

    }
}