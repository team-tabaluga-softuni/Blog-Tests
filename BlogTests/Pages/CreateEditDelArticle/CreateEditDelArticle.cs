namespace Blog_Tests.Pages.CreateEditDelArticle
{
    using Blog_Tests.Models;
    using OpenQA.Selenium;

    //The 3 pages Create, Edit and Delete have the same content and the same paths of the fields and buttons.
    //The differences are:
    // 1. the name of one button - create, edit, delete, but the Xpath is equal,
    // 2. the name of the page where they are open,
    // 3. In change and delete pages, there is text in the "title" and "content" of the article.

    public partial class CreateEditDelArticle : BasePage
    {
        public CreateEditDelArticle(IWebDriver driver) : base(driver) { }

        public void FillForm(CreateArticleForm article)
        {
            Title.SendKeys(article.Title);
            Content.SendKeys(article.Content);
        }

        public void SubmitCreateEditDelArticleButton()
        {
            CreateEditDelButton.Submit();
        }

        public void CancelCreateArticlaButton()
        {
            CancelButton.Submit();
        }
    }
}
