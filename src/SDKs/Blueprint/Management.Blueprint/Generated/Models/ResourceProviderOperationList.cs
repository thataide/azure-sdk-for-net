// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Blueprint.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Result of the request to list operations.
    /// </summary>
    public partial class ResourceProviderOperationList
    {
        /// <summary>
        /// Initializes a new instance of the ResourceProviderOperationList
        /// class.
        /// </summary>
        public ResourceProviderOperationList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceProviderOperationList
        /// class.
        /// </summary>
        /// <param name="value">List of operations supported by this resource
        /// provider.</param>
        public ResourceProviderOperationList(IList<ResourceProviderOperation> value = default(IList<ResourceProviderOperation>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of operations supported by this resource
        /// provider.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<ResourceProviderOperation> Value { get; set; }

    }
}