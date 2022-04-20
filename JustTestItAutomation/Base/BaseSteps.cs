using JustTestItAutomation.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace JustTestItAutomation.Steps
{
    [Binding]
    public class BaseStep : BasePage
    {
        protected IWebDriver Driver { get; }
        public BaseStep(IWebDriver driver)
        {
            Driver = driver;
        }

    }
}
