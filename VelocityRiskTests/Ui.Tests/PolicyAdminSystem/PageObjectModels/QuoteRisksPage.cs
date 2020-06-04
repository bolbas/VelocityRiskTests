using OpenQA.Selenium;
using System.Collections.ObjectModel;
using Ui.Tests.PolicyAdminSystem.PageObjectModels.Components;

namespace Ui.Tests.PolicyAdminSystem.PageObjectModels
{
    public class QuoteRisksPage : PolicyAdminSystemHomePage
    {
        public QuoteRisksPage(IWebDriver driver) : base(driver)
        {
            // TODO add a proper value for this property
            PageUrl = "";
        }

        public IWebElement LocationNameInput => Driver.FindElement(By.XPath("//label[@data-test-id ='policy-wizard-risks-prop-name-0']/input"));

        public IWebElement HowManyLocationsAreOnThisPolicyInput => Driver.FindElement(By.XPath("//div[@class ='mt1']//input[contains(@class,'form-control')]"));

        public IWebElement HowManyLocationsAreOnThisPolicyAddButton => Driver.FindElement(By.XPath("//div[@class ='mt1']//button[@title='Add One']"));

        public IWebElement HowManyLocationsAreOnThisPolicySubtractButton => Driver.FindElement(By.XPath("//div[@class ='mt1']//button[@title='Subtract One']"));

        public IWebElement UpdateNumberOfRisksButton => Driver.FindElement(By.XPath("//button[@data-test-id ='policy-wizard-risks-counter-submit']"));

        public ReadOnlyCollection<IWebElement> AddAddressButtons => Driver.FindElements(By.XPath("//button[@type='button' and contains(., 'Add an Address')]"));

        public ReadOnlyCollection<IWebElement> EditLocationAddressButtons => Driver.FindElements(By.XPath("//button[@type='button' and contains(., 'Edit Location Address')]"));

        public ReadOnlyCollection<IWebElement> EnterRiskAndCoverageDetailsButtons => Driver.FindElements(By.XPath("//span[text()='Enter Risk & Coverage Details']/parent::button"));
       
        public ReadOnlyCollection<IWebElement> DeleteButtons => Driver.FindElements(By.XPath("//button[@type='button' and contains(., 'Delete')]"));

        public IWebElement CopyInformationAcrossLocationsButton => Driver.FindElement(By.XPath("//button[@data-test-id='policy-wizard-risks-copy-risk']"));

        public IWebElement GetAQuoteButton => Driver.FindElement(By.XPath("//button[text() ='Get a Quote']"));

        public EditLocationAdressCompoment EditLocationAdressCompoment { get; set; }

        public EditRiskDetailsComponent EditRiskDetailsComponent { get; set; }   
    }    
}
