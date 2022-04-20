using JustTestItAutomation.Confin;
using JustTestItAutomation.Model;
using JustTestItAutomation.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace JustTestItAutomation.Steps
{
    [Binding]
    public class LoginPageSteps: BaseStep
    {
        public LoginPageSteps(IWebDriver driver) : base(driver)
        {
        }
        [Given(@"I have navigated to the application")]
        public void GivenIHaveNavigatedToTheApplication()
        {
            Driver.Navigate().GoToUrl(Settings.AUT);

        }

        [Given(@"I login with valid user")]
        public void GivenILoginWithValidUser(Table table)
        {
            UserDetails details = table.CreateInstance<UserDetails>();
            CurrentPage = GetInstance<LoginPage>(Driver);
            CurrentPage = CurrentPage.As<LoginPage>().Login(details.Username, details.Password);
            Console.WriteLine("Login Success");
        }

        [Then(@"I can validate user name with ""(.*)""")]
        public void ThenICanValidateUserNameWith(string userName)
        {
            Assert.That(CurrentPage.As<HomePage>().isLogin(userName));
        }

        [Then(@"I can not login and get message ""(.*)""")]
        public void ThenICanNotLoginAndGetMessage(string message)
        {
            //Assert.AreEqual(message, Driver.GetMessage());
             Assert.AreEqual(CurrentPage.As<HomePage>().getInValidUserandPasswordMessege(), message);
        }




    }
}
