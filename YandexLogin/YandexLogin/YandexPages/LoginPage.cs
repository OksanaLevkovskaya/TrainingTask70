using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace YandexPageObject.YandexPages
{
    public class LoginPage
    {
        private WebDriver driver;
        public LoginPage(WebDriver driver) { this.driver = driver; }

        IWebElement txtUserName => driver.FindElement(By.Id("passp-field-login"));
        IWebElement btnProceed => driver.FindElement(By.Id("passp:sign-in"));
        IWebElement txtPassword => driver.FindElement(By.Id("passp-field-passwd"));
        IWebElement btnLogin => driver.FindElement(By.Id("passp:sign-in"));

        string usernameCreds = "mastermister123";
        string passwordCreds = "mastermister1231";

        public void InputUsernameAndPassword()
        {
            txtUserName.Click();
            txtUserName.SendKeys(usernameCreds);
            btnProceed.Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            IWebElement labelDisplayed = wait.Until(e => e.FindElement(By.Id("passp-field-passwd")));
            txtPassword.Click();
            txtPassword.SendKeys(passwordCreds);
        }

        public void ClickLogin()
        {
            btnLogin.Click();
        }

        public void MakeScreenshot()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            IWebElement labelDisplayed = wait.Until(e => e.FindElement(By.ClassName("desk-notif-card__title")));
            Screenshot loggedInScreenshot = ((ITakesScreenshot)driver).GetScreenshot();
            loggedInScreenshot.SaveAsFile("D://User Logged In.png",ScreenshotImageFormat.Png);
        }
    }
}
