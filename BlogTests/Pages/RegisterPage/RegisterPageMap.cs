namespace Blog_Tests.Pages.RegisterPage
{
    using OpenQA.Selenium;

    public partial class RegisterPage
    {
        public IWebElement Email => Wait.Until((d) =>
        {
            return d.FindElement(By.Id("Email"));
        });

        public IWebElement FullName => Wait.Until((d) =>
        {
            return d.FindElement(By.Id("FullName"));
        });

        public IWebElement Password => Wait.Until((d) =>
        {
            return d.FindElement(By.Id("Password"));
        });

        public IWebElement ConfirmPassword => Wait.Until((d) =>
        {
            return d.FindElement(By.Id("ConfirmPassword"));
        });

        public IWebElement RegisterButton => Wait.Until((d) =>
        {
            return d.FindElement(By.XPath(@"/html/body/div[2]/div/div/form/div[6]/div/input"));
        });

        public IWebElement LogOffButton => Wait.Until((d) =>
        {
            return d.FindElement(By.Id("logoutForm"));
        });

        public IWebElement RegisterPageHeaderMessage => Wait.Until((d) =>
        {
            return d.FindElement(By.CssSelector("#logoutForm > ul > li:nth-child(2) > a"));
        });

        public IWebElement ErrorMessageForInvalidEmail => Wait.Until((d) =>
        {
            return d.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li"));
        });

        public IWebElement ErrorEmptyEmailFieldMessage => Wait.Until((d) =>
        {
            return d.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li"));
        });
    }
}
