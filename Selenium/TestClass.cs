using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.BaseClass;
using System;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace Selenium
{
    [TestFixture]
    public class TestClass : BaseTest
    {
 
        [Test,Category("Smoke Testing")]
        public void TestMethod1()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
        }
        [Test, Category("Regression Testing")]
        public void TestMethod2()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
        }
        [Test, Category("Smoke Testing")]
        public void TestMethod3()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
           
            //dodane w celu przejścia do strony rejestracji - ABY BYŁ KALENDARZ
            var AcceptPopUp = driver.FindElement(By.XPath("//button[@class='_42ft _4jy0 _9xo7 _4jy3 _4jy1 selected _51sy']"));
            AcceptPopUp.Click();
            var RegisterButton = driver.FindElement(By.XPath("//a[@class='_42ft _4jy0 _6lti _4jy6 _4jy2 selected _51sy']"));
            RegisterButton.Click();
           //koniec

            IWebElement monthDropdownList = driver.FindElement(By.XPath(".//*[@id='month']"));
            SelectElement element = new SelectElement(monthDropdownList);
            element.SelectByValue("2");
            element.SelectByText("mar");
            element.SelectByIndex(1);


            Thread.Sleep(5000);
        }
    }
}
