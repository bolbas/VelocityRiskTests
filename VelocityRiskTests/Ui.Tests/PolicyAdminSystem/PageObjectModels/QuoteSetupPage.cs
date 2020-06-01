using OpenQA.Selenium;

namespace Ui.Tests.PolicyAdminSystem.PageObjectModels
{
    public class QuoteSetupPage : PolicyAdminSystemBasePage
    {
        public QuoteSetupPage(IWebDriver driver) : base(driver)
        {
            PageUrl = "https://velocity-uat.britecorepro.com/agent/policies/wizard/policy_setup";
        }

        public IWebElement PolicyEffectiveDateTextBox => Driver.FindElement(By.CssSelector("label[data-test-id='policy-wizard-setup-effective-date'] date-input input"));
        public IWebElement TodayDateDatePickerOption => Driver.FindElement(By.CssSelector("td[class='today day']"));
        public IWebElement StateTextBox => Driver.FindElement(By.CssSelector("label[data-test-id='policy-wizard-setup-state'] div div input"));
        public IWebElement ZipCodeTextBox => Driver.FindElement(By.CssSelector("label[data-test-id='policy-wizard-setup-zipcode'] input"));
        public IWebElement InsuredNameTextBox => Driver.FindElement(By.CssSelector("label[data-test-id='policy-wizard-setup-insured-name'] input"));

        public IWebElement QuestionOneYesButton => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion0'] div div label input[value='yes']"));
        public IWebElement QuestionOneNoButton => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion0'] div div label input[value='no']"));
        public IWebElement QuestionOnePleaseExplainTextArea => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion0'] div label textarea"));

        public IWebElement QuestionTwoYesButton => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion1'] div div label input[value='yes']"));
        public IWebElement QuestionTwoNoButton => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion1'] div div label input[value='no']"));
        public IWebElement QuestionTwoPleaseExplainTextArea => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion1'] div label textarea"));

        public IWebElement QuestionThreeYesButton => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion2'] div div label input[value='yes']"));
        public IWebElement QuestionThreeNoButton => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion2'] div div label input[value='no']"));
        public IWebElement QuestionThreePleaseExplainTextArea => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion2'] div label textarea"));

        public IWebElement QuestionFourYesButton => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion3'] div div label input[value='yes']"));
        public IWebElement QuestionFourNoButton => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion3'] div div label input[value='no']"));
        public IWebElement QuestionFourPleaseExplainTextArea => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion3'] div label textarea"));

        public IWebElement QuestionFiveYesButton => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion4'] div div label input[value='yes']"));
        public IWebElement QuestionFiveNoButton => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion4'] div div label input[value='no']"));
        public IWebElement QuestionFivePleaseExplainTextArea => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion4'] div label textarea"));

        public IWebElement QuestionSixYesButton => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion5'] div div label input[value='yes']"));
        public IWebElement QuestionSixNoButton => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion5'] div div label input[value='no']"));
        public IWebElement QuestionSixPleaseExplainTextArea => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion5'] div label textarea"));

        public IWebElement SaveInformationAndContinueButton => Driver.FindElement(By.CssSelector("button[type='submit']"));
    }
}
