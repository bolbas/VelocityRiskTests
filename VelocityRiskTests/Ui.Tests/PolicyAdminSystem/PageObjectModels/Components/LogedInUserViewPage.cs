using OpenQA.Selenium;
using Ui.Tests.Common;

namespace Ui.Tests.PolicyAdminSystem.PageObjectModels.Components
{
    public class LogedInUserViewPage : CommonBasePage
    {
        public LogedInUserViewPage(IWebDriver driver) : base(driver) { }

        public IWebElement HeaderLogoLink => Driver.FindElement(By.CssSelector(".bc-nav__logo"));
        public IWebElement HeaderNewQuoteLink => Driver.FindElement(By.CssSelector("header a[title='New Quote']"));
        public IWebElement HeaderPoliciesLink => Driver.FindElement(By.CssSelector("header a[title='Policies']"));
        public IWebElement HeaderClaimsLink => Driver.FindElement(By.CssSelector("header a[title='Claims']"));
        public IWebElement HeaderPaymentsLink => Driver.FindElement(By.CssSelector("header a[title='Payments']"));
        public IWebElement HeaderSettingsLink => Driver.FindElement(By.CssSelector("header a[title='Settings']"));

        public IWebElement FooterAccountInformationLink => Driver.FindElement(By.XPath("//a[contains(text(), 'Account Information')]"));
        public IWebElement FooterLogOutLink => Driver.FindElement(By.CssSelector("#logout"));
        public IWebElement FooterPersonalLinesLink => Driver.FindElement(By.XPath("//a[contains(text(), 'Personal Lines')]"));
        public IWebElement FooterPersonalLinesEmailLink => Driver.FindElement(By.XPath("//a[contains(text(), 'Email: underwriting@velocityrisk.com')]"));
        public IWebElement FooterSmallBusinessLink => Driver.FindElement(By.XPath("//a[contains(text(), 'Small Business')]"));
        public IWebElement FooterSmallBusinessEmailLink => Driver.FindElement(By.XPath("//a[contains(text(), 'Email: SMB.underwriting@velocityrisk.com')]"));
    }
}
