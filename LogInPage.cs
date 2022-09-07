using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumSecondApp
{
    class LogInPage:BasePage
    {
       

        public LogInPage(WebDriver driver):base(driver)
        {
          
        }

        public void EnterAccountName(string accountname, string password)
        {
            IWebElement accountnameElement = FindElementByXpath("//input[@name='username']");
            accountnameElement.Click();
            accountnameElement.SendKeys("alenazharina1993");
            IWebElement enterpasswordButtonElement = FindElementByXpath("//span[text()='Enter password']");
            enterpasswordButtonElement.Click();
            IWebElement passwordElement = FindElementByXpath("//input[@name='password']");
            passwordElement.SendKeys("141293zak!");
            IWebElement signInButton = FindElementByXpath("//span[text()='Sign in']");
           
        }
    }
}
