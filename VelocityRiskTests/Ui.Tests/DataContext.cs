using System.Collections.Generic;
using Ui.Tests.CorporateWebsite.PersistenceModels;
using Ui.Tests.CorporateWebsite.Steps.TestData.Customers;

namespace Ui.Tests
{
    public class DataContext
    {
        public static List<MenuItem> LoadMenuItems()
        {
            return
                new List<MenuItem>
                {
                    new MenuItem {Id = 1, Name = ClaimsTestData.MenuAgents, Link = ClaimsTestData.MenuAgentsLink, opensNewTab = false},
                    new MenuItem {Id = 2, Name = ClaimsTestData.MenuHomeowners, Link = ClaimsTestData.MenuHomeownersLink, opensNewTab = false},
                    new MenuItem {Id = 3, Name = ClaimsTestData.MenuLargeCommercial, Link = ClaimsTestData.MenuLargeCommercialLink, opensNewTab = false},
                    new MenuItem {Id = 4, Name = ClaimsTestData.MenuSmallCommercial, Link = ClaimsTestData.MenuSmallCommercialLink, opensNewTab = false},
                    new MenuItem {Id = 5, Name = ClaimsTestData.MenuClaims, Link = ClaimsTestData.MenuClaimsLink, opensNewTab = false},
                    new MenuItem {Id = 6, Name = ClaimsTestData.MenuManageYourPolicy, Link = ClaimsTestData.MenuManageYourPolicyLink, opensNewTab = true},
                    new MenuItem {Id = 7, Name = ClaimsTestData.MenuMakePayment, Link = ClaimsTestData.MenuMakePaymentLink, opensNewTab = true},
                    new MenuItem {Id = 8, Name = ClaimsTestData.MenuNotesAndNews, Link = ClaimsTestData.MenuNotesAndNewsLink, opensNewTab = false}
                };
        }

        public static List<PanelItem> LoadPanelItems()
        {
            return
                new List<PanelItem>
                {
                    new PanelItem {Id = 1, Title = ClaimsTestData.FileClaimTitle, Content = ClaimsTestData.FileClaimContent},
                    new PanelItem {Id = 2, Title = ClaimsTestData.QuestionsExistingTitle, Content = ClaimsTestData.QuestionsExistingContent},
                    new PanelItem {Id = 3, Title = ClaimsTestData.ClaimsProcessTitle, Content = ClaimsTestData.ClaimsProcessContent},
                    new PanelItem {Id = 4, Title = ClaimsTestData.GeneralFaqsTitle, Content = ClaimsTestData.GeneralFaqsContent},
                    new PanelItem {Id = 5, Title = ClaimsTestData.PropertyClaimFaqsTitle, Content = ClaimsTestData.PropertyClaimFaqsContent},
                    new PanelItem {Id = 6, Title = ClaimsTestData.AdditionalResourcesTitle, Content = ClaimsTestData.AdditionalResourcesContent}
                };
        }

        public static List<ImageCard> LoadImageCards()
        {
            return
                new List<ImageCard>
                {
                    new ImageCard {Id = 1, TeamMemberName = "Phil Bowie", JobTitle = "CEO", Location = "Nashville, TN"},
                    new ImageCard {Id = 2, TeamMemberName = "Rod Harden", JobTitle = "Chief Claims Officer", Location = "Nashville, TN"},
                    new ImageCard {Id = 3, TeamMemberName = "Jake Rothfuss", JobTitle = "Chief Operating Officer", Location = "Nashville, TN"},
                    new ImageCard {Id = 4, TeamMemberName = "Kristi Jeffers", JobTitle = "Chief Administrative Officer", Location = "Birmingham, AL"},
                    new ImageCard {Id = 5, TeamMemberName = "Carolyn Parker", JobTitle = "Chief Underwriting Officer, Commercial Lines", Location = "Birmingham, AL"},
                    new ImageCard {Id = 6, TeamMemberName = "Praveen Reddy", JobTitle = "Chief of Operations", Location = "Nashville, TN"},
                };
        }
    }
}
