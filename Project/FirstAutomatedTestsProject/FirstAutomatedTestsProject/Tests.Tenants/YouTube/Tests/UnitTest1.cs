using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstAutomatedTestsProject.Test.Common;
using System.Threading;

namespace FirstAutomatedTestsProject
{
    [Ignore]
    [TestClass]
    public class UnitTest1
    {
        [Ignore]
        [TestMethod]
        public void TestMethod1()
        {
            WebHelp.StartWebDriver("Chrome");

            WebHelp.WaitSomeSec(2);
            
            WebHelp.NavigateTo("https://www.youtube.com/");

            WebHelp.WaitSomeSec(2);

            WebHelp.StopWebDriver();

            /*Thread.Sleep(1000);

            WebHelp.StartWebDriver("IE");

            Thread.Sleep(1000);

            WebHelp.StopWebDriver();

            Thread.Sleep(1000);

            WebHelp.StartWebDriver("FireFox");

            Thread.Sleep(1000);

            WebHelp.StopWebDriver();*/ 
        }

        [Ignore]
        [TestMethod]
        public void TestMethod2()
        {
            WebHelp.StartWebDriver("Chrome");

            WebHelp.WaitSomeSec(2);

            WebHelp.NavigateTo("https://www.gmail.com/");

            WebHelp.WaitSomeSec(2);

            WebHelp.StopWebDriver();
        }
    }
}