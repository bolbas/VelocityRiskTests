using OpenQA.Selenium;
using Ui.Tests.PolicyAdminSystem.PageObjectModels.Components;

namespace Ui.Tests.PolicyAdminSystem.Steps
{
    public class PolicyAdminSystemHomePageSteps : PolicyAdminSystemBaseSteps<PolicyAdminSystemHomePage>
    {
        public PolicyAdminSystemHomePageSteps(IWebDriver driver) : base(driver)
        {
            Page = new PolicyAdminSystemHomePage(Driver);
        }

        public void ClickLogoLink() => Click(Page.HeaderLogoLink);

        public void ClickNewQuoteMenuItemLink() => Click(Page.HeaderNewQuoteLink);
        public void ClickPoliciesMenuItemLink() => Click(Page.HeaderPoliciesLink);
        public void ClickClaimsMenuItemLink() => Click(Page.HeaderClaimsLink);
        public void ClickPaymentsMenuItemLink() => Click(Page.HeaderPaymentsLink);
        public void ClickSettingsMenuItemLink() => Click(Page.HeaderSettingsLink);

        public void ClickAccountInformationFooterLink() => Click(Page.FooterAccountInformationLink);
        public void ClickLogOutFooterLink() => Click(Page.FooterLogOutLink);
        public void ClickPersonalLinesEmailFooterLink() => Click(Page.FooterPersonalLinesEmailLink);
        public void ClickSmallBusinessEmailFooterLink() => Click(Page.FooterSmallBusinessEmailLink);
    }
}
