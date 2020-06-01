using OpenQA.Selenium;

namespace Ui.Tests.CorporateWebsite.PageObjectModels.Components
{
    public class BaseComponent
    {
        protected readonly IWebDriver Driver;

        public BaseComponent(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}
