using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Selenium_CSharp_Specflow
{
    [Binding]
    class WebSteps
    {
        public static void IStartTheBrowser(string browserName)
        {
            WebHelp.StartWebDriver(browserName);

        }

        public static void IStopTheBrowser()
        {
            WebHelp.StopWebDriver();

        }

        public static void ICreateAccountTheBrowser()
        {
            WebHelp.NavigateTo(SearchPage.URL);
            WebHelp.WaitSomeSec(2000);
            WebHelp.Webdriver.FindElement(OpenQA.Selenium.By.XPath("//*[@id='view_container']/div/div/div[2]/div/div[2]/div/div[2]/div/div/content/span")).Click();
            WebHelp.WaitSomeSec(2000);
            WebHelp.ITakeScreenShot();
        }

        public static void IInputDataBrowser()
        {

            //generate random data for testes
            Random r = new Random();

            String firstName = $"FirstName{r.Next()}";
            String lastName = $"LastName{r.Next()}";
            String userName = $"UserName{r.Next()}";
            String passwd = $"PassWd{r.Next()}";
            String phone = "11999995555";


            WebHelp.firstNameElementInsert(SearchPage.FirstNameField, firstName);
            WebHelp.lastNameElementInsert(SearchPage.LastNameField, lastName);
            WebHelp.userNameElementInsert(SearchPage.UserNameField, userName);
            WebHelp.passwdElementInsert(SearchPage.PasswdField, passwd);
            WebHelp.confirmpasswdElementInsert(SearchPage.ConfPasswdField, passwd);

            WebHelp.WaitSomeSec(3000);

            WebHelp.ITakeScreenShot();

            WebHelp.Webdriver.FindElement(By.XPath("//*[@id='accountDetailsNext']/content/span")).Click();

            WebHelp.WaitSomeSec(3000);

            WebHelp.ITakeScreenShot();

            WebHelp.phoneElementInsert(SearchPage.PhoneField, phone);

            //WebHelp.Webdriver.FindElement(By.XPath("//*[@id='gradsIdvPhoneNext']/content/span")).Click();

            WebHelp.Webdriver.FindElement(By.Id("day")).SendKeys("01");

            WebHelp.Webdriver.FindElement(By.XPath("//*[@id='month']")).Click();
            WebHelp.Webdriver.FindElement(By.XPath("//*[@id='month']/option[13]")).Click();

            WebHelp.Webdriver.FindElement(By.Id("year")).SendKeys("1980");

            WebHelp.Webdriver.FindElement(By.XPath("//*[@id='gender']")).Click();
            WebHelp.Webdriver.FindElement(By.XPath("//*[@id='gender']/option[2]")).Click();

			WebHelp.WaitSomeSec(3000);
			WebHelp.ITakeScreenShot();
			
            WebHelp.Webdriver.FindElement(By.XPath("//*[@id='personalDetailsNext']/content/span")).Click();
            //WebHelp.Webdriver.FindElement(By.XPath("//*[@id='view_container']/form/div[2]/div/div[3]/div[1]/div[2]/button")).Click();
			
			WebHelp.WaitSomeSec(3000);
			
			WebHelp.ITakeScreenShot();
			WebHelp.Webdriver.FindElement(By.XPath("//body/div/div/div[2]/div/div[2]/form/div[2]/div/div[3]/div/div[2]/button")).Click();

			WebHelp.WaitSomeSec(3000);
			
            WebHelp.Webdriver.FindElement(By.XPath("//body/div/div/div[2]/div/div[2]/form/div[2]/div/div/div/div/div/div/content/span")).Click();
			WebHelp.WaitSomeSec(3000);
            WebHelp.Webdriver.FindElement(By.XPath("//body/div/div/div[2]/div/div[2]/form/div[2]/div/div/div/div/div/div/content/span")).Click();
			WebHelp.WaitSomeSec(3000);
            WebHelp.Webdriver.FindElement(By.XPath("//body/div/div/div[2]/div/div[2]/form/div[2]/div/div/div/div/div/div/content/span")).Click();
			WebHelp.WaitSomeSec(3000);
			WebHelp.ITakeScreenShot();

        }

        public static void IConfirmDataTheBrowser()
        {
			WebHelp.ITakeScreenShot();
            WebHelp.Webdriver.FindElement(By.XPath("//*[@id='termsofserviceNext']/content/span")).Click();

			WebHelp.WaitSomeSec(3000);
			
            WebHelp.Webdriver.FindElement(By.XPath("//body/div[22]/div[3]/button")).Click();

			WebHelp.WaitSomeSec(3000);
			WebHelp.ITakeScreenShot();
            //WebHelp.Webdriver.FindElement(By.Id("identifierId")).Click();
            //WebHelp.Webdriver.FindElement(By.Id("identifierId")).SendKeys("Teste");

            //WebHelp.StopWebDriver();
        }
    }
}