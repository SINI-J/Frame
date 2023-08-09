using ClubsTesting.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubsTesting.PageObjects
{
    public class createClub
    {

        public static string clubCreate_Xpath = "//div[text()='Create Club']";
        public static string generateclubName = "Club" + Helper.RandomString(8);
        public static string club_element = "ClubName";
        public static string clubType_Xpath = "//div[text()='Select club type']";
        public static string clubTypeDropdown_XPath = "//div[contains(@class,'drop-down-option')]";
        public static string clubSave_XPath = "//span[text()='Save']";
        public static string notification_Xpath = "//div[@class='notification-bar']";
        public static string dashBoardPage_Xpath = "//h1[contains(@class,'h1_lower')]";

        public static string ClubName;
        public static string xpathBalanceSummary = "//span[text()='Balance summary']";
        public static string memberName = "Sabrina Alsop";// LINKED MEMEBER
        public static string membersToSelect = "//div[text()=" + "'" + memberName + "'" + "]";
        public static string list = "(//item-drawer-group[contains(@class,'group ng-scope')])[1]";
        public static string selectedMembers = "(//div[contains(@class,'selected-members')])[4]";
        public static string search = "(//input[@type='text'])[2]";
        public static string groupName = "Sini Linked Students";
        public static string groupList = "(//item-drawer-group[contains(@class,'group ng-scope')])[2]";
        public static string groupToSelect = "//div[text()=" + "'" + groupName + "'" + "]";
        // public static string _clubNameToFind = "//div[text()=" + "'" + noMemberClub + "'" + "]";
        public static string descrip = "//div[contains(@class,'li ng-scope active')]";
        public static string Nameoftheclubselected = "//div[@class='content-main u-flex-stretch']//h1[@class='h1_lowercase ng-binding']";
        //  public static string editedClub = CreateClubStepDefinitions._createClubName + Helper.RandomString(5);
        //  public static string editedClubName = (string)editedClub;
        // public static string editedClubToFind = "//div[text()=" + editedclubName + "]";
        public static string actual;
        public static string selectActiveClub = "//div[text()='Active']";
        public static string clubName = "//input[@type='text']";
        public static string clubDescription = "//div[@class='description']";






    }
}
