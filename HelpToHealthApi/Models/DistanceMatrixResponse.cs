using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HelpToHealthApi.Models
{
    public class DistanceMatrixResponse
    {
        [JsonPropertyName("destination_addresses")]
        public string DestinationAddresses { get; set; }

        [JsonPropertyName("origin_addresses")]
        public string OriginAddresses { get; set; }

        [JsonPropertyName("rows")]
        public IEnumerable<DistanceMatrixRow> Rows { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }
    }

    public class DistanceMatrixRow
    {
        [JsonPropertyName("elements")]
        public IEnumerable<DistanceMatrixElement> Elements { get; set; }
    }

    public class DistanceMatrixElement
    {
        [JsonPropertyName("distance")]
        public Distance Distance { get; set; }

        [JsonPropertyName("duration")]
        public Duration Duration { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }
    }

    public class Distance
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("value")]
        public int Value { get; set; }
    }

    public class Duration
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("value")]
        public int Value { get; set; }
    }
}
