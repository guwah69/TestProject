using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using ValTechTest.Pages;
using OpenQA.Selenium.Interactions;
using ValTechProject.Base;


namespace ValTechTest
{

    [TestClass]
    public class HomePageTest1
    {

        string url = "https://www.valtech.com/";
        private IWebDriver _driver;


        [TestMethod]
        public void TestMethod1()
        {

            _driver = new FirefoxDriver();
            _driver.Navigate().GoToUrl(url);
            _driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));


            TestPage page = new TestPage(_driver);

            //Test1
            var element = _driver.FindElement(By.XPath(".//*[@id='container']/div[2]/div[3]/div[1]/header/h2"));
            Actions actions = new Actions(_driver);
            actions.MoveToElement(element);
            actions.Perform();
           Assert.AreEqual("IBC Preview: Valtech’s new Over-The-Top approaches", _driver.FindElement(By.XPath("//a[contains(text(),'IBC Preview:  Valtech’s new Over-The-Top approaches')]")).Text);
            

            //Test2
            page.hamburgerMenu.Click();
            page.lnkCases.Click();
            Assert.AreEqual("Cases", _driver.FindElement(By.CssSelector("h1")).Text);

          
            page.hamburgerMenu.Click();
            page.lnkServices.Click();
            Assert.AreEqual("Services", _driver.FindElement(By.CssSelector("h1")).Text);


            page.hamburgerMenu.Click();
            page.lnkJobs.Click();
            Assert.AreEqual("Jobs", _driver.FindElement(By.CssSelector("h1")).Text);


            //Test3
            /**

       //Using Regex to Retrieve LinkText fron Contact Page

       public static List<string> Extract(string html)
       {
           List<string> list = new List<string>();

           Regex regex = new Regex("(?:href|src)=[\"|']?(.*?)[\"|'|>]+", RegexOptions.Singleline | RegexOptions.CultureInvariant);
           if (regex.IsMatch(html))
           {
               foreach (Match match in regex.Matches(html))
               {
                   list.Add(match.Groups[1].Value);
                   {
                       Console.WriteLine(list.Count);
                   }

               }
           }

           return list;
       }
   }

}


**/
            _driver.FindElement(By.XPath(".//*[@id='contacticon']/div/div/div[1]/i")).Click();

            List<string> office = new List<string>();
            IWebElement body = _driver.FindElement(By.LinkText("Buenos Aires City"));
            //Assert.IsTrue(body.Text.Contains("Buenos Aires City "));
            office.Add("Buenos Aires City Office is Present");

            IWebElement body1 = _driver.FindElement(By.LinkText("Buenos Aires"));
            Assert.IsTrue(body.Text.Contains("Buenos Aires"));
            office.Add("Buenos Aires Office is Present");

            IWebElement body2 = _driver.FindElement(By.LinkText("Sydney"));
            office.Add("Sydney Office is Present");

            IWebElement canada =  _driver.FindElement(By.LinkText("Montreal"));
            office.Add("Montreal Office is Present");

            IWebElement Copenhagen = _driver.FindElement(By.LinkText("Copenhagen"));
            office.Add("Copenhagen Office is Present");

            IWebElement Aarhus = _driver.FindElement(By.LinkText("Aarhus"));
            office.Add("Aarhus Office is Present");

            IWebElement Paris = _driver.FindElement(By.LinkText("Paris"));
            office.Add("Paris Office is Present");

            IWebElement Düsseldorf =_driver.FindElement(By.LinkText("Düsseldorf"));
            office.Add("Düsseldorf Office is Present");

            IWebElement Frankfurt = _driver.FindElement(By.LinkText("Frankfurt"));
            office.Add("Frankfurt Office is Present");

            IWebElement Munich = _driver.FindElement(By.LinkText("Munich"));
            office.Add("Munich Office is Present");

            IWebElement Bangalore = _driver.FindElement(By.LinkText("Bengaluru"));
            office.Add("Bangalore Office is Present");

