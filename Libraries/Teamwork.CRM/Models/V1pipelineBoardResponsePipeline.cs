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
    /// Pipeline
    /// </summary>
    /// <remarks>
    /// Pipeline represents a pipeline in the CRM system.
    /// </remarks>
    public partial class V1pipelineBoardResponsePipeline
    {
        /// <summary>
        /// Initializes a new instance of the V1pipelineBoardResponsePipeline
        /// class.
        /// </summary>
        public V1pipelineBoardResponsePipeline()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1pipelineBoardResponsePipeline
        /// class.
        /// </summary>
        /// <param name="createdBy">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        /// <param name="deletedBy">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        /// <param name="isQualified">If true then leads inside of this
        /// pipeline will be considered opportunities,
        /// see [Leads, opportunities, and deals](
        /// https://crmdev-teamwork.docs.stoplight.io/documentation/miscellaneous/leads-opportunities)
        /// for more information.</param>
        /// <param name="orderIndex">Position of the pipeline in the set of all
        /// pipelines.
        /// Lower numbers come first when retrieving multiple elements at
        /// once.</param>
        /// <param name="stages">[To-many relationship
        /// array](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#to-many-relationships)
        /// which describes a list of resource identifier objects.</param>
        /// <param name="totalValue">Total value of the pipeline in your
        /// currencies lowest denomination, e.g for USD
        /// the value in cents. This is the customValue of all the deals in the
        /// pipeline
        /// (ignoring pagination) plus the sum of all the deals products
        /// prices.</param>
        /// <param name="updatedBy">[Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.</param>
        public V1pipelineBoardResponsePipeline(System.DateTime? createdAt = default(System.DateTime?), V1pipelineBoardResponsePipelineCreatedBy createdBy = default(V1pipelineBoardResponsePipelineCreatedBy), System.DateTime? deletedAt = default(System.DateTime?), V1pipelineBoardResponsePipelineDeletedBy deletedBy = default(V1pipelineBoardResponsePipelineDeletedBy), int? id = default(int?), bool? isQualified = default(bool?), string name = default(string), int? orderIndex = default(int?), IList<V1pipelineBoardResponsePipelineStagesItem> stages = default(IList<V1pipelineBoardResponsePipelineStagesItem>), int? stagesCount = default(int?), double? totalValue = default(double?), System.DateTime? updatedAt = default(System.DateTime?), V1pipelineBoardResponsePipelineUpdatedBy updatedBy = default(V1pipelineBoardResponsePipelineUpdatedBy), int? updatedSourceId = default(int?))
        {
            CreatedAt = createdAt;
            CreatedBy = createdBy;
            DeletedAt = deletedAt;
            DeletedBy = deletedBy;
            Id = id;
            IsQualified = isQualified;
            Name = name;
            OrderIndex = orderIndex;
            Stages = stages;
            StagesCount = stagesCount;
            TotalValue = totalValue;
            UpdatedAt = updatedAt;
            UpdatedBy = updatedBy;
            UpdatedSourceId = updatedSourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdAt")]
        public System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets [Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.
        /// </summary>
        [JsonProperty(PropertyName = "createdBy")]
        public V1pipelineBoardResponsePipelineCreatedBy CreatedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deletedAt")]
        public System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Gets or sets [Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.
        /// </summary>
        [JsonProperty(PropertyName = "deletedBy")]
        public V1pipelineBoardResponsePipelineDeletedBy DeletedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets if true then leads inside of this pipeline will be
        /// considered opportunities,
        /// see [Leads, opportunities, and deals](
        /// https://crmdev-teamwork.docs.stoplight.io/documentation/miscellaneous/leads-opportunities)
        /// for more information.
        /// </summary>
        [JsonProperty(PropertyName = "isQualified")]
        public bool? IsQualified { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets position of the pipeline in the set of all pipelines.
        /// Lower numbers come first when retrieving multiple elements at once.
        /// </summary>
        [JsonProperty(PropertyName = "orderIndex")]
        public int? OrderIndex { get; set; }

        /// <summary>
        /// Gets or sets [To-many relationship
        /// array](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#to-many-relationships)
        /// which describes a list of resource identifier objects.
        /// </summary>
        [JsonProperty(PropertyName = "stages")]
        public IList<V1pipelineBoardResponsePipelineStagesItem> Stages { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stagesCount")]
        public int? StagesCount { get; set; }

        /// <summary>
        /// Gets or sets total value of the pipeline in your currencies lowest
        /// denomination, e.g for USD
        /// the value in cents. This is the customValue of all the deals in the
        /// pipeline
        /// (ignoring pagination) plus the sum of all the deals products
        /// prices.
        /// </summary>
        [JsonProperty(PropertyName = "totalValue")]
        public double? TotalValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "updatedAt")]
        public System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets [Resource identifier
        /// object](https://crmdev-teamwork.docs.stoplight.io/documentation/general/entity-models#relationships)
        /// which describes a relationship to another entity.
        /// </summary>
        [JsonProperty(PropertyName = "updatedBy")]
        public V1pipelineBoardResponsePipelineUpdatedBy UpdatedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "updatedSourceId")]
        public int? UpdatedSourceId { get; set; }

    }
}
