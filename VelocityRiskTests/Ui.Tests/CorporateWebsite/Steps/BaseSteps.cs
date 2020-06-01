using OpenQA.Selenium;
using Shouldly;
using Ui.Tests.Common;
using Ui.Tests.CorporateWebsite.PageObjectModels.Components;

namespace Ui.Tests.CorporateWebsite.Steps
{
    public class BaseSteps<TPage> : CommonBaseSteps<TPage>
        where TPage : CommonBasePage
    {
        protected MenuBar MenuBar;

        public BaseSteps(IWebDriver driver) : base(driver)
        {
            MenuBar = new MenuBar(Driver);
        }

        public void VerifyPageUrl(string expectedUrl, string additionalMessage = "")
        {
            Driver.Url.ShouldContain(expectedUrl, $"Url of the current tab should be: '{expectedUrl}'. {additionalMessage}");
        }

        public void VerifyRedirectedToHttps()
        {
            Driver.Url.Split(':')[0].ShouldBe("https", "Url of the current tab should be under HTTPS protocol");
        }

        public void VerifyNewTabIsOpened(int tabsCountBefore)
        {
            GetCurrentTabsCount().ShouldBe(tabsCountBefore + 1, "Link should be opened in new tab");
        }

        public void VerifyLinkAttributes(IWebElement actualLinkElement, string expectedUrl, string customMessage)
        {
            var href = actualLinkElement.GetAttribute("href");
            href.ShouldBe(expectedUrl, customMessage);

            var target = actualLinkElement.GetAttribute("target");
            target.ShouldBe("_blank", customMessage);
        }

        public void VerifyOpenLinkInCurrentTab(IWebElement actualLinkElement, string expectedUrl, string customMessage)
        {
            var initialTabsCount = GetCurrentTabsCount();
            ClickElement(actualLinkElement);
            GetCurrentTabsCount().ShouldBe(initialTabsCount, "Link should be opened in current tab");
            VerifyPageUrl(expectedUrl, customMessage);
        } 

        public void VerifyOpenLinkInANewTab(IWebElement actualLinkElement, string expectedUrl, string customMessage)
        {
            var initialTabsCount = GetCurrentTabsCount();
            ClickElement(actualLinkElement);
            VerifyNewTabIsOpened(initialTabsCount);
            VerifyNewTabUrl(expectedUrl, customMessage);
        }

        public void VerifyNewTabUrl(string expectedUrl, string customMessage)
        {
            SwitchToLastOpenedTab();
            VerifyPageUrl(expectedUrl, customMessage);
            SwitchBackToDefaultTab();
        }
    }
}
