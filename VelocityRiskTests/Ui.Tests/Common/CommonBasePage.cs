using OpenQA.Selenium;

namespace Ui.Tests.Common
{
    public abstract class CommonBasePage : CommonBaseComponent
    {
        public string PageUrl;

        protected CommonBasePage(IWebDriver driver) : base(driver)
        {
        }
    }
}