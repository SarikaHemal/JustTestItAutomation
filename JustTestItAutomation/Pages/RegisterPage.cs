using JustTestItAutomation.Extension;
using JustTestItAutomation.Steps;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace JustTestItAutomation.Pages
{
    public class RegisterPage: BaseStep
    {
        public RegisterPage(IWebDriver driver) : base(driver) 
        {
        }
        private IWebElement loginTextBox => Driver.WaitForElement(By.Id("username"));
        private IWebElement firstNameTextBox => Driver.WaitForElement(By.Id("firstName"));
        private IWebElement lastNameTextBox => Driver.WaitForElement(By.Id("lastName"));
        private IWebElement passwordTextBox => Driver.WaitForElement(By.Id("password"));
        private IWebElement cirfirmPasswordTextbox => Driver.WaitForElement(By.Id("confirmPassword"));
        private IWebElement regiterButton => Driver.WaitForElement(By.XPath("//button[contains(.,'Register')]"));
        private IWebElement cancelButton => Driver.WaitForElement(By.XPath("//a[contains(.,'Cancel')]"));
        
        public void clickRegisterButton()
        {
            regiterButton.Submit();
        }
        public void enterRegisterData(string email,string firstName,string lastName,string password,string confirmPassword)
        {
            loginTextBox.SendKeys(email);
            firstNameTextBox.SendKeys(firstName);
            lastNameTextBox.SendKeys(lastName);
            passwordTextBox.SendKeys(password);
            cirfirmPasswordTextbox.SendKeys(confirmPassword);
            clickRegisterButton();
            
           //Assert.That(Driver.WaitForElement(By.XPath("//div[@class='result alert alert-success']")).Displayed,"Register is fail");

        }
        public HomePage clickCancelButton()
        {
            cancelButton.Click();
            return new HomePage(Driver);
        }


    }
}
