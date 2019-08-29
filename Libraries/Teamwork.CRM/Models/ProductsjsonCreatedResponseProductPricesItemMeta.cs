// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Teamwork.CRM.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ProductsjsonCreatedResponseProductPricesItemMeta
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ProductsjsonCreatedResponseProductPricesItemMeta class.
        /// </summary>
        public ProductsjsonCreatedResponseProductPricesItemMeta()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ProductsjsonCreatedResponseProductPricesItemMeta class.
        /// </summary>
        /// <param name="price">Price of the product in the same currency as
        /// the deal in its lowest denomination, e.g for USD the value in
        /// cents.</param>
        public ProductsjsonCreatedResponseProductPricesItemMeta(int price)
        {
            Price = price;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets price of the product in the same currency as the deal
        /// in its lowest denomination, e.g for USD the value in cents.
        /// </summary>
        [JsonProperty(PropertyName = "price")]
        public int Price { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
