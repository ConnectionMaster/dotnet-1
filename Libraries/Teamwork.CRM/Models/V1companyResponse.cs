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
    /// companyResponse
    /// </summary>
    public partial class V1companyResponse
    {
        /// <summary>
        /// Initializes a new instance of the V1companyResponse class.
        /// </summary>
        public V1companyResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1companyResponse class.
        /// </summary>
        /// <param name="company">Company</param>
        /// <param name="included">Included</param>
        public V1companyResponse(V1companyResponseCompany company = default(V1companyResponseCompany), object included = default(object))
        {
            Company = company;
            Included = included;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets company
        /// </summary>
        /// <remarks>
        /// Company represents a company in the CRM system.
        /// </remarks>
        [JsonProperty(PropertyName = "company")]
        public V1companyResponseCompany Company { get; set; }

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