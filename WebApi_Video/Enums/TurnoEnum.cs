using System.Text.Json.Serialization;

namespace WebApi_Video.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]

    public enum TurnoEnum
    {
        Manha,
        Tarde,
        Noite
    }
}
