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
    /// ResourceIdentifier
    /// </summary>
    /// <remarks>
    /// ResourceIdentifier identifies a relationship resource.
    /// </remarks>
    public partial class MejsonOKResponseSessionInstallation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MejsonOKResponseSessionInstallation class.
        /// </summary>
        public MejsonOKResponseSessionInstallation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MejsonOKResponseSessionInstallation class.
        /// </summary>
        public MejsonOKResponseSessionInstallation(int? id = default(int?), object meta = default(object), string type = default(string))
        {
            Id = id;
            Meta = meta;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "meta")]
        public object Meta { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
