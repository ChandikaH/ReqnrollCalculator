using NUnit.Framework;

namespace ReqnrollCalculator.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        public Calculator calculator = new Calculator();
        private int _result;

        [Given("the first number is {int}")]
        public void GivenTheFirstNumberIs(int number)
        {
            calculator.FirstNumber = number;
        }

        [Given("the second number is {int}")]
        public void GivenTheSecondNumberIs(int secondNumber)
        {
            calculator.SecondNumber = secondNumber;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = calculator.Addition();
        }

        [When("the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            _result = calculator.Subtraction();
        }

        [When("the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            _result = calculator.Multiplication();
        }

        [When("the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            _result = calculator.Division();
        }

        [When("the numbers are (.*)")]
        public void WhenTheNumbersAreOperated(string operation)
        {
            switch (operation.ToLower())
            {
                case "added":
                    _result = calculator.Addition();
                    break;
                case "subtracted":
                    _result = calculator.Subtraction();
                    break;
                case "multiplied":
                    _result = calculator.Multiplication();
                    break;
                case "divided":
                    _result = calculator.Division();
                    break;
                default:
                    throw new ArgumentException($"Unknown operation: {operation}");
            }
        }

        [Then("the result should be {int}")]
        public void ThenTheResultShouldBe(int result)
        {
            Assert.That(_result, Is.EqualTo(result));
        }
    }
}
