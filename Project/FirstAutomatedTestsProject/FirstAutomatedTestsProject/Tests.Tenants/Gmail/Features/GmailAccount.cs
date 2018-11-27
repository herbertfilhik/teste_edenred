using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstAutomatedTestsProject.Test.Common;
using System.Threading;
using OpenQA.Selenium;
using System;

namespace FirstAutomatedTestsProject
{
    [TestClass]
    public class GmailAccount
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
        public void GmailAccountCreate()
        {

            //generate random data for testes
            Random r = new Random();

            String firstName = $"FirstName{r.Next()}";
            String lastName = $"LastName{r.Next()}";
            String userName = $"UserName{r.Next()}";
            String passwd = $"PassWd{r.Next()}";
            String phone = "11999995555";

            Console.WriteLine("First Name is: " + firstName);
            Console.WriteLine("Last Name is: " + lastName);
            Console.WriteLine("User Name is: " + userName);
            Console.WriteLine("Passowrd is: " + passwd);

            WebHelp.StartWebDriver("Chrome");

            WebHelp.WaitSomeSec(2);

            WebHelp.NavigateTo(SearchPage.URL);

            WebHelp.WaitSomeSec(2);

            WebHelp.Webdriver.FindElement(By.XPath("//*[@id='view_container']/div/div/div[2]/div/div[2]/div/div[2]/div/div/content/span")).Click();
            WebHelp.WaitSomeSec(2);
            WebHelp.firstNameElementInsert(SearchPage.FirstNameField, firstName);
            WebHelp.lastNameElementInsert(SearchPage.LastNameField, lastName);
            WebHelp.userNameElementInsert(SearchPage.UserNameField, userName);
            WebHelp.passwdElementInsert(SearchPage.UserNameField, passwd);
            WebHelp.confirmpasswdElementInsert(SearchPage.ConfPasswdField, passwd);

            //botão proxima
            //WebHelp.Webdriver.FindElement(By.XPath("//*[@id='accountDetailsNext']/content/span")).Click();

            //WebHelp.phoneElementInsert(SearchPage.PhoneField, phone);

            //WebHelp.Webdriver.FindElement(By.XPath("//*[@id='gradsIdvPhoneNext']/content/span")).Click();
            
            /*WebHelp.Webdriver.FindElement(By.Id("day")).SendKeys("01");

            WebHelp.Webdriver.FindElement(By.XPath("//*[@id='month']")).Click();
            WebHelp.Webdriver.FindElement(By.XPath("//*[@id='month']/option[13]")).Click();

            WebHelp.Webdriver.FindElement(By.Id("year")).SendKeys("1980");

            WebHelp.Webdriver.FindElement(By.XPath("//*[@id='gender']")).Click();
            WebHelp.Webdriver.FindElement(By.XPath("//*[@id='gender']/option[2]")).Click();

            WebHelp.Webdriver.FindElement(By.XPath("//*[@id='personalDetailsNext']/content/span")).Click();
            WebHelp.Webdriver.FindElement(By.XPath("//*[@id='view_container']/form/div[2]/div/div[3]/div[1]/div[2]/button")).Click();

            WebHelp.Webdriver.FindElement(By.XPath("//body/div/div/div[2]/div/div[2]/form/div[2]/div/div/div/div/div/div/content/span")).Click();
            WebHelp.Webdriver.FindElement(By.XPath("//body/div/div/div[2]/div/div[2]/form/div[2]/div/div/div/div/div/div/content/span")).Click();
            WebHelp.Webdriver.FindElement(By.XPath("//body/div/div/div[2]/div/div[2]/form/div[2]/div/div/div/div/div/div/content/span")).Click();

            WebHelp.Webdriver.FindElement(By.XPath("//*[@id='termsofserviceNext']/content/span")).Click();

            WebHelp.Webdriver.FindElement(By.XPath("//body/div[22]/div[3]/button")).Click();
            
            /*WebHelp.Webdriver.FindElement(By.Id("identifierId")).Click();
            WebHelp.Webdriver.FindElement(By.Id("identifierId")).SendKeys("Teste");*/

            WebHelp.WaitSomeSec(2);

            WebHelp.StopWebDriver();
        }
    }
}