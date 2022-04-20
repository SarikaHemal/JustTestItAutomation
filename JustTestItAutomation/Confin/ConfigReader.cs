using JustTestItAutomation.Helps;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JustTestItAutomation.Confin
{
    public class ConfigReader
    {
        public static void InitializeFrameworkSettings()
        {
            {
                var appRoot = PathHelper.ToApplicationPath("Confin\\settings.json");
                using (StreamReader stream = new StreamReader(appRoot))
                {
                    var json = stream.ReadToEnd();
                    JsonConvert.DeserializeObject<Settings>(json);
                }
            }
        }
    }
}
