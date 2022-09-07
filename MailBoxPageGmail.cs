using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumThirdApp
{
    class MailBoxPageGmail:BasePage
    {
        public MailBoxPageGmail(WebDriver driver) : base(driver)
        {

        }
        public void VerifyMailBox()
        {
            IWebElement incomingMails = FindElementByXpath("//a[text()='Входящие']");
            incomingMails.Click();

        }
    }
}
