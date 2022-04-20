using BoDi;
using JustTestItAutomation.Confin;
using JustTestItAutomation.Helps;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Text;

namespace JustTestItAutomation.Base
{
    public class WebDriverContext
    {
        private readonly IObjectContainer _objectContainer;
        public static IWebDriver driver { set; get; }
        public WebDriverContext(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
            switch (Settings.Browser)
            {

                case "FireFox":
                    driver = new FirefoxDriver();
                    driver.Manage().Window.Maximize();
                    break;
                case "Chrome":
                    driver= new ChromeDriver();
                    driver.Manage().Window.Maximize();
                    break;
                case "IE":
                    driver = new InternetExplorerDriver();
                    driver.Manage().Window.Maximize();
                    break;
            }
            _objectContainer.RegisterInstanceAs(driver);

        }

    }
}