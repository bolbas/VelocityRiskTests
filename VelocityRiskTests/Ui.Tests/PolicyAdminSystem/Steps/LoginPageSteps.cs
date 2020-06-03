using OpenQA.Selenium;
using Ui.Tests.PolicyAdminSystem.PageObjectModels;

namespace Ui.Tests.PolicyAdminSystem.Steps
{
    public class LoginPageSteps : PolicyAdminSystemBaseSteps<LoginPage>
    {
        public LoginPageSteps(IWebDriver driver) : base(driver)
        {
            Page = new LoginPage(Driver);
        }

        public void SetUsernameInputValue(string value) => SetTextBoxValue(Page.UserNameTextBox, value);
        public string GetUsernameInputValue() => GetTextBoxValue(Page.UserNameTextBox);

        public void SetPasswordInputValue(string value) => SetTextBoxValue(Page.PasswordTextBox, value);
        public string GetPasswordInputValue() => GetTextBoxValue(Page.PasswordTextBox);

        public void ClickCantRememberLink() => Click(Page.CantRememberLink);
        public void ClickCantRememberCloseModalWindowButton() => Click(Page.CantRememberModalWindowCloseButton);
        public void SetCantRememberEmailInputValue(string value) => SetTextBoxValue(Page.CantRememberEmailTextBox, value);
        public string GetCantRememberEmailInputValue() => GetTextBoxValue(Page.CantRememberEmailTextBox);
        public void ClickCantRememberOkButton() => Click(Page.CantRememberCancelButton);

        public void ClickLogInButton() => Click(Page.LoginButton);
    }
}