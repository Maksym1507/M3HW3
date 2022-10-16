namespace M3HW3
{
    internal class Program
    {
        private static void Main()
        {
            var class1 = new Class1
            {
                ActionHandler = new Program().Show
            };

            var class2 = new Class2();
            class2.Calc(class1.Multiply, 10, 15);

            class1.ActionHandler(class2.Result(11));
        }

        private void Show(bool result)
        {
            Console.WriteLine(result);
        }
    }
}