using NUnit.Framework;
using OpenQA.Selenium;

namespace One2Team
{
    
    public class One2Team : Abstract
    {
        [Test]
        public void TestCandidat() 
        {
            // Open Website
            open.OpenWebSite(url);

            // Connection 
            connection.SetUserName(_userName);
            connection.SetPassWord(_passWord);
            connection.Submit();

            // Choose Slideboard
            manageMenu.ChooseMenuType();                 
            driver.SwitchTo().Frame(driver.FindElement(iframe)); // Switch to select the element in the frame
            manageMenu.ChooseSlideBoard();
            manageMenu.ChooseSlideBoardType();

            // Manage Card
            // Create Card
            manageCard.CreateCard(_cardName);
            
            // Card Creation Verification
            Assert.IsTrue(manageCard.IsCardExist(_cardName));

            // Drag and Drop Card & Opening Card
            manageCard.DragAndDropCard(_cardName, _elementColon, _targerColon);
            
            // Upload document 
            manageCard.SelectUpload();
            manageCard.UploadDocument(_path);

            // Upload Verification 
            Assert.IsTrue(manageCard.IsUploadOk());

            // Close Card
            driver.FindElement(By.CssSelector("span.icon.icon-cross.icon-close-popin")).Click();

            driver.Close(); 

        }
    }
}
