using System.Text.Json.Serialization;

namespace WebApi_Fullstack.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]

    public enum TurnoEnum
    {
        Manha,
        Tarde,
        Noite
    }
}
