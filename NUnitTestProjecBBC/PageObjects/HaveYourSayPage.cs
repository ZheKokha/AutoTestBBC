using OpenQA.Selenium;
using SeleniumExtras.PageObjects;



namespace NUnitTestProjecBBC.PageObjects
{
    class HaveYourSayPage : Base
    {
        public HaveYourSayPage(IWebDriver driver) : base(driver)
        {
            
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='orb-modules']/header/div[2]/div/div[2]/div/div/ul[4]/li/a/span")]
        private IWebElement Say;

        [FindsBy(How = How.XPath, Using = "//div[2]/div[2]/div[2]//div[2]/div/a")]
        private IWebElement HowToShare;

           

        public HowToSharePage HowToShareClick()
        {
            HowToShare.Click();
            return new HowToSharePage(driver);
        }
    }
}
