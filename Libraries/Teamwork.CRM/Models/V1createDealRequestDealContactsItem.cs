// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Teamwork.CRM.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class V1createDealRequestDealContactsItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// V1createDealRequestDealContactsItem class.
        /// </summary>
        public V1createDealRequestDealContactsItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// V1createDealRequestDealContactsItem class.
        /// </summary>
        /// <param name="type">Possible values include: 'contacts'</param>
        public V1createDealRequestDealContactsItem(int? id = default(int?), V1createDealRequestDealContactsItemMeta meta = default(V1createDealRequestDealContactsItemMeta), string type = default(string))
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
        public V1createDealRequestDealContactsItemMeta Meta { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'contacts'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
