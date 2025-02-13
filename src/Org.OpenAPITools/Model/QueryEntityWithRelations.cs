/*
 * CrudSQL API
 *
 * A powerful dynamic CRUD API engine that automatically generates RESTful endpoints for your data models CrudSQL provides automatic CRUD operations, filtering, pagination, and sorting capabilities for any data model. Features: - Automatic REST API generation - Dynamic model support - Complex filtering and querying - Pagination and sorting - Swagger documentation - Multiple database support (SQL & NoSQL)
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: taqi@mobix.biz
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// QueryEntityWithRelations
    /// </summary>
    [DataContract(Name = "query.EntityWithRelations")]
    public partial class QueryEntityWithRelations : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryEntityWithRelations" /> class.
        /// </summary>
        /// <param name="mainEntity">mainEntity.</param>
        /// <param name="relations">relations.</param>
        public QueryEntityWithRelations(Object mainEntity = default(Object), Dictionary<string, List<Object>> relations = default(Dictionary<string, List<Object>>))
        {
            this.MainEntity = mainEntity;
            this.Relations = relations;
        }

        /// <summary>
        /// Gets or Sets MainEntity
        /// </summary>
        [DataMember(Name = "mainEntity", EmitDefaultValue = false)]
        public Object MainEntity { get; set; }

        /// <summary>
        /// Gets or Sets Relations
        /// </summary>
        [DataMember(Name = "relations", EmitDefaultValue = false)]
        public Dictionary<string, List<Object>> Relations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QueryEntityWithRelations {\n");
            sb.Append("  MainEntity: ").Append(MainEntity).Append("\n");
            sb.Append("  Relations: ").Append(Relations).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
