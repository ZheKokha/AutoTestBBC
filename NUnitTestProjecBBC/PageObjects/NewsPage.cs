using SeleniumExtras.PageObjects;
using OpenQA.Selenium;


namespace NUnitTestProjecBBC.PageObjects
{
    
    class NewsPage : Base
    {
        
        public NewsPage(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.XPath, Using = "//div[@data-entityid='container-top-stories#1']/div[1]//h3")]
        public IWebElement nameHeadlineArticle;


        [FindsBy(How = How.XPath, Using = "//div[@data-entityid='container-top-stories#2']//h3")]
        public IWebElement expectedFirstName;


        [FindsBy(How = How.XPath, Using = "//div[@data-entityid='container-top-stories#3']//h3")]
        public IWebElement expectedSecondName;


        [FindsBy(How = How.XPath, Using = "//div[@data-entityid='container-top-stories#4']//h3")]
        public IWebElement expectedThirdName;


        [FindsBy(How = How.XPath, Using = "//div[@data-entityid='container-top-stories#5']//h3")]
        public IWebElement expectedFourthName;

        [FindsBy(How = How.XPath, Using = "//div[@data-entityid='container-top-stories#6']//h3")]
        public IWebElement expectedFifthName;

        [FindsBy(How = How.XPath, Using = "//button[contains(@type, 'button')]/descendant::span[text()='More']")]
        public IWebElement More;

        [FindsBy(How = How.XPath, Using = "//header/div[2]//div[2]//div/ul[4]/li/a/span")]
        public IWebElement Say;

        [FindsBy(How = How.XPath, Using = "//div[@data-entityid='container-top-stories#1']/div[1]/ul/li[2]/a/span")]
        private IWebElement ActualName;

        [FindsBy(How = How.XPath, Using = "//*[@id='orb-search-q']")]
        private IWebElement Search;

        [FindsBy(How = How.XPath, Using = "//*[@id='orb-search-button']")]
        private IWebElement SearchButton;

        [FindsBy(How = How.XPath, Using = "//section[@id='search-content']/ol[1]/li[1]/article/div/h1/a")]
        private IWebElement FirstArticle;

        public string GetActualName()
        {
            string actualArticleName = ActualName.Text;
            return actualArticleName;
        }
        public void PushSearch()
        {
            string actualArticleName = GetActualName();
            Search.SendKeys(actualArticleName);
        }

        public void SearchButtonClick()
        {
            SearchButton.Click();
        }
        public string ToText()
        {
            return nameHeadlineArticle.Text;
        }
        public string GetFirstName()
        {
            string expectedArticleName = FirstArticle.Text;
            return expectedArticleName;
        }

        public string ToText1()
        {
            return expectedFirstName.Text;

        }

        public string ToText2()
        {
            return expectedSecondName.Text;

        }

        public string ToText3()
        {
            return expectedThirdName.Text;

        }

        public string ToText4()
        {
            return expectedFourthName.Text;

        }

        public string ToText5()
        {
            return expectedFifthName.Text;

        }
        public Test MoreClick()
        {
            More.Click();
            return new Test(driver);
        }


        public HaveYourSayPage HaveYourSayClick()
        {

            Say.Click();
            return new HaveYourSayPage(driver);
        }
    }
}
