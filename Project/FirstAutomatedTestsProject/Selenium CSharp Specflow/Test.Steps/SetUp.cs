using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Selenium_CSharp_Specflow
{
    public static class SetUp
    {
        public static string projectPath = (Directory.GetParent(Directory.GetCurrentDirectory()).FullName + "\\").Replace("\\bin\\Debug\\", "");
        public static string driverPath = projectPath + "\\Test.Common\\Webdrivers\\";
        public static string resultsPath = projectPath + "TestResults\\";
        public static string resultName = "Selenium CSharp SpecFlow Default" + DateTime.Now.ToString("yyyy-MM-ddHHmmss") + "_";
    }
}
