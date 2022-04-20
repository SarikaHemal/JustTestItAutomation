using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace JustTestItAutomation.Base
{
    public class BasePage
    {
        public BasePage CurrentPage { get; set; }

        public TPage GetInstance<TPage>(IWebDriver driver) where TPage : BasePage
        {
            return Activator.CreateInstance(typeof(TPage), driver) as TPage;
        }

        public TPage As<TPage>() where TPage : BasePage
        {
            return (TPage)this;
        }
        
        
    }
}
