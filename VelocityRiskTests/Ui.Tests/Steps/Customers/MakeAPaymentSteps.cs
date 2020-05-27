﻿using OpenQA.Selenium;
using Ui.Tests.PageObjectModels;

namespace Ui.Tests.Steps.Customers
{
    public class MakeAPaymentSteps : BaseSteps<MakePaymentPage>
    {
        public MakeAPaymentSteps(IWebDriver driver) : base(driver)
        {
            Page = new MakePaymentPage(Driver);
        }

        public void ClickCustomersMakeAPaymentMenuItem()
        {
            MouseHoverToElement(MenuBar.CustomersMenuItemElement);
            MenuBar.CustomersMakePaymentMenuItem().Click();
            SwitchToLastOpenedTab();
        }

        public void VerifyCustomerHasOptionToPayByCreditCardOrCheck()
        {
            WaitUntilElementIsVisible(Page.PayWithCheck);
            Page.PayWithCheck.Click();
            WaitUntilElementIsVisible(Page.CheckOrCreditCardForm);

            Driver.Navigate().Back();

            WaitUntilElementIsVisible(Page.PayWithCreditCard);
            Page.PayWithCreditCard.Click();
            WaitUntilElementIsVisible(Page.CheckOrCreditCardForm);
        }
    }
}
