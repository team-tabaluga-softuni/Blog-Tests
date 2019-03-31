namespace Blog_Tests.Pages.LoginPage
{
    using Blog_Tests.Models;
    using OpenQA.Selenium;

    public partial class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver) { }

        public string LoginPageUrl => "http://localhost:60634/Account/Login";

        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl("http://localhost:60634/Account/Login");
        }

        public void FillForm(LoginUser user)
        {
            Email.SendKeys(user.Email);
            Password.SendKeys(user.Password);
        }

        public void SubmitLoginButton()
        {
            LoginButton.Click();
        }
    }
}
