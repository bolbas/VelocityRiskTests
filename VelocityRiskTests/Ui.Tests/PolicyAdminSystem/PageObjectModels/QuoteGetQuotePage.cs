using System;
using OpenQA.Selenium;
using Ui.Tests.PolicyAdminSystem.PageObjectModels.Components;

namespace Ui.Tests.PolicyAdminSystem.PageObjectModels
{
    public class QuoteGetQuotePage : PolicyAdminSystemHomePage
    {
        public Guid PolicyId { get; set; }

        public IWebElement DeductiblePercent1Button => Driver.FindElement(By.XPath("//button[span[contains(text(), '1%')]]"));

        public IWebElement DeductiblePercent2Button => Driver.FindElement(By.XPath("//button[span[contains(text(), '2%')]]"));

        public IWebElement DeductiblePercent3Button => Driver.FindElement(By.XPath("//button[span[contains(text(), '3%')]]"));

        public IWebElement DeductiblePercent5Button => Driver.FindElement(By.XPath("//button[span[contains(text(), '3%')]]"));

        public IWebElement DeductiblePercent10Button => Driver.FindElement(By.XPath("//button[span[contains(text(), '10%')]]"));

        public IWebElement EarthquakePremiumCheckbox => Driver.FindElement(By.XPath("//label[span[contains(text(), 'Earthquake Premium')]]//checkbox"));

        public IWebElement TerrorismRiskYesButton => Driver.FindElement(By.XPath("//label[input[@name='terrorism']][span[contains(text(), 'Yes')]]"));

        public IWebElement TerrorismRiskNoButton => Driver.FindElement(By.XPath("//label[input[@name='terrorism']][span[contains(text(), 'No')]]"));

        public IWebElement IncludedButton => Driver.FindElement(By.XPath("//button[span[contains(text(), 'Included')]]"));

        public IWebElement UpgradeToSilverButton => Driver.FindElement(By.XPath("//button[span[contains(text(), 'Upgrade to Silver')]]"));

        public IWebElement UpgradeToGoldButton => Driver.FindElement(By.XPath("//button[contains(text(), 'Upgrade to Gold')]"));

        public IWebElement AdditionalPremiumInput => Driver.FindElement(By.XPath("//div[contains(text(), 'Additional Premium')]//input"));

        public IWebElement ViewQuoteSummaryLink => Driver.FindElement(By.XPath("//div[@data-test-id='policy-wizard-upsell-view-summary']//a"));

        public IWebElement ShareQuoteSummaryLink => Driver.FindElement(By.XPath("//div[@data-test-id='policy-wizard-upsell-share-summary']//a"));

        public IWebElement SendEmailButton => Driver.FindElement(By.XPath("//button[contains(text(), 'Send Email')]"));

        public IWebElement ContinueToBindButton => Driver.FindElement(By.XPath("//button[contains(text(), 'Continue to Bind')]"));

        public IWebElement DiscardQuoteButton => Driver.FindElement(By.XPath("//button[contains(text(), 'Discard Quote')]"));

        public QuoteGetQuotePage(IWebDriver driver) : base(driver)
        {
            PageUrl = $"https://velocity-uat.britecorepro.com/agent/policies/wizard/velocity/upsell_matrix?policyId={PolicyId}";
        }
    }
}
