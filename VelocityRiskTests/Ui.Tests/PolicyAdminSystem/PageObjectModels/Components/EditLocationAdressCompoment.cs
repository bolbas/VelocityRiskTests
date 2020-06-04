using OpenQA.Selenium;
using Ui.Tests.Common;

namespace Ui.Tests.PolicyAdminSystem.PageObjectModels.Components
{
    public class EditLocationAdressCompoment : CommonBaseComponent
    {
        public EditLocationAdressCompoment(IWebDriver driver) : base(driver)
        {

        }

        public IWebElement StreetAddressOrPoBoxInput => Driver.FindElement(By.XPath("//input[@data-test-id='address-input-line1']"));

        public IWebElement AptSuiteOrUnitNumberInput => Driver.FindElement(By.XPath("//input[@data-test-id='address-input-line2']"));

        public IWebElement ZipCodeInput => Driver.FindElement(By.XPath("//input[@data-test-id='address-input-zip']"));

        //Has the insured had any property claims at this location in the past 5 years? Loss history is required for each location.
        public IWebElement InsuredHadClaimsAtThisLocationInThePast5Years => Driver.FindElement(By.XPath("//span[contains(text(), 'Has the insured had any property claims at this location in the past 5 years? Loss history is required for each location.')]/ancestor::div[contains(@class, 'bc-form__label')]"));
        public IWebElement InsuredHadClaimsAtThisLocationInThePast5YearsYesInput => InsuredHadClaimsAtThisLocationInThePast5Years.FindElement(By.XPath("//input[@value ='Yes']"));
        public IWebElement InsuredHadClaimsAtThisLocationInThePast5YearsNoInput => InsuredHadClaimsAtThisLocationInThePast5Years.FindElement(By.XPath("//input[@value ='No']"));

        //How many years has the applicant owned and operated this specific business?
        public IWebElement YearsApplicantOwnedOperatedBusiness => Driver.FindElement(By.XPath("//span[contains(text(), 'How many years has the applicant owned and operated this specific business?')]/ancestor::div[contains(@class, 'bc-form__label')]"));
        public IWebElement YearsApplicantOwnedOperatedBusinessLessThanYearInput => YearsApplicantOwnedOperatedBusiness.FindElement(By.XPath("//input[@value ='Less than a year']"));
        public IWebElement YearsApplicantOwnedOperatedBusinessOneToThreeInput => YearsApplicantOwnedOperatedBusiness.FindElement(By.XPath("//input[@value ='1-3']"));
        public IWebElement YearsApplicantOwnedOperatedBusinessMoreThanThree => YearsApplicantOwnedOperatedBusiness.FindElement(By.XPath("//input[@value ='More than 3']"));

        public IWebElement AdditionalLossInformationButton => Driver.FindElement(By.XPath("//button[contains(text(), 'Additional Loss Information')]"));
        public IWebElement AddMortgageeButton => Driver.FindElement(By.XPath("//button[@type='button' and contains(., 'Add a Mortgagee')]"));
        public IWebElement SaveDetailsAndContinueButton => Driver.FindElement(By.XPath("//button[text() ='Save Details & Continue']"));
    }
}
