using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Ui.Tests.CorporateWebsite.PageObjectModels
{
    public class HomeownersPage : CorporateWebsiteHomePage
    {
        public HomeownersPage(IWebDriver driver) : base(driver)
        {
            PageUrl = "https://velocityrisk.com/for-homeowners/";
        }

        public IWebElement HomeownersMoreInfoLink => Driver.FindElement(By.XPath("//h3[text() ='Homeowners']/following-sibling::a"));

        public IWebElement RentalPropertiesMoreInfoLink => Driver.FindElement(By.XPath("//h3[text() ='Rental Properties']/following-sibling::a"));

        public IWebElement CondominiumsMoreInfoLink => Driver.FindElement(By.XPath("//h3[text() ='Condominiums']/following-sibling::a"));

        public IWebElement GetStartedButton => Driver.FindElement(By.XPath("//a[text()='Get Started']"));

        public IWebElement MakePaymentButton => Driver.FindElement(By.XPath("//a[text()='Make a Payment']"));

        public IWebElement ManageAccountButton => Driver.FindElement(By.XPath("//a[text()='Manage Account']"));

        public IWebElement ExpandAllButton => Driver.FindElement(By.ClassName("expand_text"));

        public IWebElement CustomerDropDownItems => Driver.FindElement(By.ClassName("faq_button_part homeowners_banner_buttonpart"));

        public IWebElement ContactUsButton => Driver.FindElement(By.ClassName("modal_popupbutton open-modal-popup"));

        public IWebElement NationalWeatherServiceLink => Driver.FindElement(By.XPath("//a[text()='National Weather Service']"));

        [FindsBy(How = How.LinkText, Using = "")]
        public IWebElement NoaaNationalHurricaneCenterLink => Driver.FindElement(By.XPath("//a[text()='NOAA National Hurricane Center']"));

        [FindsBy(How = How.LinkText, Using = "")]
        public IWebElement UsgsWorldEqMapsLink => Driver.FindElement(By.XPath("//a[text()='USGS World EQ Maps']"));

        [FindsBy(How = How.LinkText, Using = "")]
        public IWebElement NothernCaliforniaEqDataLink => Driver.FindElement(By.XPath("//a[text()='Northern California EQ Data']"));

        [FindsBy(How = How.LinkText, Using = "")]
        public IWebElement SouthernCaliforniaEqDataLink => Driver.FindElement(By.XPath("//a[text()='Southern California EQ Data']"));

        [FindsBy(How = How.LinkText, Using = "")]
        public IWebElement PacificNorthwestEqDataLink => Driver.FindElement(By.XPath("//a[text()='Pacific Northwest EQ Data']"));

        [FindsBy(How = How.LinkText, Using = "")]
        public IWebElement IntermountainWestEqDataLink => Driver.FindElement(By.XPath("//a[text()='Intermountain West EQ Data']"));

        [FindsBy(How = How.LinkText, Using = "")]
        public IWebElement FemaFloodMapsLink => Driver.FindElement(By.XPath("//a[text()='FEMA Flood Maps']"));

        public IWebElement ReportClaimLink => Driver.FindElement(By.XPath("//p[@class='contact_title']/a"));
    }
}
