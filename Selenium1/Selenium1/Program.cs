using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;


namespace Selenium1
{
    class Program
    {
        IWebDriver driver = new ChromeDriver();

        public static void Main(string[] args)
        {

            new Program().launch();
   


        }
         
        public void launch()
        {
            //Launch the ToolsQA Website
            driver.Url = "http://pr-qa.kaz.com.bd/MWBECompliance.Web/Index.html#/";

        }
        [SetUp]
        public void navigate()
        {
            driver.Navigate().GoToUrl("http://pr-qa.kaz.com.bd/MWBECompliance.Web/Index.html#/");
    
        }

       [Test]
        public void Titlelength()
        {
            

            // Storing Title name in String variable
            String Title = driver.Title;

            // Storing Title length in Int variable
            int TitleLength = driver.Title.Length;

            // Printing Title name on Console
            Console.WriteLine("Title of the page is : " + Title);

            // Printing Title length on console
            Console.WriteLine("Length of the Title is : " + TitleLength);

            Console.ReadKey();
            //Closing browser
            // driver.Quit();

        }

        public void UrlLength()
        {
            // Storing URL in String variable
            String PageURL = driver.Url;

            // Storing URL length in Int variable
            int URLLength = PageURL.Length;

            // Printing URL on Console
            Console.WriteLine("URL of the page is : " + PageURL);

            // Printing URL length on console
            Console.WriteLine("Length of the URL is : " + URLLength);

            Console.ReadKey();
        
        }

        public void Sourcelength()
        {

            // Storing Page Source in String variable
            String PageSource = driver.PageSource;

            // Storing Page Source length in Int variable
            int PageSourceLength = driver.PageSource.Length;

            // Printing Page Source on console
            Console.WriteLine("Page Source of the page is : " + PageSource);

            // Printing Page SOurce length on console
            Console.WriteLine("Length of the Page Source is : " + PageSourceLength);

            Console.ReadKey();
        
        
        }
        
        [TearDown]
        public void closeit()
        {
            driver.Close();

        }


    }
}
