using OpenQA.Selenium;
using Ui.Tests.Common;
using Ui.Tests.PolicyAdminSystem.PageObjectModels;

namespace Ui.Tests.PolicyAdminSystem.Steps
{
    public class PolicyAdminSystemBaseSteps<TPage> : CommonBaseSteps<TPage>
        where TPage : CommonBasePage
    {
        public PolicyAdminSystemBaseSteps(IWebDriver driver) : base(driver) { }

        public override void NavigateToPage()
        {
            if (Page == null)
            {
                NavigateToPageByUrl(new DashboardPage(Driver).PageUrl);
            }
            else
            {
                if (GetCurrentTabsCount() > 1)
                {
                    SwitchBackToDefaultTab();
                }

                NavidateToCurrentPageUrl();
            }
        }

        protected void SetTextBoxValue(IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        public string GetTextBoxValue(IWebElement element)
        {
            return element.GetAttribute("value");
        }
    }
}
