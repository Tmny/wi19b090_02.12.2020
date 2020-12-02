using System;
using TechTalk.SpecFlow;
using Xunit;

namespace wi19b090_02._12._2020
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        private Calc calc;
        private int result;
        [Given(@"a calculator object")]
        public void GivenACalculatorObject()
        {
            this.calc = new Calc();
        }

        [When(@"adding (.) and (.)")]
        public void WhenAddingAnd(int p0, int p1)
        {
            result = calc.add(p0, p1);
        }

        [Then(@"should return (.)")]
        public void ThenShouldReturnSumm(int p0)
        {
            Assert.Equal(p0, result);
        }

        [When(@"substracting (.) from (.)")]
        public void WhenSubstractingFrom(int p0, int p1)
        {
            result = calc.substract(p0, p1);
        }

        [When(@"multypliing (.) with (.)")]
        public void WhenMultypliingWith(int p0, int p1)
        {
            result = calc.multiply(p0, p1);

        }

        [When(@"divide (.) with (.*)")]
        public void WhenDivideWith(int p0, int p1)
        {
            result = calc.divide(p0, p1);

        }

    }
}

