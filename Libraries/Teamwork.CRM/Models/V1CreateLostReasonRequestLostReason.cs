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
    /// CreateLostReason
    /// </summary>
    /// <remarks>
    /// CreateLostReason is part of the content of the request body for a POST.
    /// </remarks>
    public partial class V1CreateLostReasonRequestLostReason
    {
        /// <summary>
        /// Initializes a new instance of the
        /// V1CreateLostReasonRequestLostReason class.
        /// </summary>
        public V1CreateLostReasonRequestLostReason()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// V1CreateLostReasonRequestLostReason class.
        /// </summary>
        public V1CreateLostReasonRequestLostReason(string kind = default(string), string name = default(string))
        {
            Kind = kind;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
