using AutoItX3Lib;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Linq;
using System.Threading;

namespace One2Team
{
    public class ManageCard : Abstract
    {
        // creation card with specific cardName 
        public void CreateCard(string _cardName)
        {
            wait.Until(ExpectedConditions.ElementExists(By.CssSelector("div.containCol__col__card")));
            driver.FindElement(By.CssSelector(".containCol__col__plus__center__icon")).Click();

            wait.Until(ExpectedConditions.ElementExists(detailCard));
            driver.FindElement(detailCard).SendKeys(_cardName);

            wait.Until(ExpectedConditions.ElementExists(createCard));
            driver.FindElement(createCard).Click();
        }

        // verification card is created 
        public bool IsCardExist(string _cardName)
        {

            // Tempo - create finish
            Thread.Sleep(3000);

            var container = driver.FindElements(colon).ElementAt(0);

            try { container.FindElements(cardText).First(e => e.Text == _cardName); }
            catch (NoSuchElementException) { return false; }
            catch (StaleElementReferenceException) { return false; }
            return true;
        }

        // Drag and Drop 
        public void DragAndDropCard(string _cardName, int _elementColon, int _targetColon)
        {
            var container = driver.FindElements(colon).ElementAt(_elementColon);
            var node = container.FindElements(cardText).First(e => e.Text == _cardName);
            var parent = node.FindElement(By.XPath("../.."));
            
            Actions ac = new Actions(driver);
            ac.DragAndDrop(parent, driver.FindElements(colon).ElementAt(_targetColon));
            ac.Build().Perform();
            Thread.Sleep(5000);

            container = driver.FindElements(colon).ElementAt(_targetColon);
            node = container.FindElements(cardText).First(e => e.Text == _cardName);
            parent = node.FindElement(By.XPath("../.."));

            parent.Click();   
        }
        
        // action upload 
        public void SelectUpload()
        {
            wait.Until(ExpectedConditions.ElementExists(addDoc));
            driver.FindElement(addDoc).Click();
        }

        // upload a specific document with the path of the document 
        public void UploadDocument(string _path)
        {
            AutoItX3 autoIt = new AutoItX3();
            autoIt.WinActivate("Ouvrir");
            Thread.Sleep(1000);  // tempo to have the time to write the path 
            autoIt.Send(_path);
            autoIt.Send("{ENTER}");
        }

        // verification is upload - verify if the counter of the card pass to 1 
        public bool IsUploadOk()
        {
            string _number = ""; 

            wait.Until(ExpectedConditions.ElementExists(numberOfDoc));
            _number = driver.FindElement(numberOfDoc).Text;

            return (_number == "0") ? false : true; 
        }

    }
}
