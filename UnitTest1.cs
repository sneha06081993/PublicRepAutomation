using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Launch_Google
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver = new ChromeDriver("D:\\Sneha Study Materials\\Selenium\\Drivers\\chromedriver_win32 (1)");
        [TestInitialize]
        public void Launchbrowser()
        {
            
            driver.Navigate().GoToUrl("https://google.com");
            driver.Manage().Window.Maximize();
           

        }
        [TestMethod]
        [TestCategory("Regression")]
        public void LaunchGmail()
        {

            
            driver.Navigate().GoToUrl("https://gmail.com");

        }
        [TestCleanup]
        public void CloseBrowser()
        {


            driver.Close();

        }
    }
}
