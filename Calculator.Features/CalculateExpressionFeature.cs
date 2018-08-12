using Calculator.ConsoleApp;
using LightBDD.Framework;
using LightBDD.Framework.Scenarios.Extended;
using LightBDD.XUnit2;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculator.Features
{
    [FeatureDescription(@"
    In order to get things done faster
    As a user
    I want to get the result of experssions.")]
    public class CalculateExpressionFeature : FeatureFixture
    {
        private SmartCalculator sut;
        private decimal result;

        [Scenario]
        [InlineData("10 + 10 - 1", 19)]
        [InlineData("10 + 10 * 2", 30)]
        [InlineData("(10 + 10) * 2", 40)]
        public void CalculateExpressionResult(string expression, decimal expectedResult)
        {
            Runner.RunScenario(
                _ => GivenACalculator(),
                _ => WhenIPassAnExpression(expression),
                _ => ThenTheResultIs(expectedResult));
        }

        private void GivenACalculator()
        {
            sut = new SmartCalculator();
        }

        private void WhenIPassAnExpression(string expression)
        {
            result = sut.Calculate(expression);
        }

        private void ThenTheResultIs(decimal expectedResult)
        {
            Assert.Equal(expectedResult, result);
        }
    }
}
