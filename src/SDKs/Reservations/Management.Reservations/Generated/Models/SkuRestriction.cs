// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Reservations.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class SkuRestriction
    {
        /// <summary>
        /// Initializes a new instance of the SkuRestriction class.
        /// </summary>
        public SkuRestriction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SkuRestriction class.
        /// </summary>
        /// <param name="type">The type of restrictions.</param>
        /// <param name="values">The value of restrictions. If the restriction
        /// type is set to location. This would be different locations where
        /// the SKU is restricted.</param>
        /// <param name="reasonCode">The reason for restriction.</param>
        public SkuRestriction(string type = default(string), IList<string> values = default(IList<string>), string reasonCode = default(string))
        {
            Type = type;
            Values = values;
            ReasonCode = reasonCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the type of restrictions.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the value of restrictions. If the restriction type is
        /// set to location. This would be different locations where the SKU is
        /// restricted.
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IList<string> Values { get; set; }

        /// <summary>
        /// Gets or sets the reason for restriction.
        /// </summary>
        [JsonProperty(PropertyName = "reasonCode")]
        public string ReasonCode { get; set; }

    }
}
