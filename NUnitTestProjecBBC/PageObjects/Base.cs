using System;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;




namespace NUnitTestProjecBBC.PageObjects
{
    class Base
    {

        public IWebDriver driver;
        public WebDriverWait wait;
        public string url = "https://www.bbc.com/";
             public Base(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }
    }

}