using OpenQA.Selenium;

namespace Ui.Tests.CorporateWebsite.PageObjectModels
{
    public class MakePaymentPage : BasePage
    {
        public IWebElement PayWithCheck => Driver.FindElement(By.XPath("//input[@value='Pay with Check']"));
        public IWebElement PayWithCreditCard => Driver.FindElement(By.XPath("//input[@value='Pay with Credit Card']"));
        public IWebElement CheckOrCreditCardForm => Driver.FindElement(By.XPath("//form"));

        public MakePaymentPage(IWebDriver driver) : base(driver)
        {
            PageUrl = "https://portal.icheckgateway.com/Velocity/";
        }
    }
}
