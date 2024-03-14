using NUnit.Framework;
using SpecFlowAutomation.Base;
using SpecFlowAutomation.Pages;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowAutomation.Steps
{
    [Binding]
    public sealed class MainMenuSteps
    {
       private readonly ScenarioContext context;

        public MainMenuSteps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Given("I open official SpecFlow web site")]
        public void OpenOfficialSpecFlowWebSite()
        {
            HomePage.Instance.OpenSpecFlowHomePage();
        }

        [When("I hover the Docs menu item from the main menu while I click SpecFlow option from the main menu")]
        public void HoverTheMenuItemFromTheMainMenu()
        {
            Thread.Sleep(2000);
            HomePage.Instance.HoverMainMenuItem("Docs");
            HomePage.Instance.ClickSubMenuItem("SpecFlow");
        }
        
        [When(@"i enter Installation into the search field")]
        public void WhenIEnterInstallationIntoTheSearchField()
        {
            HomePage.Instance.SearchForItem("installation");
        }

        [Then("Page with Installation title should be opened")]
        public void PageWithTitleShouldBeOpened()
        {
            Assert.That(BasePage.Instance.GetPageTitle(), Does.Contain("Installation"));
        }

        [AfterScenario]
        public static void AfterTestRun()
        {
            DriverManager.QuitDriver();
        }

    }
}
