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
    /// [Resource identifier
    /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
    /// linking a phone code to this number.
    /// </summary>
    public partial class V1contactsResponseContactsItemPhoneNumbersCode
    {
        /// <summary>
        /// Initializes a new instance of the
        /// V1contactsResponseContactsItemPhoneNumbersCode class.
        /// </summary>
        public V1contactsResponseContactsItemPhoneNumbersCode()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// V1contactsResponseContactsItemPhoneNumbersCode class.
        /// </summary>
        /// <param name="type">Possible values include: 'phone-codes'</param>
        public V1contactsResponseContactsItemPhoneNumbersCode(int? id = default(int?), string type = default(string))
        {
            Id = id;
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
        /// Gets or sets possible values include: 'phone-codes'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
