using Newtonsoft.Json;

namespace WorldStat.Core.Libs.Models
{
    public class YandexResponse
    {

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("templated")]
        public bool Templated { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        public bool IsError()
        {
            if (string.IsNullOrEmpty(Error))
                return false;
            return true;
        }

        public bool IsData()
        {
            if (string.IsNullOrEmpty(Href))
                return false;
            return true;
        }
    }
}
