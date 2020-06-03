using OpenQA.Selenium;
using Ui.Tests.PolicyAdminSystem.PageObjectModels;

namespace Ui.Tests.PolicyAdminSystem.Steps
{
    public class DashboardPageSteps : PolicyAdminSystemBaseSteps<DashboardPage>
    {
        public DashboardPageSteps(IWebDriver driver) : base(driver)
        {
            Page = new DashboardPage(Driver);
        }

        public void ClickSmallBusinessEmailLink() => Click(Page.SmallBusinessEmailLink);
        public void ClickHereLink() => Click(Page.HereLink);
        public void ClickHomeownersProductsEmailLink() => Click(Page.HomeownersProductsEmailLink);
    }
}
