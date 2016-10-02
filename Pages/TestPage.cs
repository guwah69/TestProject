using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValTechProject.Base;

namespace ValTechTest.Pages
{
    class TestPage : BasePage 

    {
        //Initialize page
        public TestPage(IWebDriver driver): base(driver)
        {
            PageFactory.InitElements(driver, this);
        }
        
        //Objects for TestPage
        [FindsBy(How = How.CssSelector, Using = "div.hamburger__front > i.icons.glyph")]
        public IWebElement hamburgerMenu { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Cases')]")]
        public IWebElement lnkCases { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Services')]")]
        public IWebElement lnkServices { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Jobs')]")]
        public IWebElement lnkJobs { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='contacticon']/div/div/div[1]/i")]
        public IWebElement contactIcon { get; set; }

        public void Test()
        {
            hamburgerMenu.Click();


            lnkCases.Click();
            lnkServices.Click();
            lnkJobs.Click();
            contactIcon.Click();
        
        
        }

        
    }
}
