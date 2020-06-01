using System.Collections.Generic;
using NUnit.Framework;
using Ui.Tests.Common;
using Ui.Tests.CorporateWebsite.PersistenceModels;
using Ui.Tests.CorporateWebsite.Steps;
using Ui.Tests.CorporateWebsite.Steps.Customers;
using Ui.Tests.CorporateWebsite.Steps.TestData.Customers;

namespace Ui.Tests
{
    public class CorporateWebsiteTests : BaseTest
    {
        public static IEnumerable<MenuItem> MenuInfoExpected { get; } = DataContext.LoadMenuItems();

        public static IEnumerable<PanelItem> PanelInfoExpected { get; } = DataContext.LoadPanelItems();

        public static IEnumerable<ImageCard> ImageCardInfoExpected { get; } = DataContext.LoadImageCards();

        private HomePageSteps _homePageSteps;
        private ClaimsSteps _claimsSteps;
        private ManageYourPolicySteps _manageYourPolicySteps;
        private MakeAPaymentSteps _makeAPaymentSteps;
        private AboutUsPageSteps _aboutUsPageSteps;
        private int _tabsCountBeforeEachTest;

        [OneTimeSetUp]
        public void Initialize()
        {
            _homePageSteps = new HomePageSteps(Driver);
            _claimsSteps = new ClaimsSteps(Driver);
            _makeAPaymentSteps = new MakeAPaymentSteps(Driver);
            _manageYourPolicySteps = new ManageYourPolicySteps(Driver);
            _homePageSteps = new HomePageSteps(Driver);
            _aboutUsPageSteps = new AboutUsPageSteps(Driver);
        }

        [SetUp]
        public void BeforEachTest()
        {
            _homePageSteps.NavigateTo();
            _tabsCountBeforeEachTest = _homePageSteps.GetCurrentTabsCount();
        }

        [TearDown]
        public void AfterEachTest()
        {
            _homePageSteps.CloseAllTabsExceptFirst();
        }

        [Test]
        public void TestCase_01_SecuredConnection()
        {
            _homePageSteps.NavigateWithoutSsl();
            _homePageSteps.VerifyRedirectedToHttps();
        }

        [Test]
        [TestCaseSource(nameof(MenuInfoExpected))]
        public void TestCase_02_MainMenu_ItemsAreCorrect(MenuItem menuItem)
        {
            _homePageSteps.VerifyMenuItemPresented(menuItem);
            _homePageSteps.ClickMenuItemByName(menuItem.Name);
            _homePageSteps.VerifyMenuItemRedirrect(menuItem);
        }

        [Test]
        public void TestCase_03_FooterItemsAreCorrect()
        {
            _homePageSteps.VerifyCorporateOfficeAddress();
            _homePageSteps.VerifyProductInquiries();
            _homePageSteps.VerifyCopyright();
            _homePageSteps.VerifyReportClaim();
        }

        [Test]
        [TestCaseSource(nameof(PanelInfoExpected))]
        public void TestCase_04_Claims_PanelItemsAreCorrect(PanelItem panelItem)
        {
            _claimsSteps.NavigateTo();
            _claimsSteps.VerifyPanelItemPresented(panelItem);
            _claimsSteps.ExpandPanelItem(panelItem);
            _claimsSteps.VerifyPanelContent(panelItem);
        }

        [Test]
        public void TestCase_05_FileAClaimLinksAreCorrect()
        {
            _claimsSteps.NavigateTo();
            _claimsSteps.ClickPanel(ClaimsTestData.FileClaimTitle);
            _claimsSteps.VerifyOneLinkFromFileAClaimSection(FileAClaimTestData.FileAClaimHomeownersExpectedUrl, "homeowners");
            _claimsSteps.VerifyOneLinkFromFileAClaimSection(FileAClaimTestData.FileAClaimSmallCommercialExpectedUrl, "small commercial");
            _claimsSteps.VerifyOneLinkFromFileAClaimSection(FileAClaimTestData.FileAClaimLargeCommercialExpectedUrl, "large commercial");
        }

        [Test]
        public void TestCase_06_Home_CookiePresented()
        {
            _homePageSteps.VerifyCookiePresented();
        }

        [Test]
        [TestCaseSource(nameof(ImageCardInfoExpected))]
        public void TestCase_07_AboutUsPageLeadershipTeamImagesAndNamesAreCorrect(ImageCard imageCardItem)
        {
            _aboutUsPageSteps.NavigateToPage();
            _aboutUsPageSteps.NavigateToLeadershipTeamView();
            _aboutUsPageSteps.VerifyIsTeamMemberExists(imageCardItem.TeamMemberName);

            _aboutUsPageSteps.VerifyIsTeamMemberImageDisplayed(imageCardItem.TeamMemberName);
            _aboutUsPageSteps.VerifyIsTeamMemberNameDisplayed(imageCardItem.TeamMemberName);

            _aboutUsPageSteps.ClickOnNameCard(imageCardItem.TeamMemberName);

            _aboutUsPageSteps.VerifyTeamMemberJobTitle(imageCardItem.TeamMemberName, imageCardItem.JobTitle);
            _aboutUsPageSteps.VerifyTeamMemberLocation(imageCardItem.TeamMemberName, imageCardItem.Location);
        }

        [Test]
        public void TestCase_08_Footer_SocialLinksAreOpening()
        {
            _homePageSteps.VerifySocialLinks();
        }

        [Test]
        public void TestCase_09_VelocityLogoImageAndNavBarAreCorrect()
        {
            _homePageSteps.VerifyLogoIsPresent();
            _homePageSteps.VerifyNavBarIsOrange();
        }

        [Test]
        public void TestCase_10_Customers_ManageYourPolicy()
        {
            _manageYourPolicySteps.ClickCustomersManageYourPolicyMenuItem();
            _manageYourPolicySteps.VerifyNewTabIsOpened(_tabsCountBeforeEachTest);
            _manageYourPolicySteps.SwitchToLastOpenedTab();
            _manageYourPolicySteps.VerifyPageUrl(ManageYourPolicyTestData.LoginPageUrlWithoutProtocol);
            _manageYourPolicySteps.VerifyRedirectedToHttps();
            _manageYourPolicySteps.VerifyNewTabPageTitle(ManageYourPolicyTestData.LoginPageTitleText);
            _manageYourPolicySteps.VerifyNewTabPageHeader(ManageYourPolicyTestData.LoginPageHeaderText);
        }

        [Test]
        public void TestCase_11_Customers_MakeAPayment()
        {
            _makeAPaymentSteps.ClickCustomersMakeAPaymentMenuItem();
            _makeAPaymentSteps.VerifyNewTabIsOpened(_tabsCountBeforeEachTest);
            _makeAPaymentSteps.SwitchToLastOpenedTab();
            _makeAPaymentSteps.VerifyRedirectedToHttps();
            _makeAPaymentSteps.VerifyCustomerHasOptionToPayByCreditCardOrCheck();
        }
    }
}