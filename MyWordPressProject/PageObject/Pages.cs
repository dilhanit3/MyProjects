using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWordPressProject.PageObject
{
    public static class Pages
    {
        
        public static LoginPage LoginPage
        {
            get
            {
                var loginPage = new LoginPage();
                PageFactory.InitElements(Browser.driver, loginPage);
                return loginPage;
            }
        }
    }
}
