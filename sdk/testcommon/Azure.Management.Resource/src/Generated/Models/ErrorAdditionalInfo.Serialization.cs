// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Resource.Models
{
    public partial class ErrorAdditionalInfo
    {
        internal static ErrorAdditionalInfo DeserializeErrorAdditionalInfo(JsonElement element)
        {
            string type = default;
            object info = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("info"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    info = property.Value.GetObject();
                    continue;
                }
            }
            return new ErrorAdditionalInfo(type, info);
        }
    }
}