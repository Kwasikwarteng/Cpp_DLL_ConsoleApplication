using System.Runtime.InteropServices;

namespace MobilityAssignmentConsole
{
    class Program
    {
        [DllImport("MobilityAssignmentDll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Multiply(int a, int b);

        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;

            int result = Multiply(num1, num2);
            Console.WriteLine($"The result of multiplying {num1} and {num2} is: {result}");
        }
    }
}
