using System;
using TechTalk.SpecFlow;

namespace Selenium_CSharp_Specflow
{
    [Binding]
    public class GmailAccountCreateSteps
    {

        [Given(@"I start the input for google account")]
        public void GivenIStartTheInputForGoogleAccount()
        {
            //WebSteps.IStartTheBrowser("Chrome");
            WebSteps.ICreateAccountTheBrowser();
            WebSteps.IInputDataBrowser();
            WebSteps.IConfirmDataTheBrowser();
        }

        [Then (@"I finish the input for new google account")]
        public void ThenIFinishTheInputForNewGoogleAccount()
        {
            //WebSteps.IStopTheBrowser();
        }
    }
}
