using Newtonsoft.Json;

namespace NestedRecylerViewSample.Core.Models
{
    public class BaseModel
    {
        [JsonProperty("meta")]
        public Meta meta { get; set; }
        [JsonProperty("data")]
        public object data { get; set; }
        [JsonProperty("pagination")]
        public Pagination pagination { get; set; }
    }

    public class Meta
    {
        [JsonProperty("errorType")]
        public string ErrorType { get; set; }
        [JsonProperty("code")]
        public int Code { get; set; }
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }
    }

    public class Pagination
    {
        [JsonProperty("nextUrl")]
        public string NextUrl { get; set; }
        [JsonProperty("isLatestSet")]
        public bool IsLatestSet { get; set; }
    }
}