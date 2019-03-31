namespace Blog_Tests.Pages.RegisterPage
{
    using Blog_Tests.Models;
    using OpenQA.Selenium;

    public partial class RegisterPage : BasePage
    {
        public RegisterPage(IWebDriver driver) : base(driver) { }

        public string RegisterPageUrl => "http://localhost:60634/Account/Register";

        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl("http://localhost:60634/Account/Register");
        }

        public void FillRegisterForm(RegisterUser user)
        {
            Email.SendKeys(user.Email);
            FullName.SendKeys(user.FullName);
            Password.SendKeys(user.Password);
            ConfirmPassword.SendKeys(user.ConfirmPassword);
            RegisterButton.Click();
        }
    }
}