            IWebElement Gurgaon = _driver.FindElement(By.LinkText("Gurugram"));
            office.Add("Gurgaon Office is Present");

            IWebElement Luxembourg = _driver.FindElement(By.LinkText("Luxembourg (HQ)"));
            office.Add("Luxembourg (HQ) Office is Present");

            IWebElement Amersfoort = _driver.FindElement(By.LinkText("Amersfoort"));
            office.Add("Amersfoort Office is Present");

            IWebElement Amsterdam = _driver.FindElement(By.LinkText("Amsterdam"));
            office.Add("Amsterdam Office is Present");

            IWebElement Eindhoven = _driver.FindElement(By.LinkText("Eindhoven"));
            office.Add("Eindhoven Office is Present");

            IWebElement Utrecht = _driver.FindElement(By.LinkText("Utrecht"));
            office.Add("Utrecht Office is Present");

            IWebElement Singapore = _driver.FindElement(By.LinkText("Singapore"));
            office.Add("Singapore Office is Present");


            IWebElement Stockholm = _driver.FindElement(By.LinkText("Stockholm"));
            office.Add("Stockholm Office is Present");

            IWebElement Göteborg = _driver.FindElement(By.LinkText("Göteborg"));
            office.Add("Göteborg Office is Present");

            IWebElement Malmö = _driver.FindElement(By.LinkText("Malmö"));
            office.Add("Malmö Office is Present");

            IWebElement Uppsala = _driver.FindElement(By.LinkText("Uppsala"));
            office.Add("Uppsala Office is Present");

            IWebElement Västerås = _driver.FindElement(By.LinkText("Västerås"));
            office.Add("Västerås Office is Present");

            IWebElement Geneva = _driver.FindElement(By.LinkText("Geneva"));
            office.Add("Geneva Office is Present");

            IWebElement London = _driver.FindElement(By.LinkText("London"));
            office.Add("London Office is Present");

            IWebElement Manchester = _driver.FindElement(By.LinkText("Manchester"));
            office.Add("Manchester Office is Present");

            IWebElement Bristol = _driver.FindElement(By.LinkText("Bristol"));
            office.Add("Bristol Office is Present");

            IWebElement NewYork = _driver.FindElement(By.LinkText("New York"));
            office.Add("New York Office is Present");

            IWebElement Dallas = _driver.FindElement(By.LinkText("Dallas"));
            office.Add("Dallas Office is Present");

            IWebElement Chicago = _driver.FindElement(By.LinkText("Chicago"));
            office.Add("Chicago Office is Present");

            foreach (string item in office)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("There are {0} Offices in the Contact Page", office.Count);



             _driver.Quit();
          
        }
    }
}



       

           

        
    





            /**

            _driver = new FirefoxDriver();
            _driver.Navigate().GoToUrl(url);
            Assert.AreEqual("Where Experiences are Engineered - Valtech", _driver.Title);

            _driver.FindElement(By.CssSelector("div.hamburger__front > i.icons.glyph")).Click();
            System.Threading.Thread.Sleep(1000);
            _driver.FindElement(By.LinkText("Cases")).Click();            
            Assert.AreEqual("Cases", _driver.FindElement(By.CssSelector("h1")).Text);


            _driver.FindElement(By.CssSelector("div.hamburger__front > i.icons.glyph")).Click();
            System.Threading.Thread.Sleep(1000);
            _driver.FindElement(By.LinkText("Services")).Click();              
            Assert.AreEqual("Services", _driver.FindElement(By.CssSelector("h1")).Text);


            _driver.FindElement(By.CssSelector("div.hamburger__front > i.icons.glyph")).Click();
            System.Threading.Thread.Sleep(1000);
            _driver.FindElement(By.LinkText("Jobs")).Click();               
            Assert.AreEqual("Jobs", _driver.FindElement(By.CssSelector("h1")).Text);
            _driver.FindElement(By.CssSelector("i.icons.glyph")).Click();
            
           //Office Count..
            int valueInt = 1;

            Console.WriteLine(valueInt);
            **/

            
           
            
            
            

        
    
