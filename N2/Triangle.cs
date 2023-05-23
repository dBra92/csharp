namespace Function
{
    class Triangle
    {
        public double number1;
        public double number2;
        public double number3;

        public double Area()
        {
            double p = (number1 + number2 + number3) / 2.0;
            return Math.Sqrt(p * (p - number1) * (p - number2) * (p - number3));
        }
    }
}