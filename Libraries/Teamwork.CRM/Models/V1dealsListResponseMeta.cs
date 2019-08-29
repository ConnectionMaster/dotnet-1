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
    /// dealListMeta
    /// </summary>
    public partial class V1dealsListResponseMeta
    {
        /// <summary>
        /// Initializes a new instance of the V1dealsListResponseMeta class.
        /// </summary>
        public V1dealsListResponseMeta()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1dealsListResponseMeta class.
        /// </summary>
        /// <param name="columns">Column values for all the returned entities.
        ///
        /// This is another mechanism of side loading data for the web app,
        /// columns
        /// referring to the columns in the UI.
        ///
        /// Each of the objects keys is an id of one of the returned entities,
        /// the value
        /// of the key is another object mapping column id to value.
        ///
        /// There are 3 possible types of values for a column:
        /// - reference to a to-one relationship
        /// - reference to one item of a to-many relationship
        /// - store stats/counters values
        ///
        /// **To-one relationship reference:**
        /// To-one relationship columns could either be in the “meta” field or
        /// not. It will
        /// be a reference in the meta field pointing to an included entity if
        /// the
        /// relationship is indirect (i.e. a relationship of a relationship).
        /// Otherwise, in
        /// order to reduce the payload size, if it is a direct relationship of
        /// the main
        /// entity it will be only in the main entity body, as usual.
        /// For example, a column '101' that is the deal.owner.company.address
        /// for dealId '1'.
        /// On deal/view/list.json endpoint:
        /// ```
        /// {
        /// meta: {
        /// 1: {
        /// 101: {
        /// id: 9991,
        /// type: 'companies',
        /// }
        /// }
        /// },
        /// included: {
        /// companies: [
        /// {
        /// // full entity here
        /// }
        /// ]
        /// }
        /// }
        /// ```
        ///
        /// **To-many relationship reference:**
        /// Some columns are to-many relationships of the main entity (e.g. the
        /// activity.assignees .name on activities/view/list.json). On these
        /// cases, the
        /// column will have ONLY ONE item.
        /// ```
        /// {
        /// activity:{
        /// ...,
        /// assignees: [
        /// { id: 1, type: 'users' },
        /// { id: 2, type: 'users' },
        /// { id: 3, type: 'users' }
        /// ],
        /// assigneesCount: 3
        /// }
        /// meta: {
        /// 1: {
        /// 101: { id: 1, type: 'users' },
        /// }
        /// },
        /// included: {
        /// users:[
        /// { id: 1, ... },
        /// ]
        /// }
        /// }
        /// ```
        ///
        /// This will show ONE assignee's full name then "+2", on the
        /// interface, for example.
        ///
        /// **Store stats/counters values:**
        /// Some columns aren't related to entities and store values like stats
        /// or
        /// counters, like company.numberOfLostLeads, for example. On these
        /// cases
        /// the 'meta' field will have the columnId followed by the value.
        /// ```
        /// // 15 lost leads for company 1
        /// {
        /// meta: {
        /// 1: {
        /// 101: 15
        /// }
        /// }
        /// }
        /// ```</param>
        /// <param name="page">Page</param>
        /// <param name="totalValue">Total value of all the deals in the
        /// request
        /// This is the aggregation of all the deal totalValue fields, ignoring
        /// pagination and converted into the users currency
        /// preference.</param>
        public V1dealsListResponseMeta(object columns = default(object), V1dealsListResponseMetaPage page = default(V1dealsListResponseMetaPage), double? totalValue = default(double?))
        {
            Columns = columns;
            Page = page;
            TotalValue = totalValue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets column values for all the returned entities.
        ///
        /// This is another mechanism of side loading data for the web app,
        /// columns
        /// referring to the columns in the UI.
        ///
        /// Each of the objects keys is an id of one of the returned entities,
        /// the value
        /// of the key is another object mapping column id to value.
        ///
        /// There are 3 possible types of values for a column:
        /// - reference to a to-one relationship
        /// - reference to one item of a to-many relationship
        /// - store stats/counters values
        ///
        /// **To-one relationship reference:**
        /// To-one relationship columns could either be in the “meta” field or
        /// not. It will
        /// be a reference in the meta field pointing to an included entity if
        /// the
        /// relationship is indirect (i.e. a relationship of a relationship).
        /// Otherwise, in
        /// order to reduce the payload size, if it is a direct relationship of
        /// the main
        /// entity it will be only in the main entity body, as usual.
        /// For example, a column '101' that is the deal.owner.company.address
        /// for dealId '1'.
        /// On deal/view/list.json endpoint:
        /// ```
        /// {
        /// meta: {
        /// 1: {
        /// 101: {
        /// id: 9991,
        /// type: 'companies',
        /// }
        /// }
        /// },
        /// included: {
        /// companies: [
        /// {
        /// // full entity here
        /// }
        /// ]
        /// }
        /// }
        /// ```
        ///
        /// **To-many relationship reference:**
        /// Some columns are to-many relationships of the main entity (e.g. the
        /// activity.assignees .name on activities/view/list.json). On these
        /// cases, the
        /// column will have ONLY ONE item.
        /// ```
        /// {
        /// activity:{
        /// ...,
        /// assignees: [
        /// { id: 1, type: 'users' },
        /// { id: 2, type: 'users' },
        /// { id: 3, type: 'users' }
        /// ],
        /// assigneesCount: 3
        /// }
        /// meta: {
        /// 1: {
        /// 101: { id: 1, type: 'users' },
        /// }
        /// },
        /// included: {
        /// users:[
        /// { id: 1, ... },
        /// ]
        /// }
        /// }
        /// ```
        ///
        /// This will show ONE assignee's full name then "+2", on the
        /// interface, for example.
        ///
        /// **Store stats/counters values:**
        /// Some columns aren't related to entities and store values like stats
        /// or
        /// counters, like company.numberOfLostLeads, for example. On these
        /// cases
        /// the 'meta' field will have the columnId followed by the value.
        /// ```
        /// // 15 lost leads for company 1
        /// {
        /// meta: {
        /// 1: {
        /// 101: 15
        /// }
        /// }
        /// }
        /// ```
        /// </summary>
        [JsonProperty(PropertyName = "columns")]
        public object Columns { get; set; }

        /// <summary>
        /// Gets or sets page
        /// </summary>
        /// <remarks>
        /// Page contains the pagination data.
        /// </remarks>
        [JsonProperty(PropertyName = "page")]
        public V1dealsListResponseMetaPage Page { get; set; }

        /// <summary>
        /// Gets or sets total value of all the deals in the request
        /// This is the aggregation of all the deal totalValue fields, ignoring
        /// pagination and converted into the users currency preference.
        /// </summary>
        [JsonProperty(PropertyName = "totalValue")]
        public double? TotalValue { get; set; }

    }
}
