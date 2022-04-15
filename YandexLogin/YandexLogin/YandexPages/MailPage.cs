using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace YandexPageObject.YandexPages
{
    public class MailPage
    {
        private WebDriver driver;
        public MailPage(WebDriver driver) { this.driver = driver;}
        IWebElement userLabel => driver.FindElement(By.ClassName("username__first-letter"));
        IWebElement lnkLogout => driver.FindElement(By.XPath("//span[contains(text(), 'Выйти')]"));

        public void Logout()
        {
            userLabel.Click();
            lnkLogout.Click();
        }
    }
} 
