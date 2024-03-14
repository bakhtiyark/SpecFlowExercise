namespace SpecFlowAutomation.Pages
{
    public class GettingStartedPage : BasePage
    {      

        private static GettingStartedPage gettingStartedPage;
        public static GettingStartedPage Instance => gettingStartedPage ?? (gettingStartedPage = new GettingStartedPage());

    }
}
