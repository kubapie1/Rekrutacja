using System;

namespace Rekrutacja.Utils.Calculator
{
    public class Calculator
    {
        private char Operation { get; set; }
        public Calculator(char operation)
        {
            Operation = operation;
        }
        public double Calculate(double val1, double val2)
        {
            switch(Operation)
            {
                case '+':
                    return Add(val1, val2);
                case '-':
                    return Sub(val1, val2);
                case '*':
                    return Mult(val1, val2);
                case '/':
                    return Div(val1, val2);
                default:
                    throw new ArgumentException("Wybierz operacje spośród: +, -, *, /");
            }
        }
        private double Add(double val1, double val2)
        {
            return val1 + val2;
        }
        private double Sub(double val1, double val2)
        {
            return val1 - val2;
        }
        private double Mult(double val1, double val2)
        {
            return val1 * val2;
        }
        private double Div(double val1, double val2)
        {
            if (val2 == 0)
                throw new DivideByZeroException("Nie dziel przez 0!");
            return val1 / val2;
        }
    }
}