using OpenQA.Selenium;
using Ui.Tests.Common;

namespace Ui.Tests.CorporateWebsite.PageObjectModels
{
    public abstract class CorporateWebsiteBasePage : CommonBasePage
    {
        protected CorporateWebsiteBasePage(IWebDriver driver) : base(driver) { }
    }
}
