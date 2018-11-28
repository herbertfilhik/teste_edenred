using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RelevantCodes.ExtentReports;

namespace CodedUITestProject1
{
    [TestFixture]
    public class BasicReport
    {
        public ExtentReports extent;
        public ExtentTest test;

        [OneTimeSetUp]
        public void StartReport()
        {
            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;

            string reportPath = projectPath + "Reports\\MyOwnReport.html";
            extent = new ExtentReports(reportPath, true);

            extent.AddSystemInfo("Host Name", "Krishna")
                    .AddSystemInfo("Environment", "QA")
                    .AddSystemInfo("User Name","Krishna Sakinala");

            extent.LoadConfig(projectPath + "extent-config.xml");
        }

        [Test]
        public void DemoReportPass()
        {
            test = extent.StartTest("Demo Report Pass");
            Assert.IsTrue(true);
            test.Log(LogStatus.Pass, "Assert Pass as Cond is True");
        }

        [Test]
        public void DemoReportFail()
        {
            test = extent.StartTest("Demo Report Fail");
            Assert.IsTrue(false);
            test.Log(LogStatus.Pass, "Assert Pass as Cond is False");
        }

        [TearDown]
        public void GetResult()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "</pre>";
            var errorMessage = TestContext.CurrentContext.Result.Message;

            if (status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                test.Log(LogStatus.Fail, status + errorMessage);
            }
            extent.EndTest(test);
        }

        [OneTimeTearDown]
        public void EndReport()
        {
            extent.Flush();
            extent.Close();
        }
    }
}
