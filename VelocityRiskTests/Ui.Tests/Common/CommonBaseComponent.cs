using OpenQA.Selenium;

namespace Ui.Tests.Common
{
    public abstract class CommonBaseComponent
    {
        protected readonly IWebDriver Driver;

        public CommonBaseComponent(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}
