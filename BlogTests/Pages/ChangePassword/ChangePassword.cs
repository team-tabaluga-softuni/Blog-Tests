namespace Blog_Tests.Pages.ChangePassword
{
    using Blog_Tests.Models;
    using OpenQA.Selenium;

    public partial class ChangePassword : BasePage
    {
        public ChangePassword(IWebDriver driver) : base(driver) { }

        public string ChangePassUrl => "http://localhost:60634/Manage/ChangePassword";

        public void FillForm(ChangePasswordForm pass)
        {
            CurrentPassword.SendKeys(pass.CurrentPasword);
            NewPassword.SendKeys(pass.NewPassword);
            ConfirmNewPassword.SendKeys(pass.ConfirmNewPassword);
        }

        public void SubmitChangePasswordButton()
        {
            ChangePasswordButton.Submit();
        }
    }
}
