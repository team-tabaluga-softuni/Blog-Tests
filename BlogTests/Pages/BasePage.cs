namespace Blog_Tests.Pages
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;
    using System;

    public abstract class BasePage
    {
        private IWebDriver _driver;

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebDriver Driver => _driver;

        public WebDriverWait Wait => new WebDriverWait(_driver, TimeSpan.FromSeconds(100));

    }
}
