using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;

namespace Ui.Tests.PolicyAdminSystem.PageObjectModels
{
    public class QuoteRisksPage : PolicyAdminSystemBasePage
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

    public class EditLocationAdressCompoment : PolicyAdminSystemBasePage
    {
        public EditLocationAdressCompoment(IWebDriver driver) : base(driver)
        {
           
        }

        public IWebElement StreetAddressOrPoBoxInput => Driver.FindElement(By.XPath("//input[@data-test-id='address-input-line1']"));

        public IWebElement AptSuiteOrUnitNumberInput => Driver.FindElement(By.XPath("//input[@data-test-id='address-input-line2']"));

        public IWebElement ZipCodeInput => Driver.FindElement(By.XPath("//input[@data-test-id='address-input-zip']"));

        //Has the insured had any property claims at this location in the past 5 years? Loss history is required for each location.
        public IWebElement InsuredHadClaimsAtThisLocationInThePast5Years => Driver.FindElement(By.XPath("//span[contains(text(), 'Has the insured had any property claims at this location in the past 5 years? Loss history is required for each location.')]/ancestor::div[@class='bc-form__label c-builder-edit__question bc-form__label--has-validation']"));
        public IWebElement InsuredHadClaimsAtThisLocationInThePast5YearsYesInput => Driver.FindElement(By.XPath("//input[@value ='Yes']"));
        public IWebElement InsuredHadClaimsAtThisLocationInThePast5YearsNoInput => Driver.FindElement(By.XPath("//input[@value ='No']"));

        //How many years has the applicant owned and operated this specific business?
        public IWebElement YearsApplicantOwnedOperatedBusiness => Driver.FindElement(By.XPath("//span[contains(text(), 'How many years has the applicant owned and operated this specific business?')]/ancestor::div[@class='bc-form__label c-builder-edit__question bc-form__label--has-validation']"));
        public IWebElement YearsApplicantOwnedOperatedBusinessLessThanYearInput => Driver.FindElement(By.XPath("//input[@value ='Less than a year']"));
        public IWebElement YearsApplicantOwnedOperatedBusinessOneToThreeInput => Driver.FindElement(By.XPath("//input[@value ='1-3']"));
        public IWebElement YearsApplicantOwnedOperatedBusinessMoreThanThree => Driver.FindElement(By.XPath("//input[@value ='More than 3']"));       

        public IWebElement AdditionalLossInformationButton => Driver.FindElement(By.XPath("//button[contains(text(), 'Additional Loss Information')]"));
        public IWebElement AddMortgageeButton => Driver.FindElement(By.XPath("//button[@type='button' and contains(., 'Add a Mortgagee')]"));
        public IWebElement SaveDetailsAndContinueButton => Driver.FindElement(By.XPath("//button[text() ='Save Details & Continue']"));
    }

    public class EditRiskDetailsComponent : PolicyAdminSystemBasePage
    {
        public EditRiskDetailsComponent(IWebDriver driver) : base(driver)
        {

        }

        public IWebElement GoToNextBlankFieldButton => Driver.FindElement(By.XPath("//button[text() ='Go to Next Blank Field']"));

        public IWebElement ItemNameInput => Driver.FindElement(By.XPath("//input[@class='form-control fw2']"));

        public IWebElement AddCoveragesOrItemsButton => Driver.FindElement(By.XPath("//button[text() ='Add coverages or items']"));


        public IWebElement CoverageABuildingLimitInput => Driver.FindElement(By.XPath("//input[@data-test-id ='policy-wizard-builder-coverage-a-building-limit']"));

        public IWebElement CoverageBOtherStructuresLimitInput => Driver.FindElement(By.XPath("//input[@data-test-id ='policy-wizard-builder-coverage-b-other-structures-limit']"));

        public IWebElement CoverageCContentsLimitInput => Driver.FindElement(By.XPath("//input[@data-test-id ='policy-wizard-builder-coverage-c-contents-limit']"));

        public IWebElement CoverageDBusinessIncomeLimitInput => Driver.FindElement(By.XPath("//input[@data-test-id ='policy-wizard-builder-coverage-d-business-income-limit']"));

        #region Rating Information

        public IWebElement ZipCode => Driver.FindElement(By.XPath("//strong[@data-test-id='policy-wizard-builder-zip-code-category-input']"));

