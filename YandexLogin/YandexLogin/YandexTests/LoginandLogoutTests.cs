using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using YandexPageObject.YandexPages;
using NUnit.Framework.Interfaces;

namespace YandexPageObject.YandexTests
{
    public class Tests
    {
        public WebDriver driver;

        [Test]
        [Obsolete]
        public void LoginTestChrome()
        {
            var browserOptions = new ChromeOptions();
            browserOptions.PlatformName = "macOS 11.00";
            browserOptions.BrowserVersion = "latest";

            var sauceOptions = new Dictionary<string, object>();
            sauceOptions.Add("name", TestContext.CurrentContext.Test.Name);
            sauceOptions.Add("username", Environment.GetEnvironmentVariable("oksana11"));
            sauceOptions.Add("accessKey", Environment.GetEnvironmentVariable("2fecefe3-5e9f-4282-acca-0b62c552f0da"));

            driver = new RemoteWebDriver(new Uri("https://oksana11:2fecefe3-5e9f-4282-acca-0b62c552f0da@ondemand.us-west-1.saucelabs.com:443/wd/hub"), browserOptions.ToCapabilities(),
               TimeSpan.FromSeconds(600));

            driver.Navigate().GoToUrl("https://yandex.by/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            
            var homePage = new HomePage(driver);
            var loginPage = new LoginPage(driver);

            homePage.ClickLogin();
            loginPage.InputUsernameAndPassword("mastermister123", "mastermister1231");
            loginPage.ClickLogin();
            loginPage.MakeScreenshot();

            var userLabelDisplayed = driver.FindElement(By.ClassName("desk-notif-card__title")).Text;
            var userLoggedInLabel = "mastermister123";
            Assert.AreEqual(userLabelDisplayed, userLoggedInLabel, "User Label doesn't match."); 
        }

       
        [Test]
        [Obsolete]
        public void LoginTestEdge()
        {
            var browserOptions = new EdgeOptions();
            browserOptions.PlatformName = "Windows 10";
            browserOptions.BrowserVersion = "latest";

            var sauceOptions = new Dictionary<string, object>();
            sauceOptions.Add("name", TestContext.CurrentContext.Test.Name);
            sauceOptions.Add("username", Environment.GetEnvironmentVariable("oksana11"));
            sauceOptions.Add("accessKey", Environment.GetEnvironmentVariable("2fecefe3-5e9f-4282-acca-0b62c552f0da"));

            driver = new RemoteWebDriver(new Uri("https://oksana11:2fecefe3-5e9f-4282-acca-0b62c552f0da@ondemand.us-west-1.saucelabs.com:443/wd/hub"), browserOptions.ToCapabilities(),
               TimeSpan.FromSeconds(600));

            driver.Navigate().GoToUrl("https://yandex.by/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            var homePage = new HomePage(driver);
            var loginPage = new LoginPage(driver);

            homePage.ClickLogin();
            loginPage.InputUsernameAndPassword("mastermister123", "mastermister1231");
            loginPage.ClickLogin();
            loginPage.MakeScreenshot();

            var userLabelDisplayed = driver.FindElement(By.ClassName("desk-notif-card__title")).Text;
            var userLoggedInLabel = "mastermister123";
            Assert.AreEqual(userLabelDisplayed, userLoggedInLabel, "User Label doesn't match.");


        }

        [Test]
        [Obsolete]
        public void LoginTestFirefox()
        {
            var browserOptions = new FirefoxOptions();
            browserOptions.PlatformName = "Windows 8.1";
            browserOptions.BrowserVersion = "latest";

            var sauceOptions = new Dictionary<string, object>();
            sauceOptions.Add("name", TestContext.CurrentContext.Test.Name);
            sauceOptions.Add("username", Environment.GetEnvironmentVariable("oksana11"));
            sauceOptions.Add("accessKey", Environment.GetEnvironmentVariable("2fecefe3-5e9f-4282-acca-0b62c552f0da"));

            driver = new RemoteWebDriver(new Uri("https://oksana11:2fecefe3-5e9f-4282-acca-0b62c552f0da@ondemand.us-west-1.saucelabs.com:443/wd/hub"), browserOptions.ToCapabilities(),
               TimeSpan.FromSeconds(600));
            driver.Navigate().GoToUrl("https://yandex.by/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            var homePage = new HomePage(driver);
            var loginPage = new LoginPage(driver);

            homePage.ClickLogin();
            loginPage.InputUsernameAndPassword("mastermister123", "mastermister1231");
            loginPage.ClickLogin();
            loginPage.MakeScreenshot();

            var userLabelDisplayed = driver.FindElement(By.ClassName("desk-notif-card__title")).Text;
            var userLoggedInLabel = "mastermister123";
            Assert.AreEqual(userLabelDisplayed, userLoggedInLabel, "User Label doesn't match.");
        }

        [Test]
        [Obsolete]
        public void LogoutTestChrome()
        {
            var browserOptions = new ChromeOptions();
            browserOptions.PlatformName = "macOS 11.00";
            browserOptions.BrowserVersion = "latest";

            var sauceOptions = new Dictionary<string, object>();
            sauceOptions.Add("name", TestContext.CurrentContext.Test.Name);
            sauceOptions.Add("username", Environment.GetEnvironmentVariable("oksana11"));
            sauceOptions.Add("accessKey", Environment.GetEnvironmentVariable("2fecefe3-5e9f-4282-acca-0b62c552f0da"));

            driver = new RemoteWebDriver(new Uri("https://oksana11:2fecefe3-5e9f-4282-acca-0b62c552f0da@ondemand.us-west-1.saucelabs.com:443/wd/hub"), browserOptions.ToCapabilities(),
               TimeSpan.FromSeconds(600));

            driver.Navigate().GoToUrl("https://yandex.by/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            var homePage = new HomePage(driver);
            var loginPage = new LoginPage(driver);
            var mailPage = new MailPage(driver);

            homePage.ClickLogin();
            loginPage.InputUsernameAndPassword("mastermister123", "mastermister1231");
            loginPage.ClickLogin();
            mailPage.Logout();


            var actualpageTitle = driver.Title;
            string expectedPageTitle = "Яндекс";
            Assert.AreEqual(expectedPageTitle, actualpageTitle, "Page title doesn't match");
            driver.Quit();
        }

        [Test]
        [Obsolete]
        public void LogoutTestEdge()
        {
            var browserOptions = new EdgeOptions();
            browserOptions.PlatformName = "Windows 10";
            browserOptions.BrowserVersion = "latest";

            var sauceOptions = new Dictionary<string, object>();
            sauceOptions.Add("name", TestContext.CurrentContext.Test.Name);
            sauceOptions.Add("username", Environment.GetEnvironmentVariable("oksana11"));
            sauceOptions.Add("accessKey", Environment.GetEnvironmentVariable("2fecefe3-5e9f-4282-acca-0b62c552f0da"));

            driver = new RemoteWebDriver(new Uri("https://oksana11:2fecefe3-5e9f-4282-acca-0b62c552f0da@ondemand.us-west-1.saucelabs.com:443/wd/hub"), browserOptions.ToCapabilities(),
               TimeSpan.FromSeconds(600));
            driver.Navigate().GoToUrl("https://yandex.by/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            var homePage = new HomePage(driver);
            var loginPage = new LoginPage(driver);
            var mailPage = new MailPage(driver);

            homePage.ClickLogin();
            loginPage.InputUsernameAndPassword("mastermister123", "mastermister1231");
            loginPage.ClickLogin();
            mailPage.Logout();


            var actualpageTitle = driver.Title;
            string expectedPageTitle = "Яндекс";
            Assert.AreEqual(expectedPageTitle, actualpageTitle, "Page title doesn't match");
            driver.Quit();
        }

        [Test]
        [Obsolete]
        public void LogoutTestFirefox()
        {
            var browserOptions = new FirefoxOptions();
            browserOptions.PlatformName = "Windows 8.1";
            browserOptions.BrowserVersion = "latest";

            var sauceOptions = new Dictionary<string, object>();
            sauceOptions.Add("name", TestContext.CurrentContext.Test.Name);
            sauceOptions.Add("username", Environment.GetEnvironmentVariable("oksana11"));
            sauceOptions.Add("accessKey", Environment.GetEnvironmentVariable("2fecefe3-5e9f-4282-acca-0b62c552f0da"));

            driver = new RemoteWebDriver(new Uri("https://oksana11:2fecefe3-5e9f-4282-acca-0b62c552f0da@ondemand.us-west-1.saucelabs.com:443/wd/hub"), browserOptions.ToCapabilities(),
               TimeSpan.FromSeconds(600));
            driver.Navigate().GoToUrl("https://yandex.by/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            var homePage = new HomePage(driver);
            var loginPage = new LoginPage(driver);
            var mailPage = new MailPage(driver);

            homePage.ClickLogin();
            loginPage.InputUsernameAndPassword("mastermister123", "mastermister1231");
            loginPage.ClickLogin();
            mailPage.Logout();


            var actualpageTitle = driver.Title;
            string expectedPageTitle = "Яндекс";
            Assert.AreEqual(expectedPageTitle, actualpageTitle, "Page title doesn't match");
            driver.Quit();
        }


        [TearDown]
        public void CleanUpAfterEveryTestMethod1()
        {
            var passed = TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Passed;
            ((IJavaScriptExecutor)driver).ExecuteScript("sauce:job-result=" + (passed ? "passed" : "failed"));
            driver?.Quit();
        }
    }
}
 