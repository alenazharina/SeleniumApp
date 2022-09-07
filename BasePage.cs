using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumSecondApp
{
    public abstract class BasePage
    {
        protected WebDriver _driver;

        public BasePage(WebDriver driver)
        {
            _driver = driver; 
        }

        public IWebElement FindElementByXpath(string xpath)
        {
            IWebElement element = null;

            int attempsNumber = 0;
            while (attempsNumber < 10)
            {
                try
                {
                    element = _driver.FindElement(By.XPath(xpath));
                }

                catch (Exception exception)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("Can't find element, try again");
                }
                if(element != null)
                {
                    break;
                }

                attempsNumber++;
            }

            return element;

        } 
    }
}
