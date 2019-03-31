namespace Blog_Tests.Pages.ChangePassword
{
    using OpenQA.Selenium;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Manage : BasePage
    {
        public Manage(IWebDriver driver) : base(driver) { }

        public IWebElement ChangeYourPasswordFeeld => Wait.Until((d) => { return d.FindElement(By.XPath(@"/html/body/div[2]/div/dl/dd/a")); });

        public void ClickChangeYourPasswordFeeld()
        {
            ChangeYourPasswordFeeld.Submit();
        }

    }
}
