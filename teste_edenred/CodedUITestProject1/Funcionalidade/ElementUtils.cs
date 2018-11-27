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
            switch (element)
            {
                case "Blog":
                    _webDriver.Wait.Until(el => el.FindElement(By.XPath("/html/body/nav/div/div/a[5]"))).Click();
                    break;
                case "Buscar":
                    _webDriver.Wait.Until(el => el.FindElement(By.XPath("/html/body/article/div/div[2]/div/div[2]/form/input[2]"))).Click();
                    break;
                case "Assinar":
                    _webDriver.Wait.Until(el => el.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div/div/a/div"))).Click();
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }

        public void MethodElementFieldSendKeys(string elementDataType, string element)
        {
            switch (elementDataType)
            {
                case "O que você procura":
                    _webDriver.Wait.Until(el => el.FindElement(By.Id("s"))).SendKeys(element);
                    break;
                default:
                    break;
            }
        }


    }
}