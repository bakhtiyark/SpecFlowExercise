using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecFlowAutomation.Base;
using System;
using System.Collections.ObjectModel;

namespace SpecFlowAutomation.Pages
{
    public class BasePage
    {
        private string TitleXPath => "//h1";

        protected BasePage()
        {

        }

        private static BasePage basePage;
        public static BasePage Instance => basePage ?? (basePage = new BasePage());

        public IWebElement FindElement(By locator)
        {
            return DriverManager.Instance().FindElement(locator);
        }

        public ReadOnlyCollection<IWebElement> FindElements(By locator)
        {
            return DriverManager.Instance().FindElements(locator);
        }

        public bool IsDisplayed(By locator, int timeout = 30)
        {
            var wait = new WebDriverWait(DriverManager.Instance(), TimeSpan.FromSeconds(timeout));
            return wait.Until(d => DriverManager.Instance().FindElement(locator).Displayed);
        }

        public string GetPageTitle()
        {
            return DriverManager.Instance().FindElement(By.XPath(TitleXPath)).Text;
        }
    }
}
