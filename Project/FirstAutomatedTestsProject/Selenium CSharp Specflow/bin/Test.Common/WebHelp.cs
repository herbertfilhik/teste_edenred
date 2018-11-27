using Selenium_CSharp_Specflow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Selenium_CSharp_Specflow
{
    public static class WebHelp
    {

        private static IWebDriver webdriver = null;

        public static IWebDriver Webdriver { get => webdriver; set => webdriver = value; }

        public static void StartWebDriver(string browserName)
        {
            Console.WriteLine("Starting webdriver" + browserName + " from " + SetUp.driverPath);

            switch (browserName)
            {
                case "Chrome":
                    {
                        ChromeOptions chromeoptions = new ChromeOptions();
                        chromeoptions.AddArgument("--ignore-certificate-errors");
                        Webdriver = new ChromeDriver(SetUp.driverPath);
                        break;
                    }
                case "IE":
                    {
                        DesiredCapabilities capabilities = new DesiredCapabilities();
                        capabilities.SetCapability(CapabilityType.AcceptSslCertificates, true);
                        Webdriver = new InternetExplorerDriver(SetUp.driverPath);
                        break;
                    }
                case "FireFox":
                    {
                        Webdriver = new FirefoxDriver(SetUp.driverPath);
                        break;
                    }
                default: Console.WriteLine(browserName + "driver does not implemented in the startbrowser");
                    break;
            }

            webdriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
            webdriver.Manage().Window.Maximize();
        }

        public static void StopWebDriver()
        {
            Console.WriteLine("Stopping webdriver");

            Webdriver.Close();
            Webdriver.Quit();
        }

        public static void NavigateTo(string URL)
        {
            try
            {
                webdriver.Navigate().GoToUrl(URL);                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static void WaitSomeSec(int wait)
        {
            try
            {
                Thread.Sleep(wait);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static void firstNameElementInsert(String FirstNameField, String firstName)
        {
            try
            {
                WebHelp.Webdriver.FindElement(By.Id(SearchPage.FirstNameField)).SendKeys(firstName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static void lastNameElementInsert(String LastNameField, String lastName)
        {
            try
            {
                WebHelp.Webdriver.FindElement(By.Id(SearchPage.LastNameField)).SendKeys(lastName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static void userNameElementInsert(String UserNameField, String userName)
        {
            try
            {
                WebHelp.Webdriver.FindElement(By.Id(SearchPage.UserNameField)).SendKeys(userName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static void passwdElementInsert(String PasswdField, String passwd)
        {
            try
            {
                WebHelp.Webdriver.FindElement(By.XPath(PasswdField)).SendKeys(passwd);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static void confirmpasswdElementInsert(String ConfPasswdField, String passwd)
        {
            try
            {
                WebHelp.Webdriver.FindElement(By.XPath(ConfPasswdField)).SendKeys(passwd);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static void phoneElementInsert(String PhoneField, String phone)
        {
            try
            {
                WebHelp.Webdriver.FindElement(By.Id(PhoneField)).SendKeys(phone);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        internal static void StartWebDriver()
        {
            throw new NotImplementedException();
        }
    }
}
