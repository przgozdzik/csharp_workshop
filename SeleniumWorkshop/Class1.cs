using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace SeleniumWorkshop
{
    [TestFixture]
    public class Class1 
    {
        public ChromeDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.automationpractice.com");
        }

        [Test]
        public void My_First_Webdrive()
        {
            string expectedUrl = "http://automationpractice.com/index.php?";

            Assert.AreEqual(expectedUrl, driver.Url);

            //Assert.AreEqual(5, 4); // tutaj jest błąd
            // driver.Close(); // zamyka ostatnią aktywną kartę
            // driver.Quit(); // zamyka całą przeglądarkę
            }

        [Test]
        public void My_2nd_Webdrive()
        {
            string expectedTitle = "My Store";

            Assert.AreEqual(expectedTitle, driver.Title);

        }

        [Test]
        public void My_3rd_Webdrive()
        {
            var search_box = driver.FindElementById("search_query_top");

            string text = search_box.Text;

            Assert.AreEqual(string.Empty, text);
        }

        [Test]
        public void My_4th_Webdrive()
        {
            var contact_us = driver.FindElementById("contact-link");

            string text = contact_us.Text;

            Assert.AreEqual("Contact us", text);
        }

        [Test]
        public void My_5th_Webdrive()
        {
            var contact_usUrl = driver.FindElementById("contact-link");
            contact_usUrl.Click();
            string actualUrl = driver.Url;

            string expectedUrl = "http://automationpractice.com/index.php?controller=contact";

            Assert.AreEqual(expectedUrl, actualUrl);
        }

        [Test]
        public void My_6th_Webdrive()
        {
            var cssSelector = driver.FindElementByCssSelector("#homefeatured > li:nth-child(2) > div > div.right-block > h5 > a");
            string actualText = cssSelector.Text;
            
            string expectedText = "Blouse";
            Assert.AreEqual(expectedText, actualText);
        }

        [TearDown]
        public void TearDown()
        {
            // driver.Quit(); // zakomentuj i sprawdź co się stanie w teście jeśli asercja nie będzie spełniona
        }
    }
}
