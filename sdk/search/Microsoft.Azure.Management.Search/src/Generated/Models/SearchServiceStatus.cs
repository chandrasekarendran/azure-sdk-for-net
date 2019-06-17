// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Search.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for SearchServiceStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SearchServiceStatus
    {
        [EnumMember(Value = "running")]
        Running,
        [EnumMember(Value = "provisioning")]
        Provisioning,
        [EnumMember(Value = "deleting")]
        Deleting,
        [EnumMember(Value = "degraded")]
        Degraded,
        [EnumMember(Value = "disabled")]
        Disabled,
        [EnumMember(Value = "error")]
        Error
    }
    internal static class SearchServiceStatusEnumExtension
    {
        internal static string ToSerializedValue(this SearchServiceStatus? value)
        {
            return value == null ? null : ((SearchServiceStatus)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this SearchServiceStatus value)
        {
            switch( value )
            {
                case SearchServiceStatus.Running:
                    return "running";
                case SearchServiceStatus.Provisioning:
                    return "provisioning";
                case SearchServiceStatus.Deleting:
                    return "deleting";
                case SearchServiceStatus.Degraded:
                    return "degraded";
                case SearchServiceStatus.Disabled:
                    return "disabled";
                case SearchServiceStatus.Error:
                    return "error";
            }
            return null;
        }

        internal static SearchServiceStatus? ParseSearchServiceStatus(this string value)
        {
            switch( value )
            {
                case "running":
                    return SearchServiceStatus.Running;
                case "provisioning":
                    return SearchServiceStatus.Provisioning;
                case "deleting":
                    return SearchServiceStatus.Deleting;
                case "degraded":
                    return SearchServiceStatus.Degraded;
                case "disabled":
                    return SearchServiceStatus.Disabled;
                case "error":
                    return SearchServiceStatus.Error;
            }
            return null;
        }
    }
}