using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new InternetExplorerDriver(@"C:\Users\Mrs Cappy\Downloads\IEDriverServer_Win32_2.45.0");
            driver.Navigate().GoToUrl("granny-square-colors.com");
        }
    }
}
