using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumWorkshop.Pages
{
    public class ProductPage
    {
        IWebDriver driver;
        public ProductPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement Color()
        {
            return driver.FindElement(By.CssSelector(""));
        }
        
    }
}
