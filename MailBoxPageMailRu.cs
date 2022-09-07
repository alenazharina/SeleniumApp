using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumSecondApp
{
    class MailBoxPageMailRu:BasePage
    {
        public MailBoxPageMailRu(WebDriver driver):base(driver)
        {

        }

        public void SendMessage()
        {
            IWebElement writeMessageButton = FindElementByXpath("//span[text()='Написать письмо']");
            writeMessageButton.Click();
            IWebElement recipientTexrBox = FindElementByXpath("/html/body/div[1]/div/div[2]/div/div/div/div[2]/div[3]/div[2]/div/div/div[1]/div/div[2]/div/div/label/div/div/input");
            recipientTexrBox.Click();
            recipientTexrBox.SendKeys("alenazharina93@gmail.com");
            IWebElement contentArea = FindElementByXpath("/html/body/div[1]/div/div[2]/div/div/div/div[2]/div[3]/div[5]/div/div/div[2]/div[1]");
            contentArea.Click();
            contentArea.SendKeys("Hello!");
            IWebElement sendButton = FindElementByXpath("//span[text()='Отправить']");
            sendButton.Click();
        }
    }
}
