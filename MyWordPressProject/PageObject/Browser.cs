using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWordPressProject.PageObject
{
    static public class Browser
    {
        static IWebDriver webDriver = new ChromeDriver(@"C:\Users\Dilhani\Documents\C#MyWonWork\Driver");
        static public IWebDriver driver
        {
            get { return webDriver;}
        }


        static public Goto (string url)
        {
            webDriver.Manage().Window.Maximize();
            webDriver.Url(url);
        }
    }
}
