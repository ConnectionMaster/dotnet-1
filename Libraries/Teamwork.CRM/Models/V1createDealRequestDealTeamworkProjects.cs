// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Teamwork.CRM.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// DealProjectsData
    /// </summary>
    /// <remarks>
    /// DealProjectsData contains references to Teamwork Projects entities for
    /// integrations.
    /// </remarks>
    public partial class V1createDealRequestDealTeamworkProjects
    {
        /// <summary>
        /// Initializes a new instance of the
        /// V1createDealRequestDealTeamworkProjects class.
        /// </summary>
        public V1createDealRequestDealTeamworkProjects()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// V1createDealRequestDealTeamworkProjects class.
        /// </summary>
        /// <param name="projectId">The id of the Teamwork Projects Project
        /// this deal is linked to.</param>
        public V1createDealRequestDealTeamworkProjects(int? projectId = default(int?))
        {
            ProjectId = projectId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the id of the Teamwork Projects Project this deal is
        /// linked to.
        /// </summary>
        [JsonProperty(PropertyName = "projectId")]
        public int? ProjectId { get; set; }

    }
}
