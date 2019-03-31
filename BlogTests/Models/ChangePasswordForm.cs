namespace Blog_Tests.Models
{
    using Newtonsoft.Json;

    public partial class ChangePasswordForm
    {
        [JsonProperty("currentPasword")]
        public string CurrentPasword { get; set; }

        [JsonProperty("newPassword")]
        public string NewPassword { get; set; }

        [JsonProperty("confirmNewPassword")]
        public string ConfirmNewPassword { get; set; }

        public static ChangePasswordForm FromJson(string json) => JsonConvert.DeserializeObject<ChangePasswordForm>(json, Blog_Tests.Models.Converter.Settings);

    }
}
