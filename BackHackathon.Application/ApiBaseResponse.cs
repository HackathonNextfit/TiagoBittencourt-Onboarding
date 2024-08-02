using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace BackHackathon.Application;

public class ApiBaseResponse<T>
{
    [JsonProperty("Content")]
    public T Content { get; set; }

    [JsonProperty("Message")]
    public string Message { get; set; }

    [JsonProperty("Success")]
    public bool Success { get; set; }
}