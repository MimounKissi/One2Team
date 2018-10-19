using OpenQA.Selenium.Support.UI;

namespace One2Team
{
    public class Connection : Abstract
    {
        // Set Username
        public void SetUserName(string _userName)
        {
            wait.Until(ExpectedConditions.ElementExists(userName));
            driver.FindElement(userName).SendKeys(_userName);
        }

        // Set PassWord
        public void SetPassWord(string _passWord)
        {
            wait.Until(ExpectedConditions.ElementExists(passWord));
            driver.FindElement(passWord).SendKeys(_passWord);
        }

        // Set domain name
        public void SetdomainName(string _domainName)
        {
            wait.Until(ExpectedConditions.ElementExists(domainName));
            driver.FindElement(domainName).Clear();
            driver.FindElement(domainName).SendKeys(_domainName);
        }

        // Submit the connection 
        public void Submit()
        {
            driver.FindElement(submit).Click();
        }
        

    }
}
