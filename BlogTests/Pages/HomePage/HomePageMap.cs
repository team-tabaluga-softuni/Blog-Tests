namespace Blog_Tests.Pages.HomePage
{
    using OpenQA.Selenium;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public partial class HomePage
    {

        public IWebElement ArticleContainer => Wait.Until((d) => { return d.FindElement(By.XPath(@"/html/body/div[2]/div")); });

        // public IWebElement BlogUpDate => Wait.Until((d) => { return d.FindElement(By.XPath(@"//html/body/div[2]/div/div/div[3]/article/header/h2/a")); });

        // public IWebElement ProBlog => Wait.Until((d) => { return d.FindElement(By.XPath(@"//html/body/div[2]/div/div/div[2]/article/header/h2/a")); });

    }
}
