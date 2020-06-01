using NUnit.Framework;
using Ui.Tests.CorporateWebsite.Steps;

namespace Ui.Tests
{
    public class PolicyAdminSystemTests : BaseTest
    {
        private HomePageSteps _homePageSteps;

        [OneTimeSetUp]
        public void Initialize()
        {
            _homePageSteps = new HomePageSteps(Driver);
        }

        [SetUp]
        public void BeforEachTest()
        {
            _homePageSteps.NavigateTo();
        }

        [TearDown]
        public void AfterEachTest()
        {
            _homePageSteps.CloseAllTabsExceptFirst();
        }

        [Test]
        public void TestCase_01_First()
        {
             
        }
    }
}