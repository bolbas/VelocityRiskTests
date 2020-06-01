namespace Ui.Tests.CorporateWebsite.PageObjectModels.Components
{
    public class MenuItemType
    {
        private MenuItemType(string value)
        {
            Value = value;
        }

        public string Value { get; set; }

        public static MenuItemType Agents => new MenuItemType("Agents");

        public static MenuItemType Homeowners => new MenuItemType("Homeowners");

        public static MenuItemType Business => new MenuItemType("Business");
        public static MenuItemType BusinessLargeCommercial => new MenuItemType("Large Commercial");
        public static MenuItemType BusinessSmallCommercial => new MenuItemType("Small Commercial");

        public static MenuItemType Customers => new MenuItemType("Customers");
        public static MenuItemType CustomersClaims => new MenuItemType("Claims");
        public static MenuItemType CustomersManageYourPolicy => new MenuItemType("Manage Your Policy");
        public static MenuItemType CustomersMakePayment => new MenuItemType("Make a Payment");

        public static MenuItemType NotesAndNews => new MenuItemType("Notes and News");
    }
}
