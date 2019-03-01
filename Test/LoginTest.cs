using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyWordPressProject.PageObject;

namespace Test
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
        public void Admin_User_Can_Login()
        {
            Pages.LoginPage.Goto();
            string userName = "
            string passWord = "";
            Pages.LoginPage.LoginToPage(userName, passWord);
        }
    }
}
