using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumThirdApp
{
    class LogInPageGmail:BasePage
    {
        public LogInPageGmail(WebDriver driver) : base(driver)
        {

        }

        public void SelectAccountName()
        {
            IWebElement accountname = FindElementByXpath("//div[text()='Алена Жарина']");
            accountname.Click();

            IWebElement password = FindElementByXpath("//input[@name='password']");
            password.Click();
            password.SendKeys("141293zak!@");

            IWebElement continueButton = FindElementByXpath("//span[text()='Далее']");
            continueButton.Click();
        }
    }
}
