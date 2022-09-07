using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumSecondApp
{
    class MailRuMainPage
    {
        public WebDriver _driver;

        public MailRuMainPage(WebDriver driver)
        {
            _driver = driver;
        }

        public void GoToLogInPage()
        {
            IWebElement signinButton = _driver.FindElement(By.XPath("/html/body/main/div[2]/div[1]/div[2]/div/div[1]/button"));
            signinButton.Click();

        }

    }
}
