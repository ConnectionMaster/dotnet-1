// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Teamwork.CRM.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ActivityTypesjsonConflictResponseErrorsItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ActivityTypesjsonConflictResponseErrorsItem class.
        /// </summary>
        public ActivityTypesjsonConflictResponseErrorsItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ActivityTypesjsonConflictResponseErrorsItem class.
        /// </summary>
        /// <param name="code">[Application-specific error
        /// code.](https://crmdev-teamwork.docs.stoplight.io/documentation/general/errors#codes)</param>
        /// <param name="detail">Human-readable explanation of this specific
        /// occurrence of the error.</param>
        /// <param name="id">Unique id for this instance of an error.</param>
        /// <param name="title">Human-readable summary of the problem.</param>
        public ActivityTypesjsonConflictResponseErrorsItem(string code = default(string), string detail = default(string), string id = default(string), string title = default(string))
        {
            Code = code;
            Detail = detail;
            Id = id;
            Title = title;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets [Application-specific error
        /// code.](https://crmdev-teamwork.docs.stoplight.io/documentation/general/errors#codes)
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets human-readable explanation of this specific occurrence
        /// of the error.
        /// </summary>
        [JsonProperty(PropertyName = "detail")]
        public string Detail { get; set; }

        /// <summary>
        /// Gets or sets unique id for this instance of an error.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets human-readable summary of the problem.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

    }
}
