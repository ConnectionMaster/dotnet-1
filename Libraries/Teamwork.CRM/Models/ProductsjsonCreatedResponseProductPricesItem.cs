// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Teamwork.CRM.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ProductsjsonCreatedResponseProductPricesItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ProductsjsonCreatedResponseProductPricesItem class.
        /// </summary>
        public ProductsjsonCreatedResponseProductPricesItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ProductsjsonCreatedResponseProductPricesItem class.
        /// </summary>
        /// <param name="type">Possible values include: 'currencies'</param>
        public ProductsjsonCreatedResponseProductPricesItem(int? id = default(int?), ProductsjsonCreatedResponseProductPricesItemMeta meta = default(ProductsjsonCreatedResponseProductPricesItemMeta), string type = default(string))
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
        public ProductsjsonCreatedResponseProductPricesItemMeta Meta { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'currencies'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Meta != null)
            {
                Meta.Validate();
            }
        }
    }
}
