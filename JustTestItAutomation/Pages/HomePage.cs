using JustTestItAutomation.Extension;
using JustTestItAutomation.Steps;
using OpenQA.Selenium;
using System;


namespace JustTestItAutomation.Pages
{
    public class HomePage: BaseStep
    {
        public HomePage(IWebDriver driver) : base(driver)
        {

        }
        private IWebElement userName => Driver.WaitForElement(By.XPath("//span[contains(.,'Hi, Sarika')]"));
        private IWebElement registerLink => Driver.WaitForElement(By.XPath("//a[contains(.,'Register')]"));
        private IWebElement logOutLink => Driver.WaitForElement(By.XPath("//a[@class='nav-link'][contains(.,'Logout')]"));
        private IWebElement popuralMakeLink => Driver.WaitForElement(By.XPath("//h2[@class='card-header text-xs-center'][contains(.,'Popular Make')]"));
        private IWebElement invadiLoginMessege => Driver.WaitForElement(By.XPath("//span[contains(.,'Invalid username/password')]"));

        public Boolean isLogin(string userName)
        {
            return Driver.WaitForElement(By.XPath("//span[contains(.,'" + userName + "')]")).Displayed;
        }
        public RegisterPage clickRegisterLink()
        {
            registerLink.Click();
            return new RegisterPage(Driver);
        }
        public LoginPage clickLogOut()
        {
            logOutLink.Click();
            return new LoginPage(Driver);
        }
        public Boolean validPopuralMakeLink()
        {
            return popuralMakeLink.Displayed;
            
        }
        public string getInValidUserandPasswordMessege()
        {
            return invadiLoginMessege.Text;
        }
    }
}
