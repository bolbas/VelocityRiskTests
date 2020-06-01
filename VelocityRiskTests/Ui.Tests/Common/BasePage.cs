using OpenQA.Selenium;

namespace Ui.Tests.Common
{
    public abstract class CommonBasePage
    {
        protected readonly IWebDriver Driver;

        public string PageUrl;

        protected CommonBasePage(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}
