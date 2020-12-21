using System.Text.Json.Serialization;

namespace blazor.Client.Models
{
    public class JwtToken
    {
        [JsonPropertyName("id_token")]
        public string IdToken { get; set; }
    }
}
