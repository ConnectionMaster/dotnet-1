// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Teamwork.CRM.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class V1createExportRequestExport
    {
        /// <summary>
        /// Initializes a new instance of the V1createExportRequestExport
        /// class.
        /// </summary>
        public V1createExportRequestExport()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1createExportRequestExport
        /// class.
        /// </summary>
        public V1createExportRequestExport(string kind = default(string))
        {
            Kind = kind;
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

    }
}
