using System;
using TechTalk.SpecFlow;

namespace SpecFlowTests
{
    [Binding]
    public class SampleFeatureSteps
    {
        [Given(@"I'm on the Transavia Home page")]
        public void GivenIMOnTheTransaviaHomePage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered a '(.*)' and '(.*)' destination")]
        public void GivenIHaveEnteredAAndDestination(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have also entered a depart and return date")]
        public void GivenIHaveAlsoEnteredADepartAndReturnDate()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered a departure airport")]
        public void GivenIHaveEnteredADepartureAirport()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I'm on the Transavia Flight status page")]
        public void GivenIMOnTheTransaviaFlightStatusPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered a valid flight number")]
        public void GivenIHaveEnteredAValidFlightNumber()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press on the search button")]
        public void WhenIPressOnTheSearchButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the user reaches the '(.*)' field")]
        public void WhenTheUserReachesTheField(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I uncheck the '(.*)' checkbox")]
        public void WhenIUncheckTheCheckbox(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the results should only display flights for the concerning destination")]
        public void ThenTheResultsShouldOnlyDisplayFlightsForTheConcerningDestination()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"all available flights should appear for the concerning destination within the specified date")]
        public void ThenAllAvailableFlightsShouldAppearForTheConcerningDestinationWithinTheSpecifiedDate()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"a warning message should appear saying that the field ""(.*)"" is mandatory")]
        public void ThenAWarningMessageShouldAppearSayingThatTheFieldIsMandatory(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the field should be prefilled with the date of tomorrow")]
        public void ThenTheFieldShouldBePrefilledWithTheDateOfTomorrow()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"it should be possible to adjust the date")]
        public void ThenItShouldBePossibleToAdjustTheDate()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the '(.*)' date field should be filled with the text '(.*)'")]
        public void ThenTheDateFieldShouldBeFilledWithTheText(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the information of the concerning flight shoudl appear")]
        public void ThenTheInformationOfTheConcerningFlightShoudlAppear()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
