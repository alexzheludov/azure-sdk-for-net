// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.NotificationHubs.Models
{
    using System.Linq;

    /// <summary>
    /// Description of a Namespace AuthorizationRules.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class SharedAccessAuthorizationRuleResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SharedAccessAuthorizationRuleResource class.
        /// </summary>
        public SharedAccessAuthorizationRuleResource() { }

        /// <summary>
        /// Initializes a new instance of the
        /// SharedAccessAuthorizationRuleResource class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="sku">The sku of the created namespace</param>
        /// <param name="rights">The rights associated with the rule.</param>
        public SharedAccessAuthorizationRuleResource(string location, string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), Sku sku = default(Sku), System.Collections.Generic.IList<AccessRights?> rights = default(System.Collections.Generic.IList<AccessRights?>))
            : base(location, id, name, type, tags, sku)
        {
            Rights = rights;
        }

        /// <summary>
        /// Gets or sets the rights associated with the rule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.rights")]
        public System.Collections.Generic.IList<AccessRights?> Rights { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}