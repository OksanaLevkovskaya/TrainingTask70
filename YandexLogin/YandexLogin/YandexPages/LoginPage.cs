using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace YandexPageObject.YandexPages
{
    public class LoginPage
    {
        private WebDriver driver;
        public LoginPage(WebDriver driver) { this.driver = driver; }

        IWebElement txtUserName => driver.FindElement(By.Id("passp-field-login"));
        IWebElement btnProceed => driver.FindElement(By.Id("passp:sign-in"));
        IWebElement txtPassword => driver.FindElement(By.Name("passwd"));
        IWebElement btnLogin => driver.FindElement(By.Id("passp:sign-in"));

        string usernameCreds = "mastermister567";
        string passwordCreds = "mastermister5675";

        public void InputUsernameAndPassword()
        {
            txtUserName.Click();
            txtUserName.SendKeys(usernameCreds);
            btnProceed.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            txtPassword.Click();
            txtPassword.SendKeys(passwordCreds);
        }

        public void ClickLogin()
        {
            btnLogin.Click();
        } 
    }
}
