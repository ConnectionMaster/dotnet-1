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
    /// Email
    /// </summary>
    /// <remarks>
    /// Email for companies
    /// </remarks>
    public partial class CrmcoreEmail
    {
        /// <summary>
        /// Initializes a new instance of the CrmcoreEmail class.
        /// </summary>
        public CrmcoreEmail()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CrmcoreEmail class.
        /// </summary>
        public CrmcoreEmail(string address = default(string), int? hubId = default(int?), bool? isMain = default(bool?))
        {
            Address = address;
            HubId = hubId;
            IsMain = isMain;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hubId")]
        public int? HubId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isMain")]
        public bool? IsMain { get; set; }

    }
}
