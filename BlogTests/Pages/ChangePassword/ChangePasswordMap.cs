namespace Blog_Tests.Pages.ChangePassword
{
    using OpenQA.Selenium;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public partial class ChangePassword
    {
        public IWebElement CurrentPassword => Wait.Until((d) =>
        {
            return d.FindElement(By.Id("OldPassword"));
        });

        public IWebElement NewPassword => Wait.Until((d) =>
        {
            return d.FindElement(By.Id("NewPassword"));
        });

        public IWebElement ConfirmNewPassword => Wait.Until((d) =>
        {
            return d.FindElement(By.Id("ConfirmPassword"));
        });

        public IWebElement ChangePasswordButton => Wait.Until((d) =>
        {
            return d.FindElement(By.XPath(@"/html/body/div[2]/div/div/form/div[5]/div/input"));
        });

    }
}