        public IWebElement CountyParish => Driver.FindElement(By.XPath("//strong[@data-test-id='policy-wizard-builder-countyparish-category-input']"));

        public SelectElement OccupancySelect => new SelectElement(Driver.FindElement(By.XPath("//select[@data-test-id= 'policy-wizard-builder-occupancy-category-input']")));

        public SelectElement BuildingConstructionSelect => new SelectElement(Driver.FindElement(By.XPath("//select[@data-test-id='policy-wizard-builder-building-construction-category-input']")));

        public SelectElement RoofShapeSelect => new SelectElement(Driver.FindElement(By.XPath("//select[@data-test-id='policy-wizard-builder-roof-shape-category-input']")));

        public IWebElement BuildingYearBuiltInput => Driver.FindElement(By.XPath("//input[@data-test-id='policy-wizard-builder-building-year-built-category-input']"));

        #region Number Of Stories
        public IWebElement NumberOfStories => Driver.FindElement(By.XPath("//span[@data-test-id='policy-wizard-builder-number-of-stories-category-label']/ancestor::div[contains(@class, 'bc-form__label')]"));

        public IWebElement NumberOfStories1Button => Driver.FindElement(By.XPath("//label[@data-test-id='policy-wizard-builder-number-of-stories-category-button-1']"));

        public IWebElement NumberOfStories2Button => Driver.FindElement(By.XPath("//label[@data-test-id='policy-wizard-builder-number-of-stories-category-button-2']"));

        public IWebElement NumberOfStories3Button => Driver.FindElement(By.XPath("//label[@data-test-id='policy-wizard-builder-number-of-stories-category-button-3']"));

        public IWebElement NumberOfStories4Button => Driver.FindElement(By.XPath("//label[@data-test-id='policy-wizard-builder-number-of-stories-category-button-4']"));

        public IWebElement NumberOfStories5Button => Driver.FindElement(By.XPath("//label[@data-test-id='policy-wizard-builder-number-of-stories-category-button-5']"));

        public IWebElement NumberOfStories6Button => Driver.FindElement(By.XPath("//label[@data-test-id='policy-wizard-builder-number-of-stories-category-button-6']"));
        #endregion

        public SelectElement RoofReplacementYearSelect => new SelectElement(Driver.FindElement(By.XPath("//select[@data-test-id='policy-wizard-builder-roof-replacement-year-category-input']")));

        public IWebElement ProtectionClass => Driver.FindElement(By.XPath("//strong[@data-test-id='policy-wizard-builder-protection-class-category-input']"));

        #region Central Monitored Burglar Alarm
        public IWebElement CentralMonitoredBurglarAlarm => Driver.FindElement(By.XPath("//span[@data-test-id='policy-wizard-builder-central-monitored-burglar-alarm-category-label']/ancestor::div[contains(@class, 'bc-form__label')]"));

        public IWebElement CentralMonitoredBurglarAlarmNoButton => Driver.FindElement(By.XPath("//label[@data-test-id='policy-wizard-builder-central-monitored-burglar-alarm-category-button-1']"));

        public IWebElement CentralMonitoredBurglarAlarmUnknownButton => Driver.FindElement(By.XPath("//label[@data-test-id='policy-wizard-builder-central-monitored-burglar-alarm-category-button-2']"));

        public IWebElement CentralMonitoredBurglarAlarmYesButton => Driver.FindElement(By.XPath("//label[@data-test-id='policy-wizard-builder-central-monitored-burglar-alarm-category-button-3']"));
        #endregion

        #region Central Monitored Fire Alarm
        public IWebElement CentralMonitoredFireAlarm => Driver.FindElement(By.XPath("//span[@data-test-id='policy-wizard-builder-central-monitored-fire-alarm-category-label']/ancestor::div[contains(@class, 'bc-form__label')]"));

        public IWebElement CentralMonitoredFireAlarmNoButton => Driver.FindElement(By.XPath("//label[@data-test-id='policy-wizard-builder-central-monitored-fire-alarm-category-button-1']"));

        public IWebElement CentralMonitoredFireAlarmUnknownButton => Driver.FindElement(By.XPath("//label[@data-test-id='policy-wizard-builder-central-monitored-fire-alarm-category-button-2']"));

        public IWebElement CentralMonitoredFireAlarmYesButton => Driver.FindElement(By.XPath("//label[@data-test-id='policy-wizard-builder-central-monitored-fire-alarm-category-button-3']"));
        #endregion

