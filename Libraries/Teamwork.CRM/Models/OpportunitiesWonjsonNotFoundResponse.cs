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
    /// docErrorResp
    /// </summary>
    public partial class OpportunitiesWonjsonNotFoundResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// OpportunitiesWonjsonNotFoundResponse class.
        /// </summary>
        public OpportunitiesWonjsonNotFoundResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// OpportunitiesWonjsonNotFoundResponse class.
        /// </summary>
        /// <param name="errors">At least one error object will be returned
        /// when an error occurs, see
        /// [Errors](https://crmdev-teamwork.docs.stoplight.io/documentation/general/errors)
        /// for a more
        /// complete description.</param>
        public OpportunitiesWonjsonNotFoundResponse(IList<OpportunitiesWonjsonNotFoundResponseErrorsItem> errors = default(IList<OpportunitiesWonjsonNotFoundResponseErrorsItem>))
        {
            Errors = errors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets at least one error object will be returned when an
        /// error occurs, see
        /// [Errors](https://crmdev-teamwork.docs.stoplight.io/documentation/general/errors)
        /// for a more
        /// complete description.
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public IList<OpportunitiesWonjsonNotFoundResponseErrorsItem> Errors { get; set; }

    }
}