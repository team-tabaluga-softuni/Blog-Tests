namespace Blog_Tests
{
    using Blog_Tests.Models;
    using Blog_Tests.Pages.ChangePassword;
    using Blog_Tests.Pages.CreateEditDelArticle;
    using Blog_Tests.Pages.HeaderAndFooter;
    using Blog_Tests.Pages.HomePage;
    using Blog_Tests.Pages.LoginPage;
    using Blog_Tests.Pages.RegisterPage;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Support.UI;
    using System;
    using System.IO;
    using System.Reflection;
    using System.Threading;

    [TestFixture]
    public class Blog_SoftUni_Integration_Test
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        private HeaderAndFooter headerAndFooter;
        private ChangePassword changePassword;
        private CreateEditDelArticle createEditDelArticle;
        private HomePage homePage;
        private LoginPage loginPage;
        private RegisterPage regPage;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            headerAndFooter = new HeaderAndFooter(driver);
            changePassword = new ChangePassword(driver);
            createEditDelArticle = new CreateEditDelArticle(driver);
            homePage = new HomePage(driver);
            loginPage = new LoginPage(driver);
            regPage = new RegisterPage(driver);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }


        // SoftUni Blog HomePage 

        [Test]
        [Author("Kalina")]
        public void EnterBlogSoftUni()
        {

            driver.Navigate().GoToUrl(homePage.HomepageUrl);

            string urlHP = driver.Url;

            Assert.AreEqual(homePage.HomepageUrl, urlHP);

        }

        [Test]
        [Author("Kalina")]
        public void CheckHeaderOnHomePageSoftUniBlogContainSoftUniBlogLink()
        {

            driver.Navigate().GoToUrl(homePage.HomepageUrl);

            var checkForSoftUniButt = headerAndFooter.SoftUniBlogLink.Text;

            Assert.AreEqual("SOFTUNI BLOG", checkForSoftUniButt);

        }

        [Test]
        [Author("Kalina")]
        public void CheckOnHeaderSoftUniLinksnavigateToHomePage()
        {

            driver.Navigate().GoToUrl(homePage.HomepageUrl);

            headerAndFooter.SoftUniBlogLink.Click();

            string urlHP = driver.Url;

            Assert.AreEqual(homePage.HomepageUrl, urlHP);

        }

        [Test]
        [Author("Kalina")]
        public void CheckOnHeaderRegisterLinksnavigateToRegisterPage()
        {

            driver.Navigate().GoToUrl(homePage.HomepageUrl);

            headerAndFooter.RegisterLink.Click();

            string urlRegisterPage = driver.Url;

            var registerTextOnRegisterPage = driver.FindElement(By.CssSelector("body > div.container.body-content > div > div > h2")).Text;

            Assert.AreEqual(regPage.RegisterPageUrl, urlRegisterPage);
            Assert.AreEqual("Register", registerTextOnRegisterPage);
        }

        [Test]
        [Author("Kalina")]
        public void CheckOnHeaderLogInLinksnavigateToRegisterPage()
        {

            driver.Navigate().GoToUrl(homePage.HomepageUrl);

            headerAndFooter.LogInLink.Click();

            string urlLoginPage = driver.Url;
            var loginTextOnRegisterPage = driver.FindElement(By.CssSelector("body > div.container.body-content > div > div > h2")).Text;

            Assert.AreEqual(loginPage.LoginPageUrl, urlLoginPage);
            Assert.AreEqual("Log in", loginTextOnRegisterPage);

        }

        [Test]
        [Author("Kalina")]
        public void CheckFooterCopyrightIsPresent()
        {

            driver.Navigate().GoToUrl(homePage.HomepageUrl);

            Assert.AreEqual("© 2019 - SoftUni Blog", headerAndFooter.FooterText.Text);

        }

        // SoftUni Blog RegisterPage 
        [Test]
        [Author("Nina Petrova")]
        [Category("RegistrationPage Tests")]
        public void RegistrationWithValidData()
        {
            var path = Path.GetFullPath(Directory.GetCurrentDirectory() +
             "/../../../Jsons/ValidRegisterForm.json");
            var user = RegisterUser.FromJson(File.ReadAllText(path));

            //var user = new RegisterUserRandom("kalina" + random.Next(50, 200) + "@gmail.bg", "maraton" + random.Next(50, 250), "1234", "1234");

            regPage.NavigateTo();
            regPage.FillRegisterForm(user);

            Assert.IsTrue(regPage.LogOffButton.Displayed);
            Assert.AreEqual("Hello {user's email}!", regPage.RegisterPageHeaderMessage.Text);
        }

        [Test]
        [Author("Nina Petrova")]
        [Category("RegistrationPage Tests")]
        public void RegistrationWithDuplicatedEmail()
        {
            var path = Path.GetFullPath(Directory.GetCurrentDirectory() +
               "/../../../Jsons/ValidRegisterForm.json");

            var user = RegisterUser.FromJson(File.ReadAllText(path));

            regPage.NavigateTo();
            regPage.FillRegisterForm(user);
            //Fail
            Assert.IsTrue(regPage.ErrorMessageForInvalidEmail.Displayed);
            Assert.AreEqual("This email is already exists", regPage.ErrorMessageForInvalidEmail.Text);
        }

        [Test]
        [Author("Nina Petrova")]
        [Category("RegistrationPage Tests")]
        public void RegistrationWithInvalidEmail()
        {
            var path = Path.GetFullPath(Directory.GetCurrentDirectory() +
                "/../../../Jsons/RegistrationWithInvalidEmail.json");

            var user = RegisterUser.FromJson(File.ReadAllText(path));

            regPage.NavigateTo();
            regPage.FillRegisterForm(user);

            Assert.AreEqual("The Email field is not a valid e-mail address.", regPage.ErrorMessageForInvalidEmail.Text);
        }

        [Test]
        [Author("Nina Petrova")]
        [Category("RegistrationPage Tests")]
        public void RegistrationWithEmptyEmailField()
        {
            var path = Path.GetFullPath(Directory.GetCurrentDirectory() +
               "/../../../Jsons/RegistrationWithEmptyEmail.json");

            var user = RegisterUser.FromJson(File.ReadAllText(path));

            regPage.NavigateTo();
            regPage.FillRegisterForm(user);

            Assert.AreEqual("The Email field is required.", regPage.ErrorEmptyEmailFieldMessage.Text);
        }

        [Test]
        [Author("Petya")]
        [Category("LoginPage Tests")]
        public void LoginWithValidData()
        {
            var path = Path.GetFullPath(Directory.GetCurrentDirectory() +
               "/../../../Jsons/ValidLoginForm.json");

            var user = LoginUser.FromJson(File.ReadAllText(path));

            loginPage.NavigateTo();
            loginPage.FillForm(user);
            loginPage.SubmitLoginButton();
            
            Assert.IsTrue(loginPage.LogoffButton.Displayed);
        }

        [Test]
        [Author("Petya")]
        [Category("LoginPage Tests")]
        public void LoginWithInvalidEmail()
        {
            var path = Path.GetFullPath(Directory.GetCurrentDirectory() +
               "/../../../Jsons/LoginWithInvalidEmail.json");

            var user = LoginUser.FromJson(File.ReadAllText(path));

            loginPage.NavigateTo();
            loginPage.FillForm(user);
            
            Assert.IsTrue(loginPage.ErrorMessageForInvalidEmail.Displayed);
            Assert.AreEqual("The Email field is not a valid e-mail address.", loginPage.ErrorMessageForInvalidEmail.Text);
        }

        [Test]
        [Author("Petya")]
        [Category("LoginPage Tests")]
        public void LoginWithNotRegisteredEmail()
        {
            var path = Path.GetFullPath(Directory.GetCurrentDirectory() +
               "/../../../Jsons/LoginWithNotRegisteredEmail.json");

            var user = LoginUser.FromJson(File.ReadAllText(path));

            loginPage.NavigateTo();
            loginPage.FillForm(user);
            loginPage.SubmitLoginButton();

            Assert.IsTrue(loginPage.ErrorMessageForNonRegisteredEmail.Displayed);
            Assert.AreEqual("Invalid login attempt.", loginPage.ErrorMessageForNonRegisteredEmail.Text);
        }

        [Test]
        [Author("Petya")]
        [Category("LoginPage Tests")]
        public void LoginWithInvalidPassword()
        {
            var path = Path.GetFullPath(Directory.GetCurrentDirectory() +
               "/../../../Jsons/LoginWithInvalidPassword.json");

            var user = LoginUser.FromJson(File.ReadAllText(path));

            loginPage.NavigateTo();
            loginPage.FillForm(user);
            loginPage.SubmitLoginButton();

            Assert.IsTrue(loginPage.ErrorMessageForWrongPassword.Displayed);
            Assert.AreEqual("Invalid login attempt.", loginPage.ErrorMessageForWrongPassword.Text);
        }

        [Test]
        [Author("Petya")]
        [Category("LoginPage Tests")]
        public void LoginWithoutEmailAndPassword()
        {
            loginPage.NavigateTo();
            loginPage.SubmitLoginButton();

            Assert.IsTrue(loginPage.ErrorMessageForMissingEmail.Displayed);
            Assert.AreEqual("The Email field is required.", loginPage.ErrorMessageForMissingEmail.Text);
            Assert.IsTrue(loginPage.ErrorMessageForMissingPassword.Displayed);
            Assert.AreEqual("The Password field is required.", loginPage.ErrorMessageForMissingPassword.Text);
        }

        [Test]
        [Author("Petya")]
        [Category("LoginPage Tests")]
        public void LogOff()
        {
            var path = Path.GetFullPath(Directory.GetCurrentDirectory() +
               "/../../../Jsons/ValidLoginForm.json");

            var user = LoginUser.FromJson(File.ReadAllText(path));

            loginPage.NavigateTo();
            loginPage.FillForm(user);
            loginPage.SubmitLoginButton();
            loginPage.LogoffButton.Click();

            Assert.IsTrue(loginPage.LoginLink.Displayed);
            Assert.AreEqual("Log in", loginPage.LoginLink.Text);
        }
    }
}
