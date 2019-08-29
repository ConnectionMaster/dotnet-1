// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Teamwork.CRM.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class IdjsonOKResponseDealContactsItem
    {
        /// <summary>
        /// Initializes a new instance of the IdjsonOKResponseDealContactsItem
        /// class.
        /// </summary>
        public IdjsonOKResponseDealContactsItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IdjsonOKResponseDealContactsItem
        /// class.
        /// </summary>
        /// <param name="type">Possible values include: 'contacts'</param>
        public IdjsonOKResponseDealContactsItem(int? id = default(int?), IdjsonOKResponseDealContactsItemMeta meta = default(IdjsonOKResponseDealContactsItemMeta), string type = default(string))
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
        public IdjsonOKResponseDealContactsItemMeta Meta { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'contacts'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
