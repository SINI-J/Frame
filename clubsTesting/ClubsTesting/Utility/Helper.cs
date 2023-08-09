using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClubsTesting.Utility
{
    public class Helper
    {
        private static Random random = new Random();

        private IWebDriver driver;

             
    
        public Helper(IWebDriver driver)
        {
            this.driver = driver;
        }


        public static string RandomString(int length)
        {
            const string chars = "abc-ABC_08123DEFGH_abcd_IJKLMNOP_01QRSTUVWXYZ_0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public IWebElement GetElementByXPath(String element)
        {
            return driver.FindElement(By.XPath(element));


        }

        public IList<IWebElement> GetElementsByXpath(String elements)
        {
            return driver.FindElements(By.XPath(elements));
        }

        public IWebElement getElementByName(String element)
        {
            return driver.FindElement(By.Name(element));

        }

        public IWebElement getElementByID(String element)
        {
            return driver.FindElement(By.Id(element));

        }



    }
}
