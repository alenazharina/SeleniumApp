using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumThirdApp
{
    class GoogleMainPage
    {
        public WebDriver _driver;

        public GoogleMainPage(WebDriver driver)
        {
            _driver = driver;
        }

        public void GoToLogInPage()
        {
            IWebElement changeLanguageLink = _driver.FindElement(By.XPath("//a[text()='English']"));
            changeLanguageLink.Click();

            IWebElement loginButton = _driver.FindElement(By.XPath("//a[text()='Gmail']"));
            loginButton.Click();
        }
    }
}
