using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace YandexPageObject.YandexPages
{
    public class HomePage
    {
        private WebDriver driver;
        public HomePage(WebDriver driver) { this.driver = driver; }
        IWebElement lnkToLogin => driver.FindElement(By.ClassName("desk-notif-card__login-new-item-title"));
        
        public void ClickLogin() => lnkToLogin.Click();
    }
}
