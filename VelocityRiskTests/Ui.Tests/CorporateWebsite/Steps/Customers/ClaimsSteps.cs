using OpenQA.Selenium;
using Shouldly;
using Ui.Tests.CorporateWebsite.PageObjectModels;
using Ui.Tests.CorporateWebsite.PersistenceModels;

namespace Ui.Tests.CorporateWebsite.Steps.Customers
{
    public class ClaimsSteps : CorporateWebsiteBaseSteps<ClaimsPage>
    {
        public ClaimsSteps(IWebDriver driver) : base(driver)
        {
            Page = new ClaimsPage(Driver);
        }

        public void VerifyOneLinkFromFileAClaimSection(string expectedUrl, string linkName)
        {
            var actualLink = Page.GetLinkFromFileAClaimSection(linkName);
            VerifyLinkAttributes(actualLink, expectedUrl, $"It was not possible to verify {linkName} page.");
        }

        public void VerifyPanelItemPresented(PanelItem panelItem)
        {
            var isPanelPresented = Page.GetPanel(panelItem.Title).Displayed;
            isPanelPresented.ShouldBeTrue($"It was not possible to find panel item: {panelItem.Title} on UI");
        }

        public void ExpandPanelItem(PanelItem panelItem)
        {
            // expand panel
            ClickPanel(panelItem.Title);
        }

        public void VerifyPanelContent(PanelItem panelItem)
        {
            var actualContent = Page.GetPanelContent(panelItem.Title);
            panelItem.Content.ShouldBe(actualContent, $"It was not possible to find expected content for: {panelItem.Title} on UI");

            // collapse panel
            ClickPanel(panelItem.Title);
        }

        public void ExpandAllPanels()
        {
            var expandAllButton = Page.ExpandAllButton;
            WaitForClickable(expandAllButton);
            expandAllButton.Click();
        }

        public void ClickPanel(string name)
        {
            var spanElement = Page.GetPanel(name);
            var divElement = spanElement.FindElement(By.XPath("ancestor::div[@class = 'customer_drop_block']"));
            ScrollToElement(divElement);

            var aElement = divElement.FindElement(By.XPath("a[@class = 'customer_head_part']"));
            WaitForClickable(aElement);

            aElement.Click();
        }
    }
}
