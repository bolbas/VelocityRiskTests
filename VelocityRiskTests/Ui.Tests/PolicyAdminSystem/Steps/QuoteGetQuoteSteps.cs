using System;
using OpenQA.Selenium;
using Ui.Tests.PolicyAdminSystem.PageObjectModels;

namespace Ui.Tests.PolicyAdminSystem.Steps
{
    public class QuoteGetQuoteSteps : PolicyAdminSystemBaseSteps<QuoteGetQuotePage>
    {
        public QuoteGetQuoteSteps(IWebDriver driver) : base(driver) { }

        public void NavigateTo(Guid policyId)
        {
            Page.PolicyId = policyId;
            Driver.Navigate().GoToUrl(Page.PageUrl);
        }

        #region Deductibles

        public void ClickDeductiblePercent1Button()
        {
            Page.DeductiblePercent1Button?.Click();
        }

        public void ClickDeductiblePercent2Button()
        {
            Page.DeductiblePercent2Button?.Click();
        }

        public void ClickDeductiblePercent3Button()
        {
            Page.DeductiblePercent3Button?.Click();
        }

        public void ClickDeductiblePercent5Button()
        {
            Page.DeductiblePercent5Button?.Click();
        }

        public void ClickDeductiblePercent10Button()
        {
            Page.DeductiblePercent10Button?.Click();
        }

        #endregion Deductibles

        #region Earthquake Premium

        public void ClickEarthquakePremiumCheckbox()
        {
            Page.EarthquakePremiumCheckbox?.Click();
        }

        public void CheckEarthquakePremiumCheckbox()
        {
            var isChecked = Convert.ToBoolean(Page.EarthquakePremiumCheckboxInput?.GetAttribute("value"));
            if (!isChecked)
            {
                Page.EarthquakePremiumCheckbox.Click();
            }
        }

        public void UncheckEarthquakePremiumCheckbox()
        {
            var isChecked = Convert.ToBoolean(Page.EarthquakePremiumCheckboxInput?.GetAttribute("value"));
            if (isChecked)
            {
                Page.EarthquakePremiumCheckbox.Click();
            }
        }

        #endregion Earthquake Premium

        public void ClickTerrorisRiskButton(bool yes)
        {
            if (yes)
            {
                Page.TerrorismRiskYesButton.Click();
            }
            else
            {
                Page.TerrorismRiskNoButton.Click();
            }
        }

        #region Upgrade

        public void ClickIncluded()
        {
            Page.IncludedButton.Click();
        }

        public void ClickUpgradeToSilver()
        {
            Page.UpgradeToSilverButton.Click();
        }

        public void ClickUpgradeToGold()
        {
            Page.UpgradeToGoldButton.Click();
        }

        #endregion Upgrade

        public void ClickDirectRepair(bool yes)
        {
            if (yes)
            {
                Page.DirectRepairYesButton.Click();
            }
            else
            {
                Page.DirectRepairNoButton.Click();
            }
        }

        #region Additional Premium

        public string GetAdditionalPremiumValue()
        {
            return Page.AdditionalPremiumInput.GetAttribute("value");
        }

        public void SetAdditionalPremiumValue(string text)
        {
            Page.AdditionalPremiumInput.SendKeys(text);
        }

        #endregion Additional Premium

        #region Underwriting Review

        public void NavigateToViewQuoteSummaryLink()
        {
            var href = Page.ViewQuoteSummaryLink.GetAttribute("href");
            if (href != null)
            {
                Driver.Navigate().GoToUrl(href);
            }
        }

        public void NavigateToShareQuoteSummaryLink()
        {
            var href = Page.ShareQuoteSummaryLink.GetAttribute("href");
            if (href != null)
            {
                Driver.Navigate().GoToUrl(href);
            }
        }

        public void ClickSendEmailButton()
        {
            Page.SendEmailButton.Click();
        }

        public void ClickContinueToBindButton()
        {
            Page.ContinueToBindButton.Click();
        }

        public void ClickDiscardQuoteButton()
        {
            Page.DiscardQuoteButton.Click();
        }

        #endregion Underwriting Review
    }
}
