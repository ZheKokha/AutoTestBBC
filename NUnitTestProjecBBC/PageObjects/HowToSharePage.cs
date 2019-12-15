using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace NUnitTestProjecBBC.PageObjects
{
    class HowToSharePage : Base
    {
        public HowToSharePage(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='fullName']")]
        private IWebElement FullName;

        [FindsBy(How = How.XPath, Using = "//*[@id='email']")]
        private IWebElement Email;

        [FindsBy(How = How.XPath, Using = "//*[@id='town']")]
        private IWebElement Town;

        [FindsBy(How = How.XPath, Using = "//*[@id='phone']")]
        private IWebElement Phone;

        [FindsBy(How = How.XPath, Using = "//*[@id='message']")]
        private IWebElement Comments;

        [FindsBy(How = How.XPath, Using = "//input[@id='submit']")]
        private IWebElement Send;
                              
        public void PushName(string name)
        {
            FullName.SendKeys(name);
        }

        public void PushEmail(string email)
        {
            Email.SendKeys(email);
        }

        public void PushTown(string town)
        {
            Town.SendKeys(town);
        }

        public void PushPhone(string phone)
        {
            Phone.SendKeys(phone);
        }
        public void PushComments(string comment)
        {
            for (int i = 0; i < 100; i++)
            {
                Comments.SendKeys(comment);
            }

        }
        public void PushComments1(string comment)
        {
            for (int i = 0; i < 200; i++)
            {
                Comments.SendKeys(comment);
            }
            
        }

        public void SendClick()
        {
            Send.Click();
        }

        public string GetUrl()
        {
            return driver.Url; 
        }

    }
}
