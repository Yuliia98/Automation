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

        [OneTimeSetUp] // вызывается перед началом запуска всех тестов
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

        public static void Test_2()
        {
            driver.Navigate().GoToUrl("https://www.google.ru");
            driver.FindElement(By.CssSelector("input[title='Поиск']")).Click(); // кликаем в поле ввода поисковой фразы
            driver.FindElement(By.CssSelector("input[title='Поиск']")).SendKeys("В чём сила брат?"); // вводим поисковую фразу
            //driver.FindElement(By.CssSelector("input[value='Поиск в Google']")).Click(); // нажимаем на кнопку "Поиск в Google"
            //Thread.Sleep(5000); // пауза за наблюдением результата поиска, для наглядности
            //driver.FindElement(By.CssSelector("a#logo")).Click(); // возвращаемся на главную страницу кликнув по логотипу
            Thread.Sleep(5000); // пауза за наблюдением перехода на главную, для наглядности
        }

        
        public static void Test_3()
        {
            driver.Navigate().GoToUrl("https://www.google.ru");
            driver.FindElement(By.CssSelector("input[title='Поиск']")).Click(); // кликаем в поле ввода поисковой фразы
            driver.FindElement(By.CssSelector("input[title='Поиск']")).SendKeys("Аниме Боруто?"); // вводим поисковую фразу
            //driver.FindElement(By.CssSelector("input[value='Поиск в Google']")).Click(); // нажимаем на кнопку "Поиск в Google"
            //Thread.Sleep(5000); // пауза за наблюдением результата поиска, для наглядности
            //driver.FindElement(By.CssSelector("a#logo")).Click(); // возвращаемся на главную страницу кликнув по логотипу
            Thread.Sleep(5000); // пауза за наблюдением перехода на главную, для наглядности
        }
      
        public static void Test_4()
        {
            driver.Navigate().GoToUrl("https://www.google.ru");
            driver.FindElement(By.CssSelector("input[title='Поиск']")).Click(); // кликаем в поле ввода поисковой фразы
            driver.FindElement(By.CssSelector("input[title='Поиск']")).SendKeys("Аниме Наруто?"); // вводим поисковую фразу
            //driver.FindElement(By.CssSelector("input[value='Поиск в Google']")).Click(); // нажимаем на кнопку "Поиск в Google"
            //Thread.Sleep(5000); // пауза за наблюдением результата поиска, для наглядности
            //driver.FindElement(By.CssSelector("a#logo")).Click(); // возвращаемся на главную страницу кликнув по логотипу
            Thread.Sleep(5000); // пауза за наблюдением перехода на главную, для наглядности
        }
        
        public static void Test_5()
        {
            driver.Navigate().GoToUrl("https://www.google.ru");
            driver.FindElement(By.CssSelector("input[title='Поиск']")).Click(); // кликаем в поле ввода поисковой фразы
            driver.FindElement(By.CssSelector("input[title='Поиск']")).SendKeys("Аниме Шанхай?"); // вводим поисковую фразу
            //driver.FindElement(By.CssSelector("input[value='Поиск в Google']")).Click(); // нажимаем на кнопку "Поиск в Google"
            //Thread.Sleep(5000); // пауза за наблюдением результата поиска, для наглядности
            //driver.FindElement(By.CssSelector("a#logo")).Click(); // возвращаемся на главную страницу кликнув по логотипу
            Thread.Sleep(5000); // пауза за наблюдением перехода на главную, для наглядности
        }
       

        public static void Test_6()
        {
            driver.Navigate().GoToUrl("https://www.google.ru");
            driver.FindElement(By.CssSelector("input[title='Поиск']")).Click(); // кликаем в поле ввода поисковой фразы
            driver.FindElement(By.CssSelector("input[title='Поиск']")).SendKeys("В чём сила брат?"); // вводим поисковую фразу
            //driver.FindElement(By.CssSelector("input[value='Поиск в Google']")).Click(); // нажимаем на кнопку "Поиск в Google"
            //Thread.Sleep(5000); // пауза за наблюдением результата поиска, для наглядности
            //driver.FindElement(By.CssSelector("a#logo")).Click(); // возвращаемся на главную страницу кликнув по логотипу
            Thread.Sleep(5000); // пауза за наблюдением перехода на главную, для наглядности
        }
       

        public void Test_7()
        {
            driver.Navigate().GoToUrl("https://www.google.ru");
            driver.FindElement(By.CssSelector("input[title='Поиск']")).Click(); // кликаем в поле ввода поисковой фразы
            driver.FindElement(By.CssSelector("input[title='Поиск']")).SendKeys("В чём сила брат?"); // вводим поисковую фразу
            //driver.FindElement(By.CssSelector("input[value='Поиск в Google']")).Click(); // нажимаем на кнопку "Поиск в Google"
            //Thread.Sleep(5000); // пауза за наблюдением результата поиска, для наглядности
            //driver.FindElement(By.CssSelector("a#logo")).Click(); // возвращаемся на главную страницу кликнув по логотипу
            Thread.Sleep(5000); // пауза за наблюдением перехода на главную, для наглядности
        }
        
        public void Test_8()
        {
            driver.Navigate().GoToUrl("https://www.google.ru");
            driver.FindElement(By.CssSelector("input[title='Поиск']")).Click(); // кликаем в поле ввода поисковой фразы
            driver.FindElement(By.CssSelector("input[title='Поиск']")).SendKeys("В чём сила брат?"); // вводим поисковую фразу
            //driver.FindElement(By.CssSelector("input[value='Поиск в Google']")).Click(); // нажимаем на кнопку "Поиск в Google"
            //Thread.Sleep(5000); // пауза за наблюдением результата поиска, для наглядности
            //driver.FindElement(By.CssSelector("a#logo")).Click(); // возвращаемся на главную страницу кликнув по логотипу
            Thread.Sleep(5000); // пауза за наблюдением перехода на главную, для наглядности
        }
       

        public void Test_9()
        {
            driver.Navigate().GoToUrl("https://www.google.ru");
            driver.FindElement(By.CssSelector("input[title='Поиск']")).Click(); // кликаем в поле ввода поисковой фразы
            driver.FindElement(By.CssSelector("input[title='Поиск']")).SendKeys("В чём сила брат?"); // вводим поисковую фразу
            //driver.FindElement(By.CssSelector("input[value='Поиск в Google']")).Click(); // нажимаем на кнопку "Поиск в Google"
            //Thread.Sleep(5000); // пауза за наблюдением результата поиска, для наглядности
            //driver.FindElement(By.CssSelector("a#logo")).Click(); // возвращаемся на главную страницу кликнув по логотипу
            Thread.Sleep(5000); // пауза за наблюдением перехода на главную, для наглядности
        }
    }
}
