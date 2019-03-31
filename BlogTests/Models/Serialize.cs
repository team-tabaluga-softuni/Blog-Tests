namespace Blog_Tests.Models

{
    using Newtonsoft.Json;

    public static class Serialize
    {
        public static string ToJson(this RegisterUser self) => JsonConvert.SerializeObject(self, Blog_Tests.Models.Converter.Settings);

        public static string ToJson(this LoginUser self) => JsonConvert.SerializeObject(self, Blog_Tests.Models.Converter.Settings);

        public static string ToJson(this CreateArticleForm self) => JsonConvert.SerializeObject(self, Blog_Tests.Models.Converter.Settings);

        public static string ToJson(this ChangePasswordForm self) => JsonConvert.SerializeObject(self, Blog_Tests.Models.Converter.Settings);

    }
}
