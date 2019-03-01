using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWordPressProject.PageObject
{
    public static class Browser
    {
        static IWebDriver webDriver = new ChromeDriver(@"");
        //static WebDriverWait _wait; //using OpenQA.Selenium.Support.UI

        static public IWebDriver driver
        {
            get { return webDriver;}
        }


        public static void GoTo(string url)
        {
            webDriver.Manage().Window.Maximize();
            webDriver.Url= url;
        }
       
        public static void ExplicitWaitFunction (string element)
        {
           
            try
            {
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(30)).Until(ExpectedConditions.ElementExists(By.LinkText(element)));
            }
            catch (NoSuchElementException)
            {
                
            }
        }
            
    }
}
