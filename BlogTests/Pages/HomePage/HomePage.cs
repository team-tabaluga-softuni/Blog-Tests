namespace Blog_Tests.Pages.HomePage
{
    using OpenQA.Selenium;

    public partial class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver) { }

        public string HomepageUrl => "http://localhost:60634/Article/List";
    }
}
