using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace NUnitTestProjecBBC.PageObjects
{
    class Test:Base
    {
        public Test(IWebDriver driver) : base(driver)
        {

        }

        [FindsBy(How = How.XPath, Using = "//header/div[2]//div[2]//div/ul[4]/li/a/span")]
        private IWebElement Say;

        public void Navigate()
        {
            this.driver.Navigate().GoToUrl(this.url);
        }


        public HaveYourSayPage HaveYourSayClick()
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(Say);
            actions.Perform();
            Say.Click();
            return new HaveYourSayPage(driver);
        }

    }
}
