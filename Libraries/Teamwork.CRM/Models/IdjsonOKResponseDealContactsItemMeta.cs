// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Teamwork.CRM.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class IdjsonOKResponseDealContactsItemMeta
    {
        /// <summary>
        /// Initializes a new instance of the
        /// IdjsonOKResponseDealContactsItemMeta class.
        /// </summary>
        public IdjsonOKResponseDealContactsItemMeta()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// IdjsonOKResponseDealContactsItemMeta class.
        /// </summary>
        /// <param name="isMain">One element in the array must have this set to
        /// true.</param>
        public IdjsonOKResponseDealContactsItemMeta(bool? isMain = default(bool?))
        {
            IsMain = isMain;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets one element in the array must have this set to true.
        /// </summary>
        [JsonProperty(PropertyName = "isMain")]
        public bool? IsMain { get; set; }

    }
}
