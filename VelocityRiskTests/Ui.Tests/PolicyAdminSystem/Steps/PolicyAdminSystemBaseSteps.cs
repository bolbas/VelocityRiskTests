using OpenQA.Selenium;
using Ui.Tests.Common;

namespace Ui.Tests.PolicyAdminSystem.Steps
{
    public class PolicyAdminSystemBaseSteps<TPage> : CommonBaseSteps<TPage>
        where TPage : CommonBasePage
    {
        public PolicyAdminSystemBaseSteps(IWebDriver driver) : base(driver) { }
    }
}
