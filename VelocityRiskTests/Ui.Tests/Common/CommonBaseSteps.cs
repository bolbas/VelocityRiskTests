using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Ui.Tests.Common
{
    public class CommonBaseSteps<TPage> where TPage : CommonBasePage
    {
        protected IWebDriver Driver;

        protected TPage Page;

        public CommonBaseSteps(IWebDriver driver)
        {
            Driver = driver;
        }

        public virtual void NavigateToPage()
        {
            NavidateToCurrentPageUrl();
        }

        protected void NavigateToPageByUrl(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        protected void NavidateToCurrentPageUrl()
        {
            NavigateToPageByUrl(Page.PageUrl);
        }

        public int GetCurrentTabsCount()
        {
            return Driver.WindowHandles.Count;
        }

        public void WaitUntilElementIsVisible(IWebElement element, int timeout = 10)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromMinutes(timeout));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
            wait.Until(driver =>
            {
                try
                {
                    return element.Displayed;
                }
                catch (Exception)
                {
                    return false;
                }
            });
        }

        public void MouseHoverToElement(IWebElement element)
        {
            Actions action = new Actions(Driver);
            action.MoveToElement(element).Perform();
        }

        public void SwitchToLastOpenedTab()
        {
            SwitchToTabByItsName(Driver.WindowHandles.Last());
        }

        public void SwitchBackToDefaultTab()
        {
            SwitchToTabByItsName(Driver.WindowHandles.First());
        }

        public void SwitchToTabByItsName(string tabName)
        {
            Driver.SwitchTo().Window(tabName);
        }

        public void CloseAllTabsExceptFirst()
        {
            foreach(var tabName in Driver.WindowHandles)
            {
                if (tabName == Driver.WindowHandles.First())
                {
                    continue;
                }

                SwitchToTabByItsName(tabName);
                Driver.Close();
            }
            SwitchBackToDefaultTab();
        }

        public IWebElement WaitForClickable(IWebElement webElement, int timeOut = 20)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeOut));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(webElement));
            return element;
        }

        public void ScrollToElement(IWebElement element)
        {
            var js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("arguments[0].scrollIntoView({behavior:'auto', block: 'center', inline: 'center'})", element);
        }

        protected void ClickElement(IWebElement element)
        {
            ScrollToElement(element);
            WaitForClickable(element);
            element.Click();
        }
    }
}
