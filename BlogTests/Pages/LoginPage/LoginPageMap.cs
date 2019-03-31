namespace Blog_Tests.Pages.LoginPage
{
    using OpenQA.Selenium;

    public partial class LoginPage
    {
        public IWebElement Email => Wait.Until((d) =>
        {
            return d.FindElement(By.Id("Email"));
        });

        public IWebElement Password => Wait.Until((d) =>
        {
            return d.FindElement(By.Id("Password"));
        });

        public IWebElement RememberMeTic => Wait.Until((d) =>
        {
            return d.FindElement(By.Id("RememberMe"));
        });

        //  /html/body/div[2]/div/div/form/div[4]/div/input

        public IWebElement LoginButton => Wait.Until((d) =>
        {
            return d.FindElement(By.XPath(@"//html/body/div[2]/div/div/form/div[4]/div/input"));
        });

        public IWebElement LogoffButton => Wait.Until((d) =>
        {
            return d.FindElement(By.XPath(@"//*[@id=""logoutForm""]/ul/li[3]/a"));
        });

        public IWebElement ErrorMessageForInvalidEmail => Wait.Until((d) =>
        {
            return d.FindElement(By.XPath(@"/html/body/div[2]/div/div/form/div[1]/div/span/span"));
        });

        public IWebElement ErrorMessageForNonRegisteredEmail => Wait.Until((d) =>
        {
            return d.FindElement(By.XPath(@"/html/body/div[2]/div/div/form/div[1]/ul/li"));
        });

        public IWebElement ErrorMessageForWrongPassword => Wait.Until((d) =>
        {
            return d.FindElement(By.XPath(@"/html/body/div[2]/div/div/form/div[1]/ul/li"));
        });

        public IWebElement ErrorMessageForMissingEmail => Wait.Until((d) =>
        {
            return d.FindElement(By.XPath(@"/html/body/div[2]/div/div/form/div[1]/div/span/span"));
        });

        public IWebElement ErrorMessageForMissingPassword => Wait.Until((d) =>
        {
            return d.FindElement(By.XPath(@"/html/body/div[2]/div/div/form/div[2]/div/span/span"));
        });

        public IWebElement LoginLink => Wait.Until((d) =>
        {
            return d.FindElement(By.Id("loginLink"));
        });

    }
}
