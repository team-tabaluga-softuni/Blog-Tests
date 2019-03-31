namespace Blog_Tests.Models

{
    using Newtonsoft.Json;

    public partial class CreateArticleForm
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        public static CreateArticleForm FromJson(string json) => JsonConvert.DeserializeObject<CreateArticleForm>(json, Blog_Tests.Models.Converter.Settings);

    }
}
