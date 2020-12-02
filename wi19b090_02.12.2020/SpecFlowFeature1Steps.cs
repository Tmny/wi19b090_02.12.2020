using TechTalk.SpecFlow;
using Xunit;

namespace wi19b090_02._12._2020
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(string p0)
        {
            Assert.Equal(p0, "Lampe1");
        }

        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
