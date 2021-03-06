// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Storage.Admin.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Storage Encryption setting
    /// </summary>
    public partial class StorageEncryptionSetting
    {
        /// <summary>
        /// Initializes a new instance of the StorageEncryptionSetting class.
        /// </summary>
        public StorageEncryptionSetting()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageEncryptionSetting class.
        /// </summary>
        /// <param name="enabled">Bool to indicate whether enabled or
        /// not.</param>
        /// <param name="lastEnabledTime">A rough estimate of the date/time
        /// when the encryption was last enabled by the user.</param>
        public StorageEncryptionSetting(bool? enabled = default(bool?), string lastEnabledTime = default(string))
        {
            Enabled = enabled;
            LastEnabledTime = lastEnabledTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets bool to indicate whether enabled or not.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; private set; }

        /// <summary>
        /// Gets a rough estimate of the date/time when the encryption was last
        /// enabled by the user.
        /// </summary>
        [JsonProperty(PropertyName = "lastEnabledTime")]
        public string LastEnabledTime { get; private set; }

    }
}
