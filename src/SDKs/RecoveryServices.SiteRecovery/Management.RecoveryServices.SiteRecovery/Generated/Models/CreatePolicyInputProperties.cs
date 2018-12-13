// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Policy creation properties.
    /// </summary>
    public partial class CreatePolicyInputProperties
    {
        /// <summary>
        /// Initializes a new instance of the CreatePolicyInputProperties
        /// class.
        /// </summary>
        public CreatePolicyInputProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreatePolicyInputProperties
        /// class.
        /// </summary>
        /// <param name="providerSpecificInput">The
        /// ReplicationProviderSettings.</param>
        public CreatePolicyInputProperties(PolicyProviderSpecificInput providerSpecificInput = default(PolicyProviderSpecificInput))
        {
            ProviderSpecificInput = providerSpecificInput;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ReplicationProviderSettings.
        /// </summary>
        [JsonProperty(PropertyName = "providerSpecificInput")]
        public PolicyProviderSpecificInput ProviderSpecificInput { get; set; }

    }
}