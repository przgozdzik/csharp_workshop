using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); // czekaj
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

        [Test]
        public void My_7th_Webdrive()
        {

            var contact_usUrl = driver.FindElementById("contact-link");
            contact_usUrl.Click();

            var cssSelector = driver.FindElementByCssSelector("#id_contact > option:nth-child(2)");
            string actualText = cssSelector.Text;
            
            Assert.AreEqual("Customer service", actualText);
            Console.WriteLine(actualText);

            // cssSelector.Click();

        }

        [Test]
        public void My_8th_Webdrive()
        {

            var contact_usUrl = driver.FindElementById("contact-link");
            contact_usUrl.Click();

            var cssSelector = driver.FindElementByCssSelector("#id_contact");
            string actualText = cssSelector.Text;

            // Assert.AreEqual("Customer service", actualText);
            Console.WriteLine(actualText);


        }

        [Test]
        public void My_9th_Webdrive()
        {

            var contact_usUrl = driver.FindElementById("contact-link");
            contact_usUrl.Click();

            var elements = driver.FindElementsByCssSelector("#id_contact > option");


            foreach (var OneOfTheElements in elements)
            {
                string actualText = OneOfTheElements.Text;
                Console.WriteLine($"Option: {actualText}");

                
            }
            
        }

        [Test]
        public void My_10th_Webdrive()
        {

            var contact_usUrl = driver.FindElementById("contact-link");
            contact_usUrl.Click();

            var cssSelector = driver.FindElementByCssSelector("#id_contact > option:nth-child(3)");
            cssSelector.Click();
        }

        [Test]
        public void My_11th_Webdrive()
        {

            var contact_usUrl = driver.FindElementById("contact-link");
            contact_usUrl.Click();

            var optionSelector = driver.FindElementByCssSelector("#id_contact > option:nth-child(3)");
            optionSelector.Click();

            var emailBox = driver.FindElementByCssSelector("#email");
            emailBox.SendKeys("przemek.gozdzik@test.com");

            var messageBox = driver.FindElementByCssSelector("#message");
            messageBox.SendKeys("Thank you for oportunity to test you website");

            var SendButton = driver.FindElementByCssSelector("#submitMessage > span");
            SendButton.Click();

            var SendMessage = driver.FindElementByCssSelector("#center_column > p");
            string ActualText = SendMessage.Text;

            string ExpectedText = "Your message has been successfully sent to our team.";

            Assert.AreEqual(ExpectedText, ActualText);
            Console.WriteLine(ActualText);

        }

        [Test]
        public void My_12th_Webdrive()
        {

            var searchBar = driver.FindElementByCssSelector("#search_query_top");
            searchBar.SendKeys("casual dresses > printed summer dress");

            var SearchButton = driver.FindElementByCssSelector("#searchbox > button");
            SearchButton.Click();

            var Dress1 = driver.FindElementByCssSelector("#center_column > ul > li > div > div.left-block > div > a.product_img_link > img");
            Dress1.Click();

            var Color1 = driver.FindElementByCssSelector("#color_14");
            Color1.Click();

            var Size1 = driver.FindElementByCssSelector("#group_1 > option:nth-child(2)");
            Size1.Click();

            var AddToCart1 = driver.FindElementByCssSelector("#add_to_cart > button > span");
            AddToCart1.Click();

            Thread.Sleep(1000); // czekaj 1000 ms

            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            var ContinueShopping = driver.FindElementByCssSelector("#layer_cart > div.clearfix > div.layer_cart_cart.col-xs-12.col-md-6 > div.button-container > span > span");
            ContinueShopping.Click();

            //searchBar.SendKeys("casual dresses > printed dress");
            //SearchButton.Click();

            //var Dress2 = driver.FindElementByCssSelector("#center_column > ul > li.ajax_block_product.col-xs-12.col-sm-6.col-md-4.last-line.last-item-of-tablet-line.last-mobile-line > div > div.left-block > div > a.product_img_link > img");
            //Dress2.Click();
             


            //var optionSelector = driver.FindElementByCssSelector("#id_contact > option:nth-child(3)");
            //optionSelector.Click();

            //var emailBox = driver.FindElementByCssSelector("#email");
            //emailBox.SendKeys("przemek.gozdzik@test.com");

            //var messageBox = driver.FindElementByCssSelector("#message");
            //messageBox.SendKeys("Thank you for oportunity to test you website");

            //var SendButton = driver.FindElementByCssSelector("#submitMessage > span");
            //SendButton.Click();

            //var SendMessage = driver.FindElementByCssSelector("#center_column > p");
            //string ActualText = SendMessage.Text;

            //string ExpectedText = "Your message has been successfully sent to our team.";

            //Assert.AreEqual(ExpectedText, ActualText);
            //Console.WriteLine(ActualText);

        }

        [TearDown]
        public void TearDown()
        {
            // driver.Quit(); // zakomentuj i sprawdź co się stanie w teście jeśli asercja nie będzie spełniona
        }
    }
}
