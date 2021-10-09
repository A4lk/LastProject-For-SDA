using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TestProject1
{
    public class Tests
    
    {
        IWebDriver Driver = new FirefoxDriver();
       

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://localhost:5001/");
            //Driver.FindElements(By.XPath(@"/html/body/main/section[1]/div/div/div[2]/div/figure/div/button"));
           //Assert.Pass();
        }
    }
}