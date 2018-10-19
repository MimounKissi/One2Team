using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace One2Team
{
    public class Abstract
    {
        public static IWebDriver driver = new ChromeDriver();

        public static WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

        // VARIABLE
        public static string url = "https://chewie.one2team.com";
        public static string _userName = "candidat";
        public static string _passWord = "Candidat1*";
        public static string _domainName = "telco";
        public static string _cardName = "Test Card - Mimoun 15";
        public static int _elementColon = 0;
        public static int _targerColon = 5;
        public static string _path = @"C:\Users\MimounKISSI\Desktop\QA.png";

        // LOCATOR 
        public static By userName = By.Id("userName");
        public static By passWord = By.Id("passWord");
        public static By domainName = By.Id("domainName");
        public static By submit = By.CssSelector("input[type=\"submit\"]");
        public static By slideBoard = By.Id("img_slideboard");
        public static By chooseSlideBoard = By.LinkText("Choisir un slideboard");
        public static By chooseSlideBoardType = By.Id("select2-results-2");
        public static By detailCard = By.Id("cardName");
        public static By createCard = By.XPath("/html/body/div[1]/div/div/card-creation-popin-content-dumb/div[2]/div/button-with-status/div");
        public static By menuButton = By.CssSelector("a.menu-icon-button.o2t-tooltip.tooltip-on-bottom");
        public static By colon = By.CssSelector(".containCol__col__card__data.ng-scope");
        public static By cardText = By.CssSelector(".card__text__down");
        public static By addDoc = By.CssSelector("a.file-add-symbol");
        public static By numberOfDoc = By.CssSelector("a.o2t-tooltip.new-file");
        public static By iframe = By.XPath("//iframe[contains(@src,'slideboard-newlook/index.html?locale=fr_FR')]");

        // CREATE CLASS
        public static OpenBrowser open = new OpenBrowser();
        public static Connection connection = new Connection();
        public static ManageMenu manageMenu = new ManageMenu();
        public static ManageCard manageCard = new ManageCard(); 
    }
}
