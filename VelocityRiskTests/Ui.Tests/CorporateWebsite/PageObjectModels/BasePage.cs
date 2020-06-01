using OpenQA.Selenium;
using Ui.Tests.Common;

namespace Ui.Tests.CorporateWebsite.PageObjectModels
{
    public abstract class BasePage : CommonBasePage
    {
        protected BasePage(IWebDriver driver) : base(driver) { }
    }
}
