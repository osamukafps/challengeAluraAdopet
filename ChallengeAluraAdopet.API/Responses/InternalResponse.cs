using System.Text.Json;
using System.Text.Json.Serialization;

namespace ChallengeAluraAdopet.API.Responses;

public class InternalResponse
{
    public int Code { get; set; }
    public string Message { get; set; }
    public string Data { get; set; }
    public Exception Exception { get; set; }

    public static string SetData<T>(T objectToConvert)
    {
        return JsonSerializer.Serialize(objectToConvert);
    }
}