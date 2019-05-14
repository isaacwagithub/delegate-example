using System;

namespace Delegates
{
    class Program
    {
        private delegate void TestDelegate(string parameter);
        private delegate void TestDelegate2(string parameter, int age);

        static void Main(string[] args)
        {
            TestDelegate testDelegate = new TestDelegate(MethodOne);
            testDelegate += MethodTwo;
            testDelegate += MethodThree;
            testDelegate -= MethodTwo;
            testDelegate.Invoke("Isaac");

            TestDelegate2 testDelegate2 = new TestDelegate2(MethodOne);
            testDelegate2.Invoke("Mpho", 20);

        }
        public static void MethodOne(string name) {
            Console.WriteLine($"My name is {name} from method one");
        }
        public static void MethodOne(string name, int age)
        {
            Console.WriteLine($"My name is {name}, I'm {age} years and I'm from method one");
        }
        public static void MethodTwo(string name)
        {
            Console.WriteLine($"My name is {name} from method two");
        }
        public static void MethodThree(string name)
        {
            Console.WriteLine($"My name is {name} from method three");
        }
    }
}
