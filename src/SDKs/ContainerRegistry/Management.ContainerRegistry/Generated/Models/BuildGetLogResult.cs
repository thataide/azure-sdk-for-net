// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The result of get log link operation.
    /// </summary>
    public partial class BuildGetLogResult
    {
        /// <summary>
        /// Initializes a new instance of the BuildGetLogResult class.
        /// </summary>
        public BuildGetLogResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BuildGetLogResult class.
        /// </summary>
        /// <param name="logLink">The link to logs for a azure container
        /// registry build.</param>
        public BuildGetLogResult(string logLink = default(string))
        {
            LogLink = logLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the link to logs for a azure container registry build.
        /// </summary>
        [JsonProperty(PropertyName = "logLink")]
        public string LogLink { get; set; }

    }
}