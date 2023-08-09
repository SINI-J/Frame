using ClubsTesting.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubsTesting.PageObjects
{
    public class clubEdit
    {

        public static string editedclub;
        public static string clubEdit_XPath = "//span[text()='Edit']";
        public static string clubName = "ClubName";
        public static string generateeditedclub = "Editedclub" + Helper.RandomString(8);
        public static string clubMemberAdded = "//div[contains(@class,'balance-table')]//td[text()='Sabrina']";




    }
}
