using OpenQA.Selenium;

namespace Ui.Tests.CorporateWebsite.PageObjectModels
{
    public class WhoWeArePage : BasePage
    {
        public WhoWeArePage(IWebDriver driver) : base(driver)
        {
            PageUrl = "https://velocityrisk.com/meet-our-team/";
        }

        public IWebElement MeetOurLeadershipTeamElement => Driver.FindElement(By.ClassName("filter_inner_part"));

        public IWebElement GetImageCardByName(string name) => Driver.FindElement(By.XPath($"//div[@class='overlay_content']/p[contains(text(), '{name}')]/parent::div"));

        public bool IsTeamMemberImageDisplayedByName(string name)
        {
            var imageCardDivElement = GetImageCardByName(name);
            var imageElement = imageCardDivElement.FindElement(By.XPath("//ancestor::a/img"));
           
            return imageElement.Displayed;
        }

        public string GetJobTitleByName(string name)
        {
            var imageCardDivElement = GetImageCardByName(name);
            var jobElement = imageCardDivElement.FindElements(By.ClassName("filter_image_state"));
            return jobElement[0].Text;
        }

        public bool IsJobTitleDisplayedByName(string name)
        {
            var imageCardDivElement = GetImageCardByName(name);
            var jobElement = imageCardDivElement.FindElements(By.ClassName("filter_image_state"));
            
            return jobElement[0].Displayed;
        }

        public string GetLocationByName(string name)
        {
            var imageCardDivElement = GetImageCardByName(name);
            var locationElement = imageCardDivElement.FindElements(By.ClassName("filter_image_state"));
            return locationElement[1].Text;
        }

        public bool IsLocationDisplayedByName(string name)
        {
            var imageCardDivElement = GetImageCardByName(name);
            var locationElement = imageCardDivElement.FindElements(By.ClassName("filter_image_state"));
            return locationElement[1].Displayed;
        }
    }
}
