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
    /// contactResponse
    /// </summary>
    public partial class IdjsonOKResponseModelModelModel
    {
        /// <summary>
        /// Initializes a new instance of the IdjsonOKResponseModelModelModel
        /// class.
        /// </summary>
        public IdjsonOKResponseModelModelModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IdjsonOKResponseModelModelModel
        /// class.
        /// </summary>
        /// <param name="contact">Contact</param>
        /// <param name="included">Included</param>
        public IdjsonOKResponseModelModelModel(IdjsonOKResponseContact contact = default(IdjsonOKResponseContact), object included = default(object))
        {
            Contact = contact;
            Included = included;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets contact
        /// </summary>
        /// <remarks>
        /// Contact represents a contact in the CRM system.
        /// </remarks>
        [JsonProperty(PropertyName = "contact")]
        public IdjsonOKResponseContact Contact { get; set; }

        /// <summary>
        /// Gets or sets included
        /// </summary>
        /// <remarks>
        /// Included contains all the side-loaded data of a response.
        /// See [including related
        /// entities](https://crmdev-teamwork.docs.stoplight.io/documentation/general/related-entities).
        /// </remarks>
        [JsonProperty(PropertyName = "included")]
        public object Included { get; set; }

    }
}