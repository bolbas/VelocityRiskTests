using OpenQA.Selenium;

namespace Ui.Tests.CorporateWebsite.PageObjectModels
{
    public class ClaimsPage : CorporateWebsiteHomePage
    {
        public IWebElement ExpandAllButton => Driver.FindElement(By.ClassName("expand_all_btn"));

        public IWebElement QuestionsOnExistingClaimPanel => Driver.FindElement(By.Id("questions-on-an-existing-claim"));

        public ClaimsPage(IWebDriver driver) : base(driver)
        {
            PageUrl = "https://velocityrisk.com/claims/";
        }

        public IWebElement GetPanel(string title)
        {
            return Driver.FindElement(By.XPath("//span[contains(text(), '" + title + "')]"));
        }

        public string GetPanelContent(string title)
        {
            var panelItem = GetPanel(title);
            var panelElement = panelItem.FindElement(By.XPath("ancestor::div[@class = 'customer_drop_block']/div"));

            return panelElement.GetAttribute("innerText");
        }

        public IWebElement GetLinkFromFileAClaimSection(string linkName)
        {
            return Driver.FindElement(By.XPath($"//p/strong[contains(text(), '{linkName}')]/following-sibling::a[contains(@class, 'underline')]"));
        }
    }
}
