﻿using OpenQA.Selenium;

namespace Ui.Tests.PolicyAdminSystem.PageObjectModels
{
    public class QuoteRisksPage : PolicyAdminSystemBasePage
    {
        public QuoteRisksPage(IWebDriver driver) : base(driver)
        {
            // TODO add a proper value for this property
            PageUrl = "";
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

        public IWebElement OccupancySelect => Driver.FindElement(By.XPath("//select[@data-test-id= 'policy-wizard-builder-occupancy-category-input']/parent::label"));

        public IWebElement BuildingConstructionSelect => Driver.FindElement(By.XPath("//select[@data-test-id='policy-wizard-builder-building-construction-category-input']/parent::label"));

        public IWebElement RoofShapeSelect => Driver.FindElement(By.XPath("//span[@data-test-id='policy-wizard-builder-roof-shape-category-label']/ancestor::label[contains(@class, 'bc-form__label')]"));

        public IWebElement BuildingYearBuiltInput => Driver.FindElement(By.XPath("//input[@data-test-id='policy-wizard-builder-building-year-built-category-input']"));

        public IWebElement NumberOfStories => Driver.FindElement(By.XPath("//span[@data-test-id='policy-wizard-builder-number-of-stories-category-label']/ancestor::div[contains(@class, 'bc-form__label')]"));

        public IWebElement RoofReplacementYearSelect => Driver.FindElement(By.XPath("//span[@data-test-id='policy-wizard-builder-roof-replacement-year-category-label']/ancestor::label[contains(@class, 'bc-form__label')]"));

        public IWebElement ProtectionClass => Driver.FindElement(By.XPath("//strong[@data-test-id='policy-wizard-builder-protection-class-category-input']"));

        public IWebElement CentralMonitoredBurglarAlarm => Driver.FindElement(By.XPath("//span[@data-test-id='policy-wizard-builder-central-monitored-burglar-alarm-category-label']/ancestor::div[contains(@class, 'bc-form__label')]"));

        public IWebElement CentralMonitoredFireAlarm => Driver.FindElement(By.XPath("//span[@data-test-id='policy-wizard-builder-central-monitored-fire-alarm-category-label']/ancestor::div[contains(@class, 'bc-form__label')]"));

        public IWebElement FireProtectionSprinklers => Driver.FindElement(By.XPath("//span[@data-test-id='policy-wizard-builder-fire-protection-sprinklers-category-label']/ancestor::div[contains(@class, 'bc-form__label')]"));

        public IWebElement WhatIsTheRoofCondition => Driver.FindElement(By.XPath("//span[@data-test-id='policy-wizard-builder-what-is-the-roof-condition-category-label']/ancestor::div[contains(@class, 'bc-form__label')]"));
        
        public IWebElement RoofAnchorageSelect => Driver.FindElement(By.XPath("//span[@data-test-id='policy-wizard-builder-roof-anchorage-category-label']/ancestor::label[contains(@class, 'bc-form__label')]"));

        public IWebElement RoofCoverSelect => Driver.FindElement(By.XPath("//span[@data-test-id='policy-wizard-builder-roof-cover-category-label']/ancestor::label[contains(@class, 'bc-form__label')]"));

        public IWebElement RoofDeckSelect => Driver.FindElement(By.XPath("//span[@data-test-id='policy-wizard-builder-roof-deck-category-label']/ancestor::label[contains(@class, 'bc-form__label')]"));

        public IWebElement RoofDeckAttachmentSelect => Driver.FindElement(By.XPath("//span[@data-test-id='policy-wizard-builder-roof-deck-attachment-category-label']/ancestor::label[contains(@class, 'bc-form__label')]"));

        public IWebElement DoesMoreThan20EifsExistsOnTheBuilding => Driver.FindElement(By.XPath("//span[@data-test-id='policy-wizard-builder-does-more-than-20-eifs-exists-on-the-building-category-label']/ancestor::div[contains(@class, 'bc-form__label')]"));

        public IWebElement YearPlumbingWasLastUpdatedSelect => Driver.FindElement(By.XPath("//span[@data-test-id='policy-wizard-builder-year-plumbing-was-last-updated-category-label']/ancestor::label[contains(@class, 'bc-form__label')]"));

        public IWebElement YearHvacWasLastUpdatedSelect => Driver.FindElement(By.XPath("//span[@data-test-id='policy-wizard-builder-year-hvac-was-last-updated-category-label']/ancestor::label[contains(@class, 'bc-form__label')]"));

        public IWebElement YearElectricalWasLastUpdatedSelect => Driver.FindElement(By.XPath("policy-wizard-builder-year-electrical-was-last-updated-category-label"));
        
        public IWebElement CommentsInput => Driver.FindElement(By.XPath("//input[@data-test-id='policy-wizard-user-input-comments']"));

        public IWebElement SquareFootageInput => Driver.FindElement(By.XPath("//input[@data-test-id='policy-wizard-user-input-square-footage']"));        

        public IWebElement BuildingWasBuiltPriorTo1968Input => Driver.FindElement(By.XPath("//input[@data-test-id='policy-wizard-user-input-if-building-was-built-prior-to-1968-please-disclose-all-electricalplumbinghvac-updates-for-this-risk-risks-built-prior-to-1968-will-require-all-systems-to-be-updated-for-aop-coverage']"));

        #endregion

        public IWebElement SaveInformationButton => Driver.FindElement(By.XPath("//button[text() ='Save Information']"));

        public IWebElement CalculateRateButton => Driver.FindElement(By.XPath("//button[@class='btn btn-primary btn-sm mt3']"));

    }
}
