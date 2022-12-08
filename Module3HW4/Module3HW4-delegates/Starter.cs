namespace Module3HW4_delegates
{
    public class Starter
    {
        public Starter()
        {
            CalcFuncEvent += Sum;
            CalcFuncEvent += Sum;
        }
        public delegate int CalcFunc(int a, int b);
        public event CalcFunc CalcFuncEvent;
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public int TryMethod(CalcFunc method, int a, int b)
        {
            try
            {
                return method(a, b);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
        public int CalcAll(int a, int b)
        {
            int result = 0;
            foreach (CalcFunc method in CalcFuncEvent.GetInvocationList())
            {
                result += TryMethod(method, a, b);
            }
            return result;
        }
        public void Run(int a, int b)
        {
            Console.Write($"({a} + {b}) * 2 = ");
            Console.WriteLine(CalcAll(2, 4));
        }
    }
}
