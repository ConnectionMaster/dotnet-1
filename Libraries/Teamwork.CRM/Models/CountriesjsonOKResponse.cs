// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Teamwork.CRM.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// countriesResponse
    /// </summary>
    public partial class CountriesjsonOKResponse
    {
        /// <summary>
        /// Initializes a new instance of the CountriesjsonOKResponse class.
        /// </summary>
        public CountriesjsonOKResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CountriesjsonOKResponse class.
        /// </summary>
        /// <param name="meta">ResponseMeta</param>
        public CountriesjsonOKResponse(IList<CountriesjsonOKResponseCountriesItem> countries = default(IList<CountriesjsonOKResponseCountriesItem>), CountriesjsonOKResponseMeta meta = default(CountriesjsonOKResponseMeta))
        {
            Countries = countries;
            Meta = meta;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "countries")]
        public IList<CountriesjsonOKResponseCountriesItem> Countries { get; set; }

        /// <summary>
        /// Gets or sets responseMeta
        /// </summary>
        /// <remarks>
        /// ResponseMeta contains common meta data.
        /// </remarks>
        [JsonProperty(PropertyName = "meta")]
        public CountriesjsonOKResponseMeta Meta { get; set; }

    }
}