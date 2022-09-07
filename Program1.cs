using System;

namespace SeleniumThirdApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();

            GoogleMainPage googleMainPage = new GoogleMainPage(driver);
            googleMainPage.GoToLogInPage();

            LogInPageGmail logInPageGmail = new LogInPageGmail(driver);
            logInPageGmail.SelectAccountName();

            MailBoxPageGmail mailBoxPageGmail = new MailBoxPageGmail(driver);
            mailBoxPageGmail.VerifyMailBox();
        }
    }
}
