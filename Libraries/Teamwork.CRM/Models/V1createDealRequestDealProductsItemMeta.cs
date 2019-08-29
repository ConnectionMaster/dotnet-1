// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Teamwork.CRM.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class V1createDealRequestDealProductsItemMeta
    {
        /// <summary>
        /// Initializes a new instance of the
        /// V1createDealRequestDealProductsItemMeta class.
        /// </summary>
        public V1createDealRequestDealProductsItemMeta()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// V1createDealRequestDealProductsItemMeta class.
        /// </summary>
        /// <param name="price">Price of the product in the same currency as
        /// the deal in its lowest denomination, e.g for USD the value in
        /// cents.</param>
        /// <param name="quantity">Quantity of this product at the price with
        /// discount.</param>
        /// <param name="discount">Discount to apply to the price.</param>
        public V1createDealRequestDealProductsItemMeta(int price, int quantity, double? discount = default(double?))
        {
            Discount = discount;
            Price = price;
            Quantity = quantity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets discount to apply to the price.
        /// </summary>
        [JsonProperty(PropertyName = "discount")]
        public double? Discount { get; set; }

        /// <summary>
        /// Gets or sets price of the product in the same currency as the deal
        /// in its lowest denomination, e.g for USD the value in cents.
        /// </summary>
        [JsonProperty(PropertyName = "price")]
        public int Price { get; set; }

        /// <summary>
        /// Gets or sets quantity of this product at the price with discount.
        /// </summary>
        [JsonProperty(PropertyName = "quantity")]
        public int Quantity { get; set; }

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