        #region Fire Protection Sprinklers
        public IWebElement FireProtectionSprinklers => Driver.FindElement(By.XPath("//span[@data-test-id='policy-wizard-builder-fire-protection-sprinklers-category-label']/ancestor::div[contains(@class, 'bc-form__label')]"));

        public IWebElement FireProtectionSprinklersNoButton => Driver.FindElement(By.XPath("//label[@data-test-id='policy-wizard-builder-fire-protection-sprinklers-category-button-1']"));

        public IWebElement FireProtectionSprinklersUnknownButton => Driver.FindElement(By.XPath("//label[@data-test-id='policy-wizard-builder-fire-protection-sprinklers-category-button-2']"));

        public IWebElement FireProtectionSprinklersYesButton => Driver.FindElement(By.XPath("//label[@data-test-id='policy-wizard-builder-fire-protection-sprinklers-category-button-3']"));
        #endregion

        public IWebElement WhatIsTheRoofCondition => Driver.FindElement(By.XPath("//span[@data-test-id='policy-wizard-builder-what-is-the-roof-condition-category-label']/ancestor::div[contains(@class, 'bc-form__label')]"));

        public SelectElement RoofAnchorageSelect => new SelectElement(Driver.FindElement(By.XPath("//select[@data-test-id='policy-wizard-builder-roof-anchorage-category-input']")));

        public SelectElement RoofCoverSelect => new SelectElement(Driver.FindElement(By.XPath("//select[@data-test-id='policy-wizard-builder-roof-cover-category-input']")));

        public SelectElement RoofDeckSelect => new SelectElement(Driver.FindElement(By.XPath("//select[@data-test-id='policy-wizard-builder-roof-deck-category-input']")));

        public SelectElement RoofDeckAttachmentSelect => new SelectElement(Driver.FindElement(By.XPath("//select[@data-test-id='policy-wizard-builder-roof-deck-attachment-category-input']")));

        public IWebElement DoesMoreThan20EifsExistsOnTheBuilding => Driver.FindElement(By.XPath("//span[@data-test-id='policy-wizard-builder-does-more-than-20-eifs-exists-on-the-building-category-label']/ancestor::div[contains(@class, 'bc-form__label')]"));

        public IWebElement DoesMoreThan20EifsExistsOnTheBuildingNoButton => Driver.FindElement(By.XPath("//label[@data-test-id='policy-wizard-builder-does-more-than-20-eifs-exists-on-the-building-category-button-1']"));

        public IWebElement DoesMoreThan20EifsExistsOnTheBuildingYesButton => Driver.FindElement(By.XPath("//label[@data-test-id='policy-wizard-builder-does-more-than-20-eifs-exists-on-the-building-category-button-2']"));

        public SelectElement YearPlumbingWasLastUpdatedSelect => new SelectElement(Driver.FindElement(By.XPath("//select[@data-test-id='policy-wizard-builder-year-plumbing-was-last-updated-category-input']")));

        public SelectElement YearHvacWasLastUpdatedSelect => new SelectElement(Driver.FindElement(By.XPath("//select[@data-test-id='policy-wizard-builder-year-hvac-was-last-updated-category-input']")));

        public SelectElement YearElectricalWasLastUpdatedSelect => new SelectElement(Driver.FindElement(By.XPath("//select[@data-test-id='policy-wizard-builder-year-electrical-was-last-updated-category-input']")));

        public IWebElement CommentsInput => Driver.FindElement(By.XPath("//input[@data-test-id='policy-wizard-user-input-comments']"));

        public IWebElement SquareFootageInput => Driver.FindElement(By.XPath("//input[@data-test-id='policy-wizard-user-input-square-footage']"));

        public IWebElement BuildingWasBuiltPriorTo1968Input => Driver.FindElement(By.XPath("//input[@data-test-id='policy-wizard-user-input-if-building-was-built-prior-to-1968-please-disclose-all-electricalplumbinghvac-updates-for-this-risk-risks-built-prior-to-1968-will-require-all-systems-to-be-updated-for-aop-coverage']"));

        #endregion

        public IWebElement SaveInformationButton => Driver.FindElement(By.XPath("//button[text() ='Save Information']"));

        public IWebElement CalculateRateButton => Driver.FindElement(By.XPath("//button[@class='btn btn-primary btn-sm mt3']"));
    }
}
