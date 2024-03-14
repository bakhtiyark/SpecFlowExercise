namespace SpecFlowAutomation.Pages
{
    public class GettingStartedPage : BasePage
    {
        private static GettingStartedPage _gettingStartedPage;

        public new static GettingStartedPage Instance =>
            _gettingStartedPage ?? (_gettingStartedPage = new GettingStartedPage());
    }
}