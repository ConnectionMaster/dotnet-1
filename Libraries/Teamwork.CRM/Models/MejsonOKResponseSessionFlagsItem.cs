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
    /// Flag
    /// </summary>
    /// <remarks>
    /// Flag drives new behaviour and enables feature driven development
    /// </remarks>
    public partial class MejsonOKResponseSessionFlagsItem
    {
        /// <summary>
        /// Initializes a new instance of the MejsonOKResponseSessionFlagsItem
        /// class.
        /// </summary>
        public MejsonOKResponseSessionFlagsItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MejsonOKResponseSessionFlagsItem
        /// class.
        /// </summary>
        public MejsonOKResponseSessionFlagsItem(string key = default(string))
        {
            Key = key;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

    }
}
