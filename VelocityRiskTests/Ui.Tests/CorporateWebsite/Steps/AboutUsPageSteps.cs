using OpenQA.Selenium;
using Shouldly;
using Ui.Tests.CorporateWebsite.PageObjectModels;

namespace Ui.Tests.CorporateWebsite.Steps
{
    public class AboutUsPageSteps : CorporateWebsiteBaseSteps<WhoWeArePage>
    {
        public AboutUsPageSteps(IWebDriver driver) : base(driver)
        {
            Page = new WhoWeArePage(Driver);
        }

        public void NavigateToPage()
        {
            NavigateTo();
            var homePage = new HomePage(Driver);
            homePage.AboutUsMenuItem.Click();
            homePage.WhoWeAreMenuItem.Click();
        }

        public void NavigateToLeadershipTeamView()
        {
            MouseHoverToElement(Page.MeetOurLeadershipTeamElement);
        }

        public void VerifyIsTeamMemberExists(string name)
        {
            var imageCardElement = Page.GetImageCardByName(name);
            imageCardElement.ShouldNotBeNull($"There is no {name} on UI.");
        }

        public void VerifyIsTeamMemberImageDisplayed(string name)
        {
            Page.IsTeamMemberImageDisplayedByName(name).ShouldBeTrue($"There element with name {name} is not displayed on UI.");
        }

        public void VerifyIsTeamMemberNameDisplayed(string name)
        {
            var imageCardElement = Page.GetImageCardByName(name);
            imageCardElement.Displayed.ShouldBeTrue($"There element with name {name} is not displayed on UI.");
        }

        public void ClickOnNameCard(string name)
        {
            var imageCardElement = Page.GetImageCardByName(name);
            imageCardElement.Click();
        }

        public void VerifyTeamMemberJobTitle(string name, string expectedJobTitle)
        {            
            Page.IsJobTitleDisplayedByName(name).ShouldBeTrue($"The job title element for {name} is not displayed on UI.");
            var jobTitle = Page.GetJobTitleByName(name);
            jobTitle.ShouldBe(expectedJobTitle.ToUpper(), $"There is no job title: {expectedJobTitle} for name: {name} on UI.");
        }

        public void VerifyTeamMemberLocation(string name, string expectedLocation)
        {
            Page.IsLocationDisplayedByName(name).ShouldBeTrue($"The location element for {name} is not displayed on UI.");
            var locationTitle = Page.GetLocationByName(name);
            locationTitle.ShouldBe(expectedLocation.ToUpper(), $"There is no location: {expectedLocation} for name: {name} on UI.");
        }
    }
}
