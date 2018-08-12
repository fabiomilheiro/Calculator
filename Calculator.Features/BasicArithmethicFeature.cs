using Calculator.ConsoleApp;
using LightBDD.Framework;
using LightBDD.Framework.Scenarios.Basic;
using LightBDD.XUnit2;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

[assembly: LightBddScope]
namespace Calculator.Features
{
    [FeatureDescription(@"
    In order to avoid mistakes
    As a person who likes to play safe
    I use a calculator fo basic arithmethics.")]
    public class BasicArithmethicFeature : FeatureFixture
    {
        private SmartCalculator calculator;
        private decimal result;

        [Scenario]
        public void AddNumbers()
        {
            Runner.RunScenario(
                GivenACalculator,
                () => WhenISumTwoNumbers(10, 20),
                () => ThenTheResultIs(30));
        }

        [Scenario]
        public void SubtractNumbers()
        {
            Runner.RunScenario(
                GivenACalculator,
                () => WhenISubtractTwoNumbers(10, 20),
                () => ThenTheResultIs(-10));
        }



        [Scenario]
        public void MultiplyNumbers()
        {
            Runner.RunScenario(
                GivenACalculator,
                () => WhenIMultiplyTwoNumbers(10, 20),
                () => ThenTheResultIs(200));
        }

        [Scenario]
        public void DivideNumbers()
        {
            Runner.RunScenario(
                GivenACalculator,
                () => WhenIDivideTwoNumbers(10, 20),
                () => ThenTheResultIs(0.5m));
        }

        private void GivenACalculator()
        {
            calculator = new SmartCalculator();
        }

        private void WhenISumTwoNumbers(decimal firstNumber, decimal secondNumber)
        {
            this.result = calculator.Sum(firstNumber, secondNumber);
        }

        private void WhenISubtractTwoNumbers(decimal firstNumber, decimal secondNumber)
        {
            this.result = calculator.Subtract(firstNumber, secondNumber);
        }

        private void WhenIMultiplyTwoNumbers(decimal firstNumber, decimal secondNumber)
        {
            this.result = calculator.Multiply(firstNumber, secondNumber);
        }

        private void WhenIDivideTwoNumbers(decimal firstNumber, decimal secondNumber)
        {
            this.result = calculator.Divide(firstNumber, secondNumber);
        }

        private void ThenTheResultIs(decimal expectedSumResult)
        {
            Assert.Equal(expectedSumResult, this.result, 10);
        }
    }
}
