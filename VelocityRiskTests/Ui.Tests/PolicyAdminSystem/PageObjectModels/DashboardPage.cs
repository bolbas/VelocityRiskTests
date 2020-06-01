using OpenQA.Selenium;
using Ui.Tests.PolicyAdminSystem.PageObjectModels.Components;

namespace Ui.Tests.PolicyAdminSystem.PageObjectModels
{
    public class DashboardPage : LogedInUserViewPage
    {
        public DashboardPage(IWebDriver driver) : base(driver)
        {
            PageUrl = "https://velocity-uat.britecorepro.com/agent/misc/ko_dashboard";
        }


    }
}
