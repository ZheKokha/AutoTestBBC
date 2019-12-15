
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;




namespace NUnitTestProjecBBC.PageObjects
{
    class HomePage : Base
    {
       
        public HomePage(IWebDriver driver) : base(driver)
        {

        }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'News')]")]
        private IWebElement News;

        public void Navigate()
        {
            this.driver.Navigate().GoToUrl(this.url);
        }

              
        public NewsPage NewsClick()
        {
            News.Click();
            return new NewsPage(driver);
        }

    }
}
