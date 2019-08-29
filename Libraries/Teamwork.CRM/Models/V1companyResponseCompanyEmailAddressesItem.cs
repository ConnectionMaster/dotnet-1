// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Teamwork.CRM.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class V1companyResponseCompanyEmailAddressesItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// V1companyResponseCompanyEmailAddressesItem class.
        /// </summary>
        public V1companyResponseCompanyEmailAddressesItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// V1companyResponseCompanyEmailAddressesItem class.
        /// </summary>
        /// <param name="isMain">One element in the array must have this set to
        /// true.</param>
        public V1companyResponseCompanyEmailAddressesItem(string address = default(string), bool? isMain = default(bool?))
        {
            Address = address;
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
        /// Gets or sets one element in the array must have this set to true.
        /// </summary>
        [JsonProperty(PropertyName = "isMain")]
        public bool? IsMain { get; set; }

    }
}
