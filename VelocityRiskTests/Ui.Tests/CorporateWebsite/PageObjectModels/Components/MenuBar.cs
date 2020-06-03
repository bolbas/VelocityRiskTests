using OpenQA.Selenium;
using Ui.Tests.Common;

namespace Ui.Tests.CorporateWebsite.PageObjectModels.Components
{
    public class MenuBar : CommonBaseComponent
    {
        public MenuBar(IWebDriver driver) : base(driver) { }

        #region Agents

        public IWebElement AgentsMenuItemElement() => GetMenuItemElementByName(MenuItemType.Agents);

        #endregion

        #region Homeowners

        public IWebElement HomeownersMenuItemElement() => GetMenuItemElementByName(MenuItemType.Homeowners);

        #endregion

        #region Business

        public IWebElement BusinessMenuItemElement => GetExpandableMenuItemByName(MenuItemType.Business);
        public IWebElement BusinessLargeCommercialsMenuItemElement() => GetMenuItemElementByName(MenuItemType.BusinessLargeCommercial);
        public IWebElement BusinessSmallCommercialsMenuItemElement() => GetMenuItemElementByName(MenuItemType.BusinessSmallCommercial);

        #endregion

        #region Customers

        public IWebElement CustomersMenuItemElement => GetExpandableMenuItemByName(MenuItemType.Customers);
        public IWebElement CustomersClaimsMenuItemElement => GetMenuItemElementByName(MenuItemType.CustomersClaims);
        public IWebElement CustomersManageYourPolicyMenuItem() => GetMenuItemElementByName(MenuItemType.CustomersManageYourPolicy);
        public IWebElement CustomersMakePaymentMenuItem() => GetMenuItemElementByName(MenuItemType.CustomersMakePayment);

        #endregion

        #region Notes and News

        public IWebElement NotesAndNewsMenuItemElement() => GetMenuItemElementByName(MenuItemType.NotesAndNews);
        
        #endregion 

        #region Private Methods

        private IWebElement GetMenuLinkByItemName(MenuItemType item)
        {
            return Driver.FindElement(By.XPath($"//li/a[contains(text(), '{item.Value}')]"));
        }

        private IWebElement GetExpandableMenuItemByName(MenuItemType item)
        {
            return Driver.FindElement(By.XPath($"//ul[@id='top-menu']//a[contains(text(), '{item.Value}')]"));
        }

        private IWebElement GetMenuItemElementByName(MenuItemType item)
        {
            return GetMenuLinkByItemName(item);
        }

        #endregion
    }
}
