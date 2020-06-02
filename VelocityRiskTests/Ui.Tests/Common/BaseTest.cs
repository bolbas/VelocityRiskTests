using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using Ui.Configuration;

namespace Ui.Common
{
    public abstract class BaseTest
    {
        private UIConfiguration _configuration;
        protected IWebDriver Driver;

        public IWebDriver GetDriver => Driver;

        [OneTimeSetUp]
        public void BaseSetUp()
        {
            _configuration = ConfigHelpers.GetApplicationConfiguration(TestContext.CurrentContext.TestDirectory);

            switch (_configuration.Browser)
            {
                case BrowserNamesConstants.Chrome:
                    Driver = new ChromeDriver();
                    break;
                case BrowserNamesConstants.InternetExplorer:
                    Driver = new InternetExplorerDriver(new InternetExplorerOptions
                    {
                        IntroduceInstabilityByIgnoringProtectedModeSettings = true,
                        RequireWindowFocus = true
                    });
                    break;
                default:
                    throw new Exception("Unsupported browser");
            }

            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [OneTimeTearDown]
        public void BaseTearDown()
        {
            Driver.Quit();
            Driver.Dispose();
        }
    }
}