using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V113.Browser;

namespace finacle
{
    public class Finacle
    {
        public WebDriver browser;

        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-Maximize");
            browser = new ChromeDriver(options);
            browser.Navigate().GoToUrl(Link.homepage);

            
        }


        [TearDown]
        public void Teardown1()
        {
            browser.Quit();
        }
       
    }
}