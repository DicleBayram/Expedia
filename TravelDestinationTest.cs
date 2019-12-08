using NUnit.Framework;
using Stylelabs.MQA.WebTesting.PageElements;
using System;
using TechTalk.SpecFlow;

namespace Stylelabs.MQA.WebTesting.Tests
{
    [TestFixture]
    [Binding, Scope(Feature = "TravelDestination")]

    public class TravelDestinationTest : BaseTest
    {
        TravelDestination travelDestination;

        [StepDefinition(@"I navigate to the Expedia website")]
        public void OpenHomePage()
        {
            Main();
        }

        [StepDefinition(@"I look for a flight and accommodation from '(.*)' to '(.*)'")]
        public void SetFlightAccommodation(string origin, string destination)
        {
            travelDestination.SetOrigin(origin);
            travelDestination.SetDestination(destination);
        }

        [StepDefinition(@"I choose dates in three months")]
        public void SetDate()
        {
            travelDestination.ClickDeparting();
            travelDestination.SelectStartDate();
            travelDestination.ClickReturning();
            travelDestination.SelectEndDate();
        }
                
        [StepDefinition(@"I choose travelers as one adult and one child is '(.*)' years old")]
        public void SelectTravelersOption(string age)
        {
            int childAge = Convert.ToInt32(age);
            travelDestination.ClickTraveler();
            travelDestination.ClickReduceAdultNumber();
            travelDestination.ClickBtnIncreaseChildNumber();
            travelDestination.ClickAge();
            travelDestination.SelectAge(childAge);
        }

        [StepDefinition(@"I click Search button")]
        public void SelectTravelersOption()
        {
            travelDestination.ClickSearch();
        }        

        [StepDefinition(@"The result page contains travel option for the chosen destination")]
        public void CheckChosenDestination()
        {
            travelDestination.CheckResult();
        }        
    }
}
