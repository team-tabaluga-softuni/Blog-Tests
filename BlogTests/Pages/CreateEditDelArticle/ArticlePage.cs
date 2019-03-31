namespace Blog_Tests.Pages.CreateEditDelArticle
{
    using OpenQA.Selenium;

    public class ArticlePage : BasePage
    {
        public ArticlePage(IWebDriver driver) : base(driver) { }

        public IWebElement NavigationButtonToEditArticlePage => Wait.Until((d) =>
        {
            return d.FindElement(By.XPath(@"/html/body/div[2]/div/article/footer/a[1]"));
        });

        public IWebElement NavigationButtonToDeleteArticlePage => Wait.Until((d) =>
        {
            return d.FindElement(By.XPath(@"/html/body/div[2]/div/article/footer/a[2]"));
        });

        public IWebElement BackButton => Wait.Until((d) =>
        {
            return d.FindElement(By.XPath(@"/html/body/div[2]/div/article/footer/a[3]"));
        });
    }
}
