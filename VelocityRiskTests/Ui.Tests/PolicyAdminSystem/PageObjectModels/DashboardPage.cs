using OpenQA.Selenium;
using Ui.Tests.PolicyAdminSystem.PageObjectModels.Components;

namespace Ui.Tests.PolicyAdminSystem.PageObjectModels
{
    public class DashboardPage : PolicyAdminSystemHomePage
    {
        public DashboardPage(IWebDriver driver) : base(driver)
        {
            PageUrl = "https://velocity-uat.britecorepro.com/agent/misc/ko_dashboard";
        }

        public IWebElement SmallBusinessEmailLink => Driver.FindElement(By.XPath("//div[@id='page_container']//a[contains(text(), 'SMB.underwriting@velocityrisk.com')]"));
        public IWebElement HereLink => Driver.FindElement(By.XPath("//a[contains(text(), 'here')]"));
        public IWebElement HomeownersProductsEmailLink => Driver.FindElement(By.XPath("//div[@id='page_container']//a[@href='mailto:underwriting@velocityrisk.com']"));

    }
}
