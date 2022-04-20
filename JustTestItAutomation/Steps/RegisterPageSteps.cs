using JustTestItAutomation.Extension;
using JustTestItAutomation.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace JustTestItAutomation.Steps
{
    [Binding]
    class RegisterPageSteps: BaseStep
    {
        public RegisterPageSteps(IWebDriver driver) : base(driver)
        {
        }
        [Then(@"I click Register link")]
        public void ThenIClickRegisterLink()
        {
            CurrentPage = GetInstance<HomePage>(Driver);
            CurrentPage=CurrentPage.As<HomePage>().clickRegisterLink();
        }

        
           

        [Then(@"I  Register with following Data")]
        public void ThenIRegisterWithFollowingData(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            CurrentPage.As<RegisterPage>().enterRegisterData(data.Email, data.FirstName,
                data.LastName, data.Password, data.ConfirmPassword);
        }

        [Then(@"I should get message ""(.*)""")]
        public void ThenIShouldGetMessage(string message)
        {
            try
            {
                if (Driver.WaitForElement(By.XPath("//div[@class='result alert alert-success']")).Displayed)
                {
                    Assert.AreEqual(message,"Register is successful");
                }
            }
            catch
            {
                if (Driver.WaitForElement(By.XPath("/html/body/my-app/div/main/my-register/div/div/form/div[6]")).Displayed)
                {
                    Assert.AreEqual(message,"User already exist-Enter valid Data","Test Fail");
                }
            }
        }
        [Then(@"I click cancel button")]
        public void ThenIClickCancelButton()
        {
            CurrentPage=CurrentPage.As<RegisterPage>().clickCancelButton();

        }

        [Then(@"I navigate to HomePage")]
        public void ThenINavigateToHomePage()
        {
           Assert.That(CurrentPage.As<HomePage>().validPopuralMakeLink(),"Cancel Button is not working");
        }



    }
}
