using OpenQA.Selenium;
using Ui.Tests.Common;

namespace Ui.Tests.PolicyAdminSystem.Steps
{
    public class BaseSteps<TPage> : CommonBaseSteps<TPage>
        where TPage : CommonBasePage
    {
        public BaseSteps(IWebDriver driver) : base(driver) { }
    }
}
