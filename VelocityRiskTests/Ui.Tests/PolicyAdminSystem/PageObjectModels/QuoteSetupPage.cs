using OpenQA.Selenium;
using Ui.Tests.PolicyAdminSystem.PageObjectModels.Components;

namespace Ui.Tests.PolicyAdminSystem.PageObjectModels
{
    public class QuoteSetupPage : PolicyAdminSystemHomePage
    {
        public QuoteSetupPage(IWebDriver driver) : base(driver)
        {
            PageUrl = "https://velocity-uat.britecorepro.com/agent/policies/wizard/policy_setup";
        }

        public IWebElement PolicyEffectiveDateTextBox => Driver.FindElement(By.CssSelector("label[data-test-id='policy-wizard-setup-effective-date'] input"));
        public IWebElement TodayDateDatePickerOption => Driver.FindElement(By.CssSelector("td[class='today day']"));
        public IWebElement StateTextBox => Driver.FindElement(By.CssSelector("label[data-test-id='policy-wizard-setup-state'] input"));
        public IWebElement ZipCodeTextBox => Driver.FindElement(By.CssSelector("label[data-test-id='policy-wizard-setup-zipcode'] input"));
        public IWebElement InsuredNameTextBox => Driver.FindElement(By.CssSelector("label[data-test-id='policy-wizard-setup-insured-name'] input"));

        public IWebElement QuestionOneYesButton => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion0'] input[value='yes']"));
        public IWebElement QuestionOneNoButton => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion0'] input[value='no']"));
        public IWebElement QuestionOnePleaseExplainTextArea => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion0'] textarea"));

        public IWebElement QuestionTwoYesButton => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion1'] input[value='yes']"));
        public IWebElement QuestionTwoNoButton => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion1'] input[value='no']"));
        public IWebElement QuestionTwoPleaseExplainTextArea => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion1'] textarea"));

        public IWebElement QuestionThreeYesButton => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion2'] input[value='yes']"));
        public IWebElement QuestionThreeNoButton => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion2'] input[value='no']"));
        public IWebElement QuestionThreePleaseExplainTextArea => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion2'] textarea"));

        public IWebElement QuestionFourYesButton => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion3'] input[value='yes']"));
        public IWebElement QuestionFourNoButton => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion3'] input[value='no']"));
        public IWebElement QuestionFourPleaseExplainTextArea => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion3'] textarea"));

        public IWebElement QuestionFiveYesButton => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion4'] input[value='yes']"));
        public IWebElement QuestionFiveNoButton => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion4'] input[value='no']"));
        public IWebElement QuestionFivePleaseExplainTextArea => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion4'] textarea"));

        public IWebElement QuestionSixYesButton => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion5'] input[value='yes']"));
        public IWebElement QuestionSixNoButton => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion5'] input[value='no']"));
        public IWebElement QuestionSixPleaseExplainTextArea => Driver.FindElement(By.CssSelector("div[data-test-id='underwritingQuestion5'] textarea"));

        public IWebElement SaveInformationAndContinueButton => Driver.FindElement(By.CssSelector("button[type='submit']"));
    }
}
