using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using System.Threading;
using AutoTest.pages;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Context;

namespace AutoTest
{
    [TestFixture]
    public class Test
    {
        public static string igWorkDir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location); // рабочий каталог, относительно исполняемого файла (в нашем случае относительно DLL)
        public static IWebDriver driver;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--ignore-certificate-errors");
            options.AddArguments("--ignore-ssl-errors");
            options.AddArgument("no-sandbox");
            driver = new ChromeDriver(igWorkDir, options);
            driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            driver.Quit();
        }

        public static List<string> TestData()
        {
            var path = TestContext.CurrentContext.TestDirectory + "\\TestData\\LongShort.txt";
            return File.ReadAllLines(path)
                    .TakeWhile(s => !string.IsNullOrEmpty(s))
                    .ToList();
        }

        [Test, TestCaseSource("TestData")]
        public void RunAutoTestPath(string path)
        {
            Build.buildAutoTest(path);
        }

        public static void Case_1()
        {
            driver.Navigate().GoToUrl("https://pethouse.ua/");
            Thread.Sleep(5000);
        }

        public static void Case_2()
        {
            driver.Navigate().GoToUrl("https://pethouse.ua/");
            Thread.Sleep(30000);
        }


        public static void Case_3()
        {
            var icon = driver.FindElement(By.CssSelector("span.header-profile-ico"));
            var actualIconText = icon.Text;
            if (actualIconText != "Y")
            {
                Thread.Sleep(90000);
            }
        }

        public static void Case_4()
        {
            driver.FindElement(By.Id("tpl-logo")).Click();
            var allGoods = driver.FindElements(By.CssSelector("li.zoog-top-good-item"));

            Assert.That(allGoods, Is.Not.Null, "There is no goods are displayed");
        }

        public static void Case_5()
        {
            Case_4();
            var allGoods = driver.FindElements(By.CssSelector("li.zoog-top-good-item"));
            allGoods[1].Click();
            Thread.Sleep(5000);
            driver.FindElement(By.CssSelector("a.ph-new-catalog-unit-buy")).Click();
            var oneCountDisplay = driver.FindElement(By.CssSelector("span.tpl-unit-goodsinbasket")).Displayed;

            //Assert.That(oneCountDisplay, Is.True, "Plus minus increment doesn't exist on page");
        }


        public static void Case_6()
        {
            driver.FindElement(By.CssSelector("span.icon-cart")).Click();
            Thread.Sleep(5000);
            var headerText = driver.FindElement(By.CssSelector("div.tpl-page-header")).Text;

            Assert.That(headerText, Is.EqualTo("Корзина"), "Wrong header name");

        }


        public static void Case_7()
        {
            Thread.Sleep(90000);
        }

        public static void Case_8()
        {
            Thread.Sleep(30000);
        }
    }
}
