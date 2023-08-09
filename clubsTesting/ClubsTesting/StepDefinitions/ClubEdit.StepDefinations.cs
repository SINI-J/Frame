using ClubsTesting.PageObjects;
using ClubsTesting.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubsTesting.StepDefinitions
{
    [Binding]
    public class EditClubStepDefinations:Helper

    
    {
       private IWebDriver driver;
       
       /*public EditClubStepDefinations(IWebDriver driver)
        {
            this.driver = driver;
        }*/
      

       

        public EditClubStepDefinations(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        [Then(@"I click Edit")]
        public void ThenIClickEdit()
        {
            GetElementByXPath(clubEdit.clubEdit_XPath).Click();
            Thread.Sleep(3000);
        }

        [Then(@"I change the Club name")]
        public void ThenIChangeTheClubName()
        {
            getElementByName(createClub.club_element).Clear();
           
            getElementByName(createClub.club_element).SendKeys(clubEdit.generateeditedclub);
        }

        [Then(@"I see a toast message that club name is saved")]
        public void ThenISeeAToastMessageThatClubNameIsSaved()
        {
            IWebElement notification = GetElementByXPath(createClub.notification_Xpath);
            Console.WriteLine(notification);
            Thread.Sleep(5000);
        }

        [Then(@"the club I edited is selected with the new name")]
        public void ThenTheClubIEditedIsSelectedWithTheNewName()
        {

            IWebElement clubselected = GetElementByXPath(createClub.dashBoardPage_Xpath);
            string actual = clubselected.Text;
               
            string expected = clubEdit.editedclub.ToUpper();

            Assert.Equal(expected, actual);
        }

        [Then(@"the balance summary is shown")]
        public void ThenTheBalanceSummaryIsShown()
        {
            IWebElement balanceSummary = GetElementByXPath(createClub.xpathBalanceSummary);
        }


        [Then(@"the members I added are shown in the summary")]
        public void ThenTheMembersIAddedAreShownInTheSummary()
        {
          GetElementByXPath(clubEdit.clubMemberAdded);
        }



    }



}

