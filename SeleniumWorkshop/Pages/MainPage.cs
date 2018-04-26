using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumWorkshop.Pages
{
    public class MainPage : Header
    {
        public MainPage(IWebDriver driver) : base (driver)
        {
        }


        public IWebElement SearchBar()
        {
            return driver.FindElement(By.CssSelector("#search_query_top"));
        }

        public IWebElement SearchButton()
        {
            return driver.FindElement(By.CssSelector("#searchbox > button"));
        }

        public IWebElement Dress()
        {
            return driver.FindElement(By.CssSelector("#center_column > ul > li > div > div.left-block > div > a.product_img_link > img"));
        }
    }
}
