using OpenQA.Selenium;

namespace Ui.Tests.CorporateWebsite.PageObjectModels.Components
{
    public class Footer : BaseComponent
    {
        #region Corporate Office

        public IWebElement CorporateOfficeAddress => Driver.FindElement(By.XPath("//div[@class='contact_office']//p[@class='contact_detail']"));

        public IWebElement CorporateOfficeLinkedIn => Driver.FindElement(By.XPath("//a[@class='velocity-social-icon'][i[@class='fa fa-linkedin']]"));

        public IWebElement CorporateOfficeFacebook => Driver.FindElement(By.XPath("//a[@class='velocity-social-icon'][i[@class='fa fa-facebook']]"));

        public IWebElement CorporateOfficeTwitter => Driver.FindElement(By.XPath("//a[@class='velocity-social-icon'][i[@class='fa fa-twitter']]"));

        public IWebElement CorporateOfficeInstagram => Driver.FindElement(By.XPath("//a[@class='velocity-social-icon'][i[@class='fa fa-instagram']]"));

        #endregion Corporate Office

        #region Report a claim

        public IWebElement ReportClaimPhoneNumber => Driver.FindElement(By.XPath("//div[@class='contact_claims']//a[@class='contact_detail']"));

        public IWebElement ReportClaimOnlineLink => Driver.FindElement(By.XPath("//div[@class='contact_claims']//a[contains(text(), 'Report a Claim Online')]"));

        #endregion Report a claim

        #region Product or Policy Inquiries

        public IWebElement PersonalLinesNumber => Driver.FindElement(By.XPath("//div[@class='contact_business']//p[contains(text(), 'Personal Lines: ')]//a"));

        public IWebElement SmallCommercialNumber => Driver.FindElement(By.XPath("//div[@class='contact_business']//p[contains(text(), 'Small Commercial: ')]//a"));

        public IWebElement LargeCommercialNumber => Driver.FindElement(By.XPath("//div[@class='contact_business']//p[contains(text(), 'Large Commercial: ')]//a"));


        #endregion Product or Policy Inquiries

        #region Copyright

        public IWebElement Disclaimer => Driver.FindElement(By.XPath("//p[@class='copyright_title']//a[contains(text(), 'Disclaimer')]"));

        public IWebElement TermsOfUse => Driver.FindElement(By.XPath("//p[@class='copyright_title']//a[contains(text(), 'Terms of Use')]"));

        public IWebElement PrivacyPolicy => Driver.FindElement(By.XPath("//p[@class='copyright_title']//a[contains(text(), 'Privacy Policy')]"));

        #endregion Copyright

        public Footer(IWebDriver driver) : base(driver) { }
    }
}
