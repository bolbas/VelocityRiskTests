using System;
using OpenQA.Selenium;
using Ui.Tests.PolicyAdminSystem.PageObjectModels;

namespace Ui.Tests.PolicyAdminSystem.Steps
{
    public class QuoteGetQuoteSteps : PolicyAdminSystemBaseSteps<QuoteGetQuotePage>
    {
        public QuoteGetQuoteSteps(IWebDriver driver) : base(driver) { }

        public void NavigateTo(Guid policyId)
        {
            Page.PolicyId = policyId;
            Driver.Navigate().GoToUrl(Page.PageUrl);
        }
    }
}
