using OpenQA.Selenium;

namespace Ui.Tests.PolicyAdminSystem.PageObjectModels
{
    public class LoginPage : PolicyAdminSystemBasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
            PageUrl = "https://velocity-uat.britecorepro.com/login/ko_login";
        }

        public IWebElement UserNameTextBox => Driver.FindElement(By.CssSelector("#username"));
        public IWebElement PasswordTextBox => Driver.FindElement(By.CssSelector("#password"));

        public IWebElement CantRememberLink => Driver.FindElement(By.CssSelector("#recoverEmail"));
        public IWebElement CantRememberModalWindowCloseButton => Driver.FindElement(By.CssSelector(".modal-header button"));
        public IWebElement CantRememberEmailTextBox => Driver.FindElement(By.XPath("//label[contains(text(), 'Email Address')]/input"));
        public IWebElement CantRememberOkButton => Driver.FindElement(By.CssSelector(".modal-body .btn-primary"));
        public IWebElement CantRememberCancelButton => Driver.FindElement(By.CssSelector(".modal-body .btn-default"));

        public IWebElement LoginButton => Driver.FindElement(By.CssSelector("#login"));

        public IWebElement DisclaimerLink => Driver.FindElement(By.XPath("//a[contains(text(), 'Disclaimer')]"));
        public IWebElement TermsOfUseLink => Driver.FindElement(By.XPath("//a[contains(text(), 'Terms of Use')]"));
        public IWebElement PrivacyPolicyLink => Driver.FindElement(By.XPath("//a[contains(text(), 'Privacy Policy')]"));
    }
}