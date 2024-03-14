using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Linq;
using SpecFlowAutomation.Base;


namespace SpecFlowAutomation.Pages
{
    public class HomePage : BasePage
    {
        private string Url => "https://specflow.org";

        private static HomePage _homePage;
        public new static HomePage Instance => _homePage ?? (_homePage = new HomePage());

        private IWebElement _searchFormInput;
        private IWebElement _searchFormField;

        public void OpenSpecFlowHomePage()
        {
            DriverManager.Instance().Navigate().GoToUrl(Url);
        }

        public void HoverMainMenuItem(string item)
        {
            var actions = new Actions(DriverManager.Instance());
            var menuItem = FindElements(By.Id("menu-item-1357")).First(x => x.Text.Equals(item));
            actions.MoveToElement(menuItem).Perform();
        }

        public void ClickSubMenuItem(string item)
        {
            var subMenuItem = FindElements(By.Id("menu-item-1067")).First(x => x.Text.Equals(item));
            subMenuItem.Click();
        }

        public void SearchForItem(string item)
        {
            _searchFormInput = FindElement(By.Name("q"));
            _searchFormInput.Click();
            _searchFormField = FindElement(By.CssSelector("input[placeholder=\"Search ...\"]"));
            _searchFormField.SendKeys(item);
            if (!IsDisplayed(By.Id("hit__1"))) return;
            var searchResult = FindElement(By.Id("hit__1"));
            searchResult.Click();
        }
    }
}