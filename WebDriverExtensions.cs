using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.WaitHelpers;

namespace SeleniumSecondApp
{
    class WebDriverExtensions
    {
        public static IWebElement WaitForElement(this IWebDriver driver, By by, TimeSpan timeoutInSeconds)
        {
             var wait = new WebDriverWait(driver)
        }
    }
}
