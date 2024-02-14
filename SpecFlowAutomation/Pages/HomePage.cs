using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SpecFlowAutomation.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpecFlowAutomation.Pages
{
    public class HomePage : BasePage
    {
        private string URL => "https://specflow.org";
        
        private static HomePage homePage;
        public static HomePage Instance => homePage ?? (homePage = new HomePage());

        private IWebElement searchFormInput;
        private IWebElement searchFormField;
        public void OpenSpecFlowHomePage()
        {
            DriverManager.Instance().Navigate().GoToUrl(URL);
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
            searchFormInput = FindElement(By.Name("q"));
            searchFormInput.Click();
            searchFormField = FindElement(By.CssSelector("input[placeholder=\"Search ...\"]"));
            searchFormField.SendKeys(item);
            Thread.Sleep(2000);
            var searchResult = FindElement(By.Id("hit__1"));
            searchResult.Click();
        }

    }
}
