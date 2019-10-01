using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TaurusPerformance
{
    [TestFixture]
    public class UnitTest1
    {
        IWebDriver driver;
        [SetUp]

        public void setUp()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void TestMethod1()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        [TearDown]
        public void close()
        {
            driver.Quit();
        }
    }
}
