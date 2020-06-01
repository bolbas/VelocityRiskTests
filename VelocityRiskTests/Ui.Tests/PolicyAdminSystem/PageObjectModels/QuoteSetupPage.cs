using OpenQA.Selenium;

namespace Ui.Tests.PolicyAdminSystem.PageObjectModels
{
    public class QuoteSetupPage : PolicyAdminSystemBasePage
    {
        public QuoteSetupPage(IWebDriver driver) : base(driver)
        {
            PageUrl = "https://velocity-uat.britecorepro.com/agent/policies/wizard/policy_setup";
        }

        public IWebElement PolicyEffectiveDate => Driver.FindElement(By.CssSelector("label[data-test-id='policy-wizard-setup-effective-date'] date-input input"));
        public IWebElement DatePickerTodayDate => Driver.FindElement(By.CssSelector("td[class='today day']"));
        public IWebElement State => Driver.FindElement(By.CssSelector("label[data-test-id='policy-wizard-setup-state'] div div input"));
        public IWebElement ZipCode => Driver.FindElement(By.CssSelector("label[data-test-id='policy-wizard-setup-zipcode'] input"));
        public IWebElement InsuredName => Driver.FindElement(By.CssSelector("label[data-test-id='policy-wizard-setup-insured-name'] input"));

        public IWebElement QuestionOneYes => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion0'] div div label input[value='yes']"));
        public IWebElement QuestionOneNo => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion0'] div div label input[value='no']"));
        public IWebElement QuestionOnePleaseExplain => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion0'] div label textarea"));

        public IWebElement QuestionTwoYes => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion1'] div div label input[value='yes']"));
        public IWebElement QuestionTwoNo => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion1'] div div label input[value='no']"));
        public IWebElement QuestionTwoPleaseExplain => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion1'] div label textarea"));

        public IWebElement QuestionThreeYes => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion2'] div div label input[value='yes']"));
        public IWebElement QuestionThreeNo => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion2'] div div label input[value='no']"));
        public IWebElement QuestionThreePleaseExplain => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion2'] div label textarea"));

        public IWebElement QuestionFourYes => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion3'] div div label input[value='yes']"));
        public IWebElement QuestionFourNo => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion3'] div div label input[value='no']"));
        public IWebElement QuestionFourPleaseExplain => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion3'] div label textarea"));

        public IWebElement QuestionFiveYes => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion4'] div div label input[value='yes']"));
        public IWebElement QuestionFiveNo => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion4'] div div label input[value='no']"));
        public IWebElement QuestionFivePleaseExplain => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion4'] div label textarea"));

        public IWebElement QuestionSixYes => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion5'] div div label input[value='yes']"));
        public IWebElement QuestionSixNo => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion5'] div div label input[value='no']"));
        public IWebElement QuestionSixPleaseExplain => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion5'] div label textarea"));

        public IWebElement SaveInformationAndContinue => Driver.FindElement(By.CssSelector("button[type='submit']"));
    }
}
