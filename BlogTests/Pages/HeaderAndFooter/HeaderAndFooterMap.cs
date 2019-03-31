namespace Blog_Tests.Pages.HeaderAndFooter
{
    using OpenQA.Selenium;

    public partial class HeaderAndFooter
    {
        public IWebElement SoftUniBlogLink => Wait.Until((d) =>
        {
            return d.FindElement(By.XPath(@"//html/body/div[1]/div/div[1]/a"));
        });

        public IWebElement RegisterLink => Wait.Until((d) =>
        {
            return d.FindElement(By.Id("registerLink"));
        });

        public IWebElement LogInLink => Wait.Until((d) =>
        {
            return d.FindElement(By.Id("loginLink"));
        });

        public IWebElement LogOffLink => Wait.Until((d) =>
        {
            return d.FindElement(By.XPath(@"//*[@id=""logoutForm""]/ul/li[3]/a"));
        });

        public IWebElement CreateArticleButton => Wait.Until((d) =>
        {
            return d.FindElement(By.XPath(@"//*[@id=""logoutForm""]/ul/li[1]/a"));
        });

        public IWebElement LogedUserName => Wait.Until((d) =>
        {
            return d.FindElement(By.XPath(@"//*[@id=""logoutForm""]/ul/li[2]/a"));
        });

        public IWebElement FooterText => Wait.Until((d) =>
        {
            return d.FindElement(By.XPath(@"//html/body/div[2]/footer/p"));
        });

    }
}
