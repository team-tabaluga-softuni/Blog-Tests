namespace Blog_Tests.Models

{
    using Newtonsoft.Json;

    public partial class RegisterUser
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("confirmPassword")]
        public string ConfirmPassword { get; set; }

        public static RegisterUser FromJson(string json) => JsonConvert.DeserializeObject<RegisterUser>(json, Blog_Tests.Models.Converter.Settings);

    }
}
