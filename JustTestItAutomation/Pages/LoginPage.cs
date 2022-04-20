using JustTestItAutomation.Extension;
using JustTestItAutomation.Steps;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace JustTestItAutomation.Pages
{
    public class LoginPage : BaseStep
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {

        }

        private IWebElement EmailTxt => Driver.WaitForElement(By.Name("login"));
        private IWebElement PasswordTxt => Driver.WaitForElement(By.Name("password"));
        private IWebElement LoginBtn => Driver.WaitForElement(By.XPath("//button[@type='submit']"));
        public HomePage Login(string userName, string password)
        {
            EmailTxt.SendKeys(userName);
            PasswordTxt.SendKeys(password);
            LoginBtn.Click();
            Thread.Sleep(3000);
            return new HomePage(Driver);
        }
        public string LoginPageTitle()
        {
            return Driver.Title;
        }

    }
}