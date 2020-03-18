// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Models
{
    public partial class TagScoringFunction : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("tag");
            writer.WriteObjectValue(Parameters);
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            writer.WritePropertyName("fieldName");
            writer.WriteStringValue(FieldName);
            writer.WritePropertyName("boost");
            writer.WriteNumberValue(Boost);
            if (Interpolation != null)
            {
                writer.WritePropertyName("interpolation");
                writer.WriteStringValue(Interpolation.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }

        internal static TagScoringFunction DeserializeTagScoringFunction(JsonElement element)
        {
            TagScoringFunction result = new TagScoringFunction();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tag"))
                {
                    result.Parameters = TagScoringParameters.DeserializeTagScoringParameters(property.Value);
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    result.Type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fieldName"))
                {
                    result.FieldName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("boost"))
                {
                    result.Boost = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("interpolation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Interpolation = property.Value.GetString().ToScoringFunctionInterpolation();
                    continue;
                }
            }
            return result;
        }
    }
}
