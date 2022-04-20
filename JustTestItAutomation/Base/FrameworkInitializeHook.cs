using JustTestItAutomation.Confin;
using JustTestItAutomation.Helps;
using System;
using System.Collections.Generic;
using System.Text;

namespace JustTestItAutomation.Base
{
    public class FrameworkInitializeHook
    {
        public void InitializeSettings()
        {
            ConfigReader.InitializeFrameworkSettings();

            _ = new ReportContext();
        }

    }
}
