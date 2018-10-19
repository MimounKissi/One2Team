using OpenQA.Selenium.Support.UI;

namespace One2Team
{
    public class ManageMenu : Abstract
    {
        // Choose menu 
        public void ChooseMenuType()
        {
            wait.Until(ExpectedConditions.ElementExists(slideBoard));
            driver.FindElement(slideBoard).Click();
        }

        // Select the menu SlideBoard 
        public void ChooseSlideBoard()
        {
            wait.Until(ExpectedConditions.ElementExists(chooseSlideBoard));
            driver.FindElement(chooseSlideBoard).Click();
        }

        // Select name of slideBoard
        public void ChooseSlideBoardType()
        {
            wait.Until(ExpectedConditions.ElementExists(chooseSlideBoardType));
            driver.FindElement(chooseSlideBoardType).Click();
        }

    }
}
