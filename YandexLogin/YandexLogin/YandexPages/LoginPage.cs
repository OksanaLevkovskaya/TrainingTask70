using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace YandexPageObject.YandexPages
{
    public class LoginPage
    {
        private WebDriver driver;
        public LoginPage(WebDriver driver) { this.driver = driver; }

        IWebElement TxtUserName => driver.FindElement(By.Id("passp-field-login"));
        IWebElement BtnProceed => driver.FindElement(By.Id("passp:sign-in"));
        IWebElement TxtPassword => driver.FindElement(By.Id("passp-field-passwd"));
        IWebElement BtnLogin => driver.FindElement(By.Id("passp:sign-in"));

        public void InputUsernameAndPassword(string username, string password)
        {
            TxtUserName.Click();
            TxtUserName.SendKeys(username);
            BtnProceed.Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            IWebElement labelDisplayed = wait.Until(e => e.FindElement(By.Id("passp-field-passwd")));
            TxtPassword.Click();
            TxtPassword.SendKeys(password);
        }

        public void ClickLogin()
        {
            BtnLogin.Click();
        }

        public void MakeScreenshot()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            IWebElement LabelDisplayed = wait.Until(e => e.FindElement(By.ClassName("desk-notif-card__title")));
            Screenshot loggedInScreenshot = ((ITakesScreenshot)driver).GetScreenshot();
            string saveToPath = Directory.GetCurrentDirectory();
            loggedInScreenshot.SaveAsFile(saveToPath, ScreenshotImageFormat.Png);
        }
    }
}
