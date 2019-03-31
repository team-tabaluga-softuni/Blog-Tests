namespace Blog_Tests.Pages.CreateEditDelArticle
{
    using OpenQA.Selenium;

    //The 3 pages Create, Edit and Delete have the same content and the same paths of the fields and buttons.
    //The differences are:
    // 1. the name of one button - create, edit, delete, but the Xpath is equal,
    // 2. the name of the page where they are open,
    // 3. In change and delete pages, there is text in the "title" and "content" of the article.

    public partial class CreateEditDelArticle
    {
        public IWebElement Title => Wait.Until((d) =>
        {
            return d.FindElement(By.Id("Title"));
        });

        public IWebElement Content => Wait.Until((d) =>
        {
            return d.FindElement(By.Id("Content"));
        });

        public IWebElement CancelButton => Wait.Until((d) =>
        {
            return d.FindElement(By.XPath(@"/html/body/div[2]/div/div/form/div[4]/div/"));
        });

        public IWebElement CreateEditDelButton => Wait.Until((d) =>
        {
            return d.FindElement(By.XPath(@"/html/body/div[2]/div/div/form/div[4]/div/input"));
        });

    }
}
