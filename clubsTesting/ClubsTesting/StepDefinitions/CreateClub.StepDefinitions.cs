using ClubsTesting.PageObjects;
using ClubsTesting.Utility;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using Xunit.Sdk;

namespace ClubsTesting.StepDefinitions
{
    [Binding]
    public  class CreateClubStepDefinitions :Helper
    {

        private IWebDriver driver;
       

       /* public CreateClubStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }*/

      
       

        public CreateClubStepDefinitions(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        [Given(@"I logged into COTW")]
        public void GivenILoggedIntoCOTW()
        {
            Console.WriteLine(driver.Title);
            Thread.Sleep(5000);
            GetElementByXPath(ClubEdit.clubElement_Xpath).Click();
            Thread.Sleep(5000);
        }

        [Given(@"I select Create Club")]
        public void GivenISelectCreateClub()
        {
            GetElementByXPath(createClub.clubCreate_Xpath).Click();
            Thread.Sleep(1000);
        }

        [Given(@"I enter a club Name \(the club name does not need \$club\$ as this is added in the background\)")]
        public void GivenIEnterAClubNameTheClubNameDoesNotNeedClubAsThisIsAddedInTheBackground()
        {
             getElementByName(createClub.club_element).SendKeys(createClub.generateclubName); 

        }

        [Given(@"I select Type of Club")]
        public void GivenISelectTypeOfClub()
        {
            GetElementByXPath(createClub.clubType_Xpath).Click();
            IList<IWebElement> selecttype = GetElementsByXpath(createClub.clubTypeDropdown_XPath);

            for (int i = 0; i < selecttype.Count; i++)
            {
                selecttype[1].Click();
                break;
            }
        }
        [Given(@"I do not select any Club Members")]
        public void GivenIDoNotSelectAnyClubMembers()
        {
            Console.WriteLine("no member selected");
        }
        [When(@"I click Save")]
        public void WhenIClickSave()
        {
           GetElementByXPath(createClub.clubSave_XPath).Click();
           
        }

        [Then(@"I am re directed to Active Clubs")]
        public void ThenIAmReDirectedToActiveClubs()
        {
            string url = driver.Url;
            Console.WriteLine(url);
            if (url.Contains("active"))
            {
                Console.WriteLine("Active clubs is selected");
            }
         
        }

        [Then(@"I see a toast message")]
        public void ThenISeeAToastMessage()
        {
            IWebElement notification = GetElementByXPath(createClub.notification_Xpath);
            Console.WriteLine(notification);
            Thread.Sleep(8000);
        }

        [Then(@"the club I created is selected")]
        public void ThenTheClubICreatedIsSelected()
        {
            IWebElement selectedClub = GetElementByXPath(createClub.dashBoardPage_Xpath);
            Console.WriteLine("actual club name is"+ createClub.actual);
         
            string expected = createClub.ClubName.ToUpper();

            Console.WriteLine("expected club name" + expected);

            Assert.Equal(expected, createClub.actual);
        }

        [Then(@"the balance summary is NOT shown")]
        public void ThenTheBalanceSummaryIsNOTShown()
        {
            try
            {
                IWebElement balanceSummary = GetElementByXPath(createClub.xpathBalanceSummary);
            }

            catch (NoSuchElementException e)
            {
                Console.WriteLine("no such element exceptiob found", e);

            }
        }

        [When(@"I type a search in the search bar for club members")]
        public void WhenITypeASearchInTheSearchBarForClubMembers()
        {

           GetElementByXPath(createClub.search).SendKeys(createClub.memberName);
            Thread.Sleep(1000);
        }

        [Then(@"the list of members is filtered and search is shown and can be selected")]
        public void ThenTheListOfMembersIsFilteredAndSearchIsShownAndCanBeSelected()
        {
            IWebElement MemberName = GetElementByXPath(createClub.list + createClub.membersToSelect);
            bool ckeckMemberSelected = MemberName.Selected;
            if (ckeckMemberSelected == true)
            {
                Console.WriteLine("Member selected");
                
            }
            else
            {
                Console.WriteLine("Member is not selected");
            }
            MemberName.Click();
        }

        [Then(@"I can add the member to the club")]
        public void ThenICanAddTheMemberToTheClub()
        {
            GetElementByXPath("//button[@class='btn']").Click();
            IWebElement memberAdded = GetElementByXPath(createClub.selectedMembers + createClub.membersToSelect);
            Assert.True(memberAdded != null);
        }

        [When(@"I Click on Club Groups")]
        public void WhenIClickOnClubGroups()
        {
            GetElementByXPath(createClub.groupList).Click();
        }

        [When(@"I type a search in the search bar for club groups")]
        public void WhenITypeASearchInTheSearchBarForClubGroups()
        {
            GetElementByXPath(createClub.search).SendKeys(createClub.groupName);
            Thread.Sleep(1000);

        }

        [Then(@"the list of Groups are filtered and search is shown and can be selected")]
        public void ThenTheListOfGroupsAreFilteredAndSearchIsShownAndCanBeSelected()
        {
            IWebElement groupSelected = GetElementByXPath(createClub.groupList + createClub.groupToSelect);
            bool groupselect = groupSelected.Selected;
            if (groupselect == true)
            {
               
                Console.WriteLine("Group selected");
            }

            else 
            {
                Console.WriteLine("Group not selected");
            }
            groupSelected.Click();
        }


        [Then(@"I can add the group to the club")]
        public void ThenICanAddTheGroupToTheClub()
        {
           GetElementByXPath("//button[@class='btn']").Click();
            Thread.Sleep(500);
            IWebElement groupAdded = GetElementByXPath(createClub.selectedMembers);
            Assert.True(groupAdded != null);
        }


        [Given(@"I select a club with no members")]
        public void GivenISelectAClubWithNoMembers()
        {
            GetElementByXPath(createClub.selectActiveClub).Click();
            Thread.Sleep(1000);
            
            IWebElement selectedClub = GetElementByXPath(createClub.Nameoftheclubselected);
            string actual = selectedClub.Text;
            GetElementByXPath(createClub.clubName).SendKeys(actual);
            Thread.Sleep(600);
            GetElementByXPath(createClub.clubDescription).Click();
            
        }

 
       
    }
}
