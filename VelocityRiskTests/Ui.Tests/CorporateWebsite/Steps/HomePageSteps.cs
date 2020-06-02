using OpenQA.Selenium;
using Shouldly;
using Ui.Tests.CorporateWebsite.PageObjectModels;
using Ui.Tests.CorporateWebsite.PersistenceModels;
using Ui.Tests.CorporateWebsite.Steps.TestData;

namespace Ui.Tests.CorporateWebsite.Steps
{
    public class HomePageSteps : CorporateWebsiteBaseSteps<CorporateWebsiteHomePage>
    {
        public HomePageSteps(IWebDriver driver) : base(driver)
        {
            Page = new CorporateWebsiteHomePage(Driver);
        }

        public void VerifyLogoIsPresent()
        {
            Page.Logo.Displayed.ShouldBeTrue("Velocity risk logo should be present.");
        }

        public void VerifyNavBarIsOrange()
        {
            var navBarColor = Page.NavBar.GetCssValue("background-color");
            navBarColor.ShouldBe(HomePageTestData.NavBarColor, "NavBar should be orange");
        }

        public void NavigateWithoutSsl()
        {
            const string url = "http://www.velocityrisk.com";
            Page.PageUrl = url;
        }

        public void VerifyMenuItemPresented(MenuItem menuItem)
        {
            var isMenuElement = IsMenuItemPresentByName(menuItem.Name);
            isMenuElement.ShouldBeTrue($"It was not possible to find menu item : {menuItem.Name} on UI");
        }

        public void VerifyMenuItemRedirrect(MenuItem menuItem)
        {
            if (menuItem.opensNewTab)
            {
                VerifyNewTabUrl(menuItem.Link, $"Clicking {menuItem.Name} should redirrect to {menuItem.Link} on a new tab");
            } 
            else
            {
                VerifyPageUrl(menuItem.Link, $"Clicking {menuItem.Name} should redirrect to {menuItem.Link} on the same page");
            }
        }

        public bool IsMenuItemPresentByName(string menuItemName)
        {
            try
            {
                Page.GetMenuLinkByItemName(menuItemName);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void ClickMenuItemByName(string menuItemName)
        {
            var menuItem = Page.GetMenuLinkByItemName(menuItemName);

            var parentElements = menuItem.FindElements(By.XPath("ancestor::ul[@class = 'sub-menu']"));
            if (parentElements.Count > 0)
            {
                menuItem.FindElement(By.XPath("ancestor::ul[@class = 'sub-menu']/preceding-sibling::a")).Click();
            }
            menuItem.Click();
        }

        #region Footer Steps

        public void VerifyCorporateOfficeAddress()
        {
            var actualAddress = Page.GetCorporateOfficeAddress();
            actualAddress.ShouldBe(CopyrightTestData.CorporateOfficeAddress, "It was not possible to find an expected address.");

            var actualLinkedInUrl = Page.GetLinkedInLink();
            actualLinkedInUrl.ShouldBe(CopyrightTestData.LinkedInHref, "It was not possible to find an expected LinkedIn link.");

            var actualFacebooknUrl = Page.GetFacebookLink();
            actualFacebooknUrl.ShouldBe(CopyrightTestData.FacebookHref, "It was not possible to find an expected Facebook link.");

            var actualTwitterUrl = Page.GetTwitterLink();
            actualTwitterUrl.ShouldBe(CopyrightTestData.TwitterHref, "It was not possible to find an expected Twitter link.");

            var actualInstagramUrl = Page.GetInstagramLink();
            actualInstagramUrl.ShouldBe(CopyrightTestData.InstagramHref, "It was not possible to find an expected Instagram link.");
        }

        public void VerifySocialLinks()
        {
            VerifyLinkAttributes(Page.Footer.CorporateOfficeLinkedIn, CopyrightTestData.LinkedInHref, "It was not possible to verify LinkedIn link.");
            VerifyLinkAttributes(Page.Footer.CorporateOfficeFacebook, CopyrightTestData.FacebookHref, "It was not possible to verify Facebook link.");
            VerifyLinkAttributes(Page.Footer.CorporateOfficeTwitter, CopyrightTestData.TwitterHref, "It was not possible to verify Twitter link.");
            VerifyLinkAttributes(Page.Footer.CorporateOfficeInstagram, CopyrightTestData.InstagramHref, "It was not possible to verify Instagram link.");
        }

        public void VerifyReportClaim()
        {
            var actualNumber = Page.GetReportClaimPhoneNumberText();
            actualNumber.ShouldBe(CopyrightTestData.ReportClaimPhoneNumber, "It was not possible to find expected phone number to report a claim.");

            var actualLink = Page.GetReportClaimLink();
            actualLink.ShouldBe(CopyrightTestData.ReportClaimPhoneLink, "It was not possible to find an expected link for the phone number to report a claim.");
            ClickReportAClaimOnlineLink();
            VerifyPageUrl(CopyrightTestData.ReportClaimOnlineUrl);
        }

        public void VerifyProductInquiries()
        {
            var actualPersonalLinesText = Page.GetPersonalLinesNumberText();
            actualPersonalLinesText.ShouldBe(CopyrightTestData.PersonalLinesPhoneNumber, "It was not possible to find expected phone number for personal lines.");

            var actualSmallComercialsText = Page.GetSmallComercialNumberText();
            actualSmallComercialsText.ShouldBe(CopyrightTestData.SmallCommercialPhoneNumber, "It was not possible to find expected phone number for small commercial.");

            var actualLargeComercialsText = Page.GetLargeCommercialNumberText();
            actualLargeComercialsText.ShouldBe(CopyrightTestData.LargeCommercialPhoneNumber, "It was not possible to find expected phone number for large commercial.");


            var actualPersonalLinesLink = Page.GetPersonalLinesNumberLink();
            actualPersonalLinesLink.ShouldBe(CopyrightTestData.PersonalLinesPhoneNumberLink, "It was not possible to find expected phone number for personal lines.");

            var actualSmallComercialsLink = Page.GetSmallComercialNumberLink();
            actualSmallComercialsLink.ShouldBe(CopyrightTestData.SmallCommercialPhoneNumberLink, "It was not possible to find expected phone number for small commercial.");

            var actualLargeComercialsLink = Page.GetLargeCommercialNumberLink();
            actualLargeComercialsLink.ShouldBe(CopyrightTestData.LargeCommercialPhoneNumberLink, "It was not possible to find expected phone number for large commercial.");
        }

        public void VerifyCopyright()
        {
            VerifyOpenLinkInCurrentTab(Page.Footer.Disclaimer, CopyrightTestData.DisclaimerUrl, "It was not possible to find an expected URL for disclaimer.");
            VerifyOpenLinkInCurrentTab(Page.Footer.TermsOfUse, CopyrightTestData.TermsOfUseUrl, "It was not possible to find an expected URL for terms of use.");
            VerifyOpenLinkInCurrentTab(Page.Footer.PrivacyPolicy, CopyrightTestData.PrivacyPolicyUrl, "It was not possible to find an expected URL for privacy policy.");
        }

        public void VerifyCookiePresented()
        {
            Page.CookieInfo.Accept.Displayed.ShouldBe(true, "It was not possible to find an expected cookie message.");
        }

        public void ClickReportAClaimOnlineLink()
        {
            ClickElement(Page.Footer.ReportClaimOnlineLink);
        }

        #endregion Footer Steps
    }
}
