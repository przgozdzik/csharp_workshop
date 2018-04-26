using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWorkshop.Pages
{
    public class Header
    {
        protected IWebDriver driver;
        public Header(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
