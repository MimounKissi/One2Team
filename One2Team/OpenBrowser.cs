namespace One2Team
{
    public class OpenBrowser : Abstract
    {
        // Open Website with specific url 
        public void OpenWebSite(string url)
        {
            driver.Url = url;
            driver.Manage().Window.Maximize();
        }
    }
}
