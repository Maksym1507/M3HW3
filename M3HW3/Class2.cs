namespace M3HW3
{
    public class Class2
    {
        private int _result;

        public Predicate<int> Calc(Func<int, int, int> multiplyHandler, int firstNumber, int secondNumber)
        {
            _result = multiplyHandler(firstNumber, secondNumber);
            return Result;
        }

        public bool Result(int number)
        {
            _result %= number;
            return _result % 2 == 0;
        }
    }
}
