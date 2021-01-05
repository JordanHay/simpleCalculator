using System;
using Xunit;

namespace SimpleCalculator.Text.Unit
{
    public class InputConverterTest
    {
        private readonly InputConverter _inputConverter = new InputConverter();
        [Fact]
        public void ConvertsValidStringInputIntoDouble()
        {
            string inputNumber = "5";
            double convertedNumber = _inputConverter.ConvertInputToNumeric(inputNumber);
            Assert.Equal(5, convertedNumber);
        }

     
    }
}
