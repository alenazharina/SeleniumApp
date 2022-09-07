using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumSecondApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://mail.ru/");
            driver.Manage().Window.Maximize();

            MailRuMainPage mailRuMainPage = new MailRuMainPage(driver);
            mailRuMainPage.GoToLogInPage();

            LogInPage logInPage = new LogInPage(driver);
            logInPage.EnterAccountName();

            MailBoxPageMailRu mailBoxPageMailRu = new MailBoxPageMailRu(driver);
            mailBoxPageMailRu.SendMessage();
        }
    }
}
