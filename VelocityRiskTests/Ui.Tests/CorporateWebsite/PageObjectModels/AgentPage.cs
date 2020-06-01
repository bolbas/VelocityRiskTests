using OpenQA.Selenium;

namespace Ui.Tests.CorporateWebsite.PageObjectModels
{
    public class AgentPage : HomePage
    {
        public AgentPage(IWebDriver driver) : base(driver)
        {
            PageUrl = "https://velocityrisk.com/for-agents/";
        }

        public IWebElement GetStartedButton => Driver.FindElement(By.CssSelector("a[href='#appointment_headline']"));

        public IWebElement LogInButton => Driver.FindElement(By.CssSelector("a[href='http://velocityrisk.com/for-agents/#login_links']"));


        public IWebElement VelocityFlexHomeLink => Driver.FindElement(By.XPath("//div[@id='login_links']//a[contains(text(), 'Velocity Flex Home')]"));

        public IWebElement ConnecticutLink => Driver.FindElement(By.XPath("//div[@id='login_links']//a[contains(text(), 'Connecticut')]"));

        public IWebElement FloridaLink => Driver.FindElement(By.XPath("//div[@id='login_links']//a[contains(text(), 'Florida')]"));

        public IWebElement NewJerseyLink => Driver.FindElement(By.XPath("//div[@id='login_links']//a[contains(text(), 'New Jersey')]"));

        public IWebElement NewYorkLink => Driver.FindElement(By.XPath("//div[@id='login_links']//a[contains(text(), 'New York')]"));

        public IWebElement NorthCarolinaLink => Driver.FindElement(By.XPath("//div[@id='login_links']//a[contains(text(), 'North Carolina')]"));

        public IWebElement TexasLink => Driver.FindElement(By.XPath("//div[@id='login_links']//a[contains(text(), 'Texas')]"));

        public IWebElement SmallCommercialPortalLink => Driver.FindElement(By.XPath("//div[@id='login_links']//a[contains(text(), 'here')]"));


        public IWebElement LargeCommercialButton => Driver.FindElement(By.XPath("//div[@class='cta_part']//span[contains(text(), 'Large Commercial')]"));

        public IWebElement SmallCommercialButton => Driver.FindElement(By.XPath("//div[@class='cta_part']//span[contains(text(), 'Small Commercial')]"));

        public IWebElement PersonalLinesButton => Driver.FindElement(By.XPath("//div[@class='cta_part']//span[contains(text(), 'Personal Lines')]"));
    }
}