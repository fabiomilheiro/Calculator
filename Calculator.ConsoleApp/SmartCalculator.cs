﻿using System;
using System.Data;

namespace Calculator.ConsoleApp
{
    public class SmartCalculator
    {
        public decimal Calculate(string expression)
        {
            var result = new DataTable().Compute(expression, null);

            return Convert.ToDecimal(result);
        }

        public decimal Sum(decimal first, decimal second)
        {
            return first + second;
        }

        public decimal Subtract(decimal first, decimal second)
        {
            return first - second;
        }

        public decimal Multiply(decimal first, decimal second)
        {
            return first * second;
        }

        public decimal Divide(decimal first, decimal second)
        {
            return first / second;
        }
    }
}
