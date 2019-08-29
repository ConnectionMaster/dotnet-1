// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Teamwork.CRM.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class V1dealResponseDealContactsItem
    {
        /// <summary>
        /// Initializes a new instance of the V1dealResponseDealContactsItem
        /// class.
        /// </summary>
        public V1dealResponseDealContactsItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1dealResponseDealContactsItem
        /// class.
        /// </summary>
        /// <param name="type">Possible values include: 'contacts'</param>
        public V1dealResponseDealContactsItem(int? id = default(int?), V1dealResponseDealContactsItemMeta meta = default(V1dealResponseDealContactsItemMeta), string type = default(string))
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
        public V1dealResponseDealContactsItemMeta Meta { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'contacts'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
