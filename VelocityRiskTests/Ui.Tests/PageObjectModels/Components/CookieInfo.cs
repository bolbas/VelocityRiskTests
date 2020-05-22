﻿using OpenQA.Selenium;

namespace Ui.Tests.PageObjectModels.Components
{
    public class CookieInfo : BaseComponent
    {
        public IWebElement Disclaimer => Driver.FindElement(By.XPath("//div[@id='cookie-law-info-bar']//a[@href= 'https://velocityrisk.com/disclaimer/']"));

        public IWebElement TermsOfUse => Driver.FindElement(By.XPath("//div[@id='cookie-law-info-bar']//a[@href= 'https://velocityrisk.com/terms-of-use/']"));

        public IWebElement PrivacyPolicy => Driver.FindElement(By.XPath("//div[@id='cookie-law-info-bar']//a[@href= 'https://velocityrisk.com/privacy-policy/']"));

        public IWebElement Accept => Driver.FindElement(By.Id("cookie_action_close_header"));

        public CookieInfo(IWebDriver driver) : base(driver) { }
    }
}
