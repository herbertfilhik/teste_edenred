using BoDi;
using OpenQA.Selenium;
using System;
using System.Configuration;
using System.Threading;
using TechTalk.SpecFlow;
using CodedUITestProject1.Funcionalidade;

namespace CodedUITestProject1
{
    [Binding]
    [Scope(Tag = "TestScenario")]
    [Scope(Tag = "MassaReaproveitavel")]
    [Scope(Tag = "MassaNaoReaproveitavel")]

    public class Steps
    {

        private WebDriver _webDriver;
        AssertUtils assertUtils;
        ElementUtils elementUtils;
        JavaScriptExecute javaScriptExecute;

        protected string DataMass => ConfigurationManager.AppSettings["DataMass"];

        private readonly IObjectContainer _objectContainer;



        public Steps(WebDriver webDriver, IObjectContainer objectContainer)
        {
            _webDriver = webDriver;
            _webDriver.Current.Manage().Window.Maximize();
            elementUtils = new ElementUtils(webDriver);
            assertUtils = new AssertUtils(webDriver);
            javaScriptExecute = new JavaScriptExecute(webDriver);

            _objectContainer = objectContainer;

        }

        //##############################################################################################
        //[ Métodos Gancho(Hooks) ]#####################################################################

        [BeforeFeature]
        public static void BeforeFeature()
        {
        }

        [BeforeScenario]
        public void before()
        {
            Console.WriteLine("Running feature -> " + FeatureContext.Current.FeatureInfo.Title);
            Console.WriteLine("Running feature  -> " + ScenarioContext.Current.ScenarioInfo.Title);
        }

        [AfterStep]
        public void InsertReportingSteps()
        {
        }

        [BeforeTestRun]
        public static void InitializeReport()
        {
        }

        [AfterTestRun]
        public static void TearDownReport()
        {
        }

        [AfterScenario]
        public void tearDown()
        {

            var driver = _webDriver.Current;

            if (_webDriver != null)
            {
                _webDriver.Quit();
            }

            if (ScenarioContext.Current.TestError != null)
            {
                Console.WriteLine("An error ocurred: " + ScenarioContext.Current.TestError.Message);

                //Here we can take screenshot
                //Screenshot screenshotdriver = ((ITakesScreenshot))

                ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(@"C:\teste_edenred\teste_edenred\TestResults\teste.png");

            }
        }

        //##############################################################################################
        //[ Métodos Given ]#############################################################################

        [Given(@"que estou na página ""(.*)""")]
        [Given(@"que eu acesse a pagina ""(.*)""")]
        public void StepPages(string url)
        {
            var driver = _webDriver.Current;

            switch (url)
            {
                case "Edenred":
                    driver.Url = "https://www.edenredprepagos.com.br/";
                    ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(@"C:\teste_edenred\teste_edenred\TestResults\teste1.png");
                    break;
                default:
                    break;
            }
        }

        //##############################################################################################
        //[ Métodos When ]##############################################################################

        [When(@"eu aguardar por ""(.*)"" segundos")]
        public void StepWait(int waitTime)
        {

            var driver = _webDriver.Current;

            Thread.Sleep(TimeSpan.FromSeconds(waitTime));
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(@"C:\teste_edenred\teste_edenred\TestResults\teste2.png");
        }

        [When(@"eu clicar no botão ""(.*)""")]
        [When(@"eu clicar no link ""(.*)""")]
        [When(@"eu clicar no campo ""(.*)""")]
        [When(@"eu clicar no ícone ""(.*)""")]
        public void StepElementClick(string element)
        {
            var driver = _webDriver.Current;

            elementUtils.MethodElementClick(element);
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(@"C:\teste_edenred\teste_edenred\TestResults\teste3.png");
        }

        [When(@"no campo ""(.*)"" eu digitar ""(.*)""")]
        public void StepElementFieldSendKeys(string elementDataType, string element)
        {
            var driver = _webDriver.Current;

            elementUtils.MethodElementFieldSendKeys(elementDataType, element);
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(@"C:\teste_edenred\teste_edenred\TestResults\teste4.png");
        }


        //##############################################################################################
        //[ Métodos Then ]##############################################################################

        [Then(@"rolando para baixo o sistema apresenta os dados")]
        public void EntaoRolandoParaBaixoOSistemaApresentaOsDados()
        {
            var driver = _webDriver.Current;

            javaScriptExecute.Executescript2(_webDriver);
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(@"C:\teste_edenred\teste_edenred\TestResults\teste5.png");
        }
    }
}