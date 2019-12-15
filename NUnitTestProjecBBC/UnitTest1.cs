using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnitTestProjecBBC.PageObjects;

namespace NunitBBC
{ public class Tests
    {
        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

    
        [Test]
        public void CheckHeadArticle()
        {
            HomePage home = new HomePage(driver);
            home.Navigate();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            NewsPage news = home.NewsClick();
            string actualNameHeadlineArticle = news.ToText();
            string expectedNameHeadlineArticle = "Eruption on New Zealand volcano kills at least five";
            Assert.AreEqual(actualNameHeadlineArticle, expectedNameHeadlineArticle);
            driver.Quit();
            }

        [Test]
        public void checkAllArticles()
        {
            HomePage home = new HomePage(driver);
            home.Navigate();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            NewsPage news = home.NewsClick();
            List<String> expectedNames = new List<String>();
            expectedNames.Add(news.ToText1());
            expectedNames.Add(news.ToText2());
            expectedNames.Add(news.ToText3());
            expectedNames.Add(news.ToText4());
            expectedNames.Add(news.ToText5());
            List<String> actualNames = new List<string>();
            actualNames.Add("Finnish minister, 34, to be world's youngest PM");
            actualNames.Add("Negotiators 'playing politics' amid climate crisis");
            actualNames.Add("Florida navy attack is presumed terrorism - FBI");
            actualNames.Add("Saudi Arabia ends restaurant segregation");
            actualNames.Add("Artist eats $120,000 banana artwork");
            Assert.AreEqual(expectedNames, actualNames);
                        driver.Quit();
        }

        [Test]
        public void checkTheNameOfFirstArtiticle()
        {
            HomePage home = new HomePage(driver);
            home.Navigate();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            NewsPage news = home.NewsClick();
            string actualArticleName = news.GetActualName();
            news.PushSearch();
            news.SearchButtonClick();
            string expectedArticleName = news.GetFirstName();
            Assert.AreEqual(expectedArticleName, actualArticleName);
            driver.Quit();
        }
        [Test]
        public void storyToBbc()
        {
            HomePage home = new HomePage(driver);
            home.Navigate();
            NewsPage news = home.NewsClick();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Test test = news.MoreClick();
            HaveYourSayPage say = test.HaveYourSayClick();
            HowToSharePage share = say.HowToShareClick();

            string name = "Vasia Pupkin";
            string email = "vasiapupkin@gmail.com";
            string town_country = "Kyiv,Ukraine";
            string phone = "0961112288";
            string text = "a";
            share.PushName(name);
            share.PushEmail(email);
            share.PushTown(town_country);
            share.PushPhone(phone);
            share.PushComments(text);
            string currentUrl = share.GetUrl();
            string actualUrl = "https://www.bbc.com/news/10725415";
            Assert.AreEqual(actualUrl, currentUrl);

            driver.Quit();
        }
        [Test]
        public void storyToBbc_1()
        {
            HomePage home = new HomePage(driver);
            home.Navigate();
            NewsPage news = home.NewsClick();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Test test = news.MoreClick();
            HaveYourSayPage say = test.HaveYourSayClick();
            HowToSharePage share = say.HowToShareClick();

            string name = "Vasia Pupkin";
            string email = "vasiapupkin@gmail.com";
            string town_country = "Kyiv,Ukraine";
            string phone = "0961112288";
            string text = "a";
            share.PushName(name);
            share.PushEmail(email);
            share.PushTown(town_country);
            share.PushPhone(phone);
            share.PushComments1(text);
            string currentUrl = share.GetUrl();
            string actualUrl = "https://www.bbc.com/news/10725415";
            Assert.AreEqual(actualUrl, currentUrl);

            driver.Quit();
        }
        [Test]
        public void storyToBbc_2()
        {
            HomePage home = new HomePage(driver);
            home.Navigate();
            NewsPage news = home.NewsClick();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Test test = news.MoreClick();
            HaveYourSayPage say = test.HaveYourSayClick();
            HowToSharePage share = say.HowToShareClick();

            string name = "Vasia Pupkin";
            string town_country = "Kyiv,Ukraine";
            string phone = "0961112288";
            string text = "a";
            share.PushName(name);
            share.PushTown(town_country);
            share.PushPhone(phone);
            share.PushComments(text);
            string currentUrl = share.GetUrl();
            string actualUrl = "https://www.bbc.com/news/10725415";
            Assert.AreEqual(actualUrl, currentUrl);

            driver.Quit();
        }
        [Test]
        public void storyToBbc_3()
        {
            HomePage home = new HomePage(driver);
            home.Navigate();
            NewsPage news = home.NewsClick();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Test test = news.MoreClick();
            HaveYourSayPage say = test.HaveYourSayClick();
            HowToSharePage share = say.HowToShareClick();

            string name = "Vasia Pupkin";
            string email = "vasiapupkin@gmail.com";
            string town_country = "Kyiv,Ukraine";
            string phone = "0961112288";
            share.PushName(name);
            share.PushEmail(email);
            share.PushTown(town_country);
            share.PushPhone(phone);
            string currentUrl = share.GetUrl();
            string actualUrl = "https://www.bbc.com/news/10725415";
            Assert.AreEqual(actualUrl, currentUrl);

            driver.Quit();
        }

     
       

    }
}