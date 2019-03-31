namespace Blog_Tests.Models

{
    using Newtonsoft.Json;

    public partial class LoginUser
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        public static LoginUser FromJson(string json) => JsonConvert.DeserializeObject<LoginUser>(json, Blog_Tests.Models.Converter.Settings);

    }
}