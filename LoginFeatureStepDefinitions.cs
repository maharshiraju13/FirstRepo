using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Reqnroll;
using System;

namespace SeleniumUi.Tests
{
    [Binding]
    public class LoginFeatureStepDefinitions
    {
        [Test]
        [Given("Launch URL")]
        public void GivenLaunchURL()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://sauce-demo.myshopify.com/account/login";
            driver.Manage().Window.Maximize();
            driver.Close();
        }

    }
}
