using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWorkshop.Pages
{
    public class Contact_Us : Header
    {
        public Contact_Us(IWebDriver driver) : base(driver)
        {
        }
            

        public IWebElement SendButton()
        {
            return driver.FindElement(By.CssSelector("#submitMessage > span"));
        }

        public IWebElement DropDown(int OptionOrder)
        {
            return driver.FindElement(By.CssSelector($"#id_contact > option:nth-child({OptionOrder})"));
        }

        public IWebElement EmailBox()
        {
            return driver.FindElement(By.CssSelector("#email"));
        }

        public IWebElement MessageBox()
        {
            return driver.FindElement(By.CssSelector("#message"));
        }

        public IWebElement SendMessage()
        {
            return driver.FindElement(By.CssSelector("#center_column > p"));
        }

    }
}
