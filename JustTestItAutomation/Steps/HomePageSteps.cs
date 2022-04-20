using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace JustTestItAutomation.Steps
{
    [Binding]
    public class HomePageSteps: BaseStep
    {
        public HomePageSteps(IWebDriver driver) : base(driver)
        {
        }
    }
}
