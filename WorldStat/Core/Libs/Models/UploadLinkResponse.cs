using Newtonsoft.Json;

namespace WorldStat.Core.Libs.Models
{
    public class UploadLinkResponse : YandexResponse
    {
        [JsonProperty("operation_id")]
        public string OperationId { get; set; }
    }
}
