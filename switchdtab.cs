using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V113.Browser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finacle
{
    public class switchdtab : Finacle
    {
        [Test]    

        public void Test() 
        {
            browser.FindElement(By.Id("tabButton")).Click();
            browser.SwitchTo().Window(browser.WindowHandles[1]);
            Console.WriteLine(browser.FindElement(By.Id("sampleHeading")).Text);
            browser.SwitchTo().Window(browser.WindowHandles[0]);
            //browser.FindElement(By.Id("windowButton")).Click();



        }
    }
}
