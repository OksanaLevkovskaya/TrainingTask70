using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace YandexPageObject.YandexPages
{
    public class MailPage
    {
        private WebDriver driver;
        public MailPage(WebDriver driver) { this.driver = driver;}
        IWebElement UserLabel => driver.FindElement(By.ClassName("desk-notif-card__title"));
        IWebElement LnkLogout => driver.FindElement(By.CssSelector("a[aria-label='Выйти']"));

        public void Logout()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            IWebElement LabelDisplayed = wait.Until(e => e.FindElement(By.ClassName("desk-notif-card__title")));
            UserLabel.Click();
            LnkLogout.Click();
        }
    }
} 
