// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Teamwork.CRM.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CrmcoreContactPhoneNumbers
    {
        /// <summary>
        /// Initializes a new instance of the CrmcoreContactPhoneNumbers class.
        /// </summary>
        public CrmcoreContactPhoneNumbers()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CrmcoreContactPhoneNumbers class.
        /// </summary>
        /// <param name="code">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// linking a phone code to this number.</param>
        /// <param name="number">The phone number, excluding the country code
        /// (this can be specified with `code`).</param>
        public CrmcoreContactPhoneNumbers(CrmcoreContactPhoneNumbersCode code = default(CrmcoreContactPhoneNumbersCode), string number = default(string))
        {
            Code = code;
            Number = number;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets [Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// linking a phone code to this number.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public CrmcoreContactPhoneNumbersCode Code { get; set; }

        /// <summary>
        /// Gets or sets the phone number, excluding the country code (this can
        /// be specified with `code`).
        /// </summary>
        [JsonProperty(PropertyName = "number")]
        public string Number { get; set; }

    }
}
