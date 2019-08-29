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
    /// PatchLostReasonRequest
    /// </summary>
    /// <remarks>
    /// PatchLostReasonRequest represents request body for a PATCH
    /// </remarks>
    public partial class V1PatchLostReasonRequest
    {
        /// <summary>
        /// Initializes a new instance of the V1PatchLostReasonRequest class.
        /// </summary>
        public V1PatchLostReasonRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1PatchLostReasonRequest class.
        /// </summary>
        /// <param name="lostReason">PatchLostReason</param>
        public V1PatchLostReasonRequest(V1PatchLostReasonRequestLostReason lostReason = default(V1PatchLostReasonRequestLostReason))
        {
            LostReason = lostReason;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets patchLostReason
        /// </summary>
        /// <remarks>
        /// PatchLostReason is part of the content of the request body for a
        /// PATCH.
        /// </remarks>
        [JsonProperty(PropertyName = "lostReason")]
        public V1PatchLostReasonRequestLostReason LostReason { get; set; }

    }
}