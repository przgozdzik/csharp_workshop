using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumWorkshop.Pages
{
    public class ProductPage : Header
    {
        public ProductPage(IWebDriver driver) : base (driver)
        {
        }

        public IWebElement Color()
        {
            return driver.FindElement(By.CssSelector("#color_14"));
        }

        public IWebElement Size()
        {
            return driver.FindElement(By.CssSelector("#group_1 > option:nth-child(2)"));
        }

        public IWebElement AddToCart()
        {
            return driver.FindElement(By.CssSelector("#add_to_cart > button > span"));
        }

        public IWebElement ContinueShopping()
        {
            return driver.FindElement(By.CssSelector("#layer_cart > div.clearfix > div.layer_cart_cart.col-xs-12.col-md-6 > div.button-container > span > span"));
        }

    }
}
