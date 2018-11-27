using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using System.IO;
using System;

namespace CodedUITestProject1.Funcionalidade
{
    public class ElementUtils
    {
        private WebDriver _webDriver;
        JObject dataMass;
        JavaScriptExecute jsExecute;


        public ElementUtils(WebDriver webDriver)
        {
            _webDriver = webDriver;
            jsExecute = new JavaScriptExecute(webDriver);
        }


        public void MethodElementClick(string element)
        {

            var driver = _webDriver.Current;

            switch (element)
            {
                case "Blog":
                    _webDriver.Wait.Until(el => el.FindElement(By.XPath("/html/body/nav/div/div/a[5]"))).Click();
                    ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(@"C:\teste_edenred\teste_edenred\TestResults\teste6.png");
                    break;
                case "Buscar":
                    _webDriver.Wait.Until(el => el.FindElement(By.XPath("/html/body/article/div/div[2]/div/div[2]/form/input[2]"))).Click();
                    ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(@"C:\teste_edenred\teste_edenred\TestResults\teste7.png");
                    break;
                case "Assinar":
                    _webDriver.Wait.Until(el => el.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div/div/a/div"))).Click();
                    ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(@"C:\teste_edenred\teste_edenred\TestResults\teste8.png");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }

        public void MethodElementFieldSendKeys(string elementDataType, string element)
        {

            var driver = _webDriver.Current;

            switch (elementDataType)
            {
                case "O que você procura":
                    _webDriver.Wait.Until(el => el.FindElement(By.Id("s"))).SendKeys(element);
                    ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(@"C:\teste_edenred\teste_edenred\TestResults\teste9.png");
                    break;
                default:
                    break;
            }
        }


    }
}