﻿using OpenQA.Selenium;
using Shouldly;
using Ui.Tests.PageObjectModels;

namespace Ui.Tests.Steps
{
    public class FileAClaimSteps: BaseSteps
    {
        private ClaimsPage _claimsPage;

        public FileAClaimSteps(IWebDriver driver) : base(driver)
        {
            _claimsPage = new ClaimsPage(Driver);
        }

        public void ClickFileAClaimAccordion()
        {
            MenuBar.ClickCustomersClaimsMenuItem();
            _claimsPage.ClickFileAClaimMenuItem();
        }

        public void ScrollDown()
        {
            var element = _claimsPage.GetQuestionsOnAnExistingClaimElement();
            MouseHoverToElement(element);
        }

        private void VerifyLink(IWebElement linkElement, string url)
        {
            linkElement.Click();
            VerifyNewTabIsOpened(1);
            SwitchToLastOpenedTab();
            Driver.Url.ShouldContain(url);
            Driver.Close();
            SwitchBackToDefaultTab();
        }

        public void VerifyHomeownersLink(string url)
        {
            var homeownersLink = _claimsPage.GetLinksFromFileAClaimSection("homeowners");
            VerifyLink(homeownersLink, url);
        }

        public void VerifySmallCommercialLink(string url)
        {
            var smallCommercialLink = _claimsPage.GetLinksFromFileAClaimSection("small commercial");
            VerifyLink(smallCommercialLink, url);
        }
        public void VerifyLargeCommercialLink(string url)
        {
            var largeCommercialLink = _claimsPage.GetLinksFromFileAClaimSection("large commercial");
            VerifyLink(largeCommercialLink, url);
        }
    }
}
