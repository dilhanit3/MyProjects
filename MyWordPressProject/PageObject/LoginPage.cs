using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWordPressProject.PageObject
{
    public class LoginPage
    {
        string Url = "";

        public void Goto()
        {
            Browser.GoTo(Url);
        }

        public void LoginToPage (string userName, string passWord )
        {

            //Browser.ExplicitWaitFunction("Log in here");
            IWebElement logInHere = Browser.driver.FindElement(By.LinkText("Log in here"));
            logInHere.Click();
            
           
        }
    }
}
