using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using YandexPageObject.YandexPages;

namespace YandexPageObject.YandexTests
{
    public class Tests
    {
        private WebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://yandex.by/";
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void LoginTest()
        {
            var homePage = new HomePage(driver);
            var loginPage = new LoginPage(driver);
            var mailPage = new MailPage(driver);

            homePage.ClickLogin();
            loginPage.InputUsernameAndPassword();
            loginPage.ClickLogin();

            var userLabelDisplayed = driver.FindElement(By.ClassName("desk-notif-card__title")).Text;
            var userLoggedInLabel = "mastermister567";
            Assert.AreEqual(userLabelDisplayed, userLoggedInLabel, "User Label doesn't match.");
        }

        [Test]
        public void LogoutTest()
        {
            var homePage = new HomePage(driver);
            var loginPage = new LoginPage(driver);
            var mailPage = new MailPage(driver);

            homePage.ClickLogin();
            loginPage.InputUsernameAndPassword();
            loginPage.ClickLogin();
            mailPage.Logout();

            var actualpageTitle = driver.Title;
            string expectedPageTitle = "Яндекс";
            Assert.AreEqual(expectedPageTitle, actualpageTitle, "Page title doesn't match");
        }
    }
}
 