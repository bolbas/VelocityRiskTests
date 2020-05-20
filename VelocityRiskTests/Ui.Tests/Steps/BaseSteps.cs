﻿using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using Shouldly;
using System;
using System.Linq;
using Ui.Tests.PageObjectModels;
using Ui.Tests.PageObjectModels.Components;

namespace Ui.Tests.Steps
{
    public class BaseSteps
    {
        protected IWebDriver Driver;
        protected int TabsCount;

        protected MenuBar MenuBar;

        public BaseSteps(IWebDriver driver)
        {
            Driver = driver;

            MenuBar = new MenuBar(Driver);
        }

        public void GoToHomePage()
        {
            SwitchBackToDefaultTab();
            var homePage = new HomePage(Driver);
            homePage.NavigateTo();
        }

        public void VerifyPageUrlWithoutProtocol(string urlWitoutProtocol)
        {
            Driver.Url.ShouldContain(urlWitoutProtocol,
                $"Url of the current tab (without protocol part) " +
                $"should contain text '{urlWitoutProtocol}'");
        }

        public void VerifyProtocolIsHttps()
        {
            Driver.Url.Split(':')[0].ShouldBe("https",
                "Url of the current tab should be under HTTPS protocol");
        }

        public int GetCurrentTabsCount()
        {
            return Driver.WindowHandles.Count;
        }

        public void VerifyNewTabIsOpened(int tabsCountBefore)
        {
            GetCurrentTabsCount().ShouldBe(tabsCountBefore + 1,
                "Link should be opened in new tab");
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

        public void CloseAllNewlyOpenedTabs()
        {
            foreach(var tabName in Driver.WindowHandles)
            {
                if (tabName == Driver.WindowHandles.First())
                    continue;

                SwitchToTabByItsName(tabName);
                Driver.Close();
            }
        }

        public IWebElement WaitForClickable(IWebElement webElement, int timeOut = 20)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeOut));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(webElement));
            return element;
        }
    }
}
