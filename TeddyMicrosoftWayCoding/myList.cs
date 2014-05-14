using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace TeddyMicrosoftWayCoding
{
    public class myList
    {
        internal object[] elements;
        internal int count;

        public IEnumerator GetEnumerator()
        {
            yield return "Teddy Long";
            yield return "Candy Zhu";
            yield return "Nothing";
        }
        public int ID { set; get; }
    }

    public class test
    {
        public static void Main(string[] args)
        {
            var intArray = new[] { 2, 3, 5, 6 };
            var strArray = new[] { "Hello", "World" };
            var p3 = new { Id = 3, age = 21, Name = "Teddy" };
            Console.WriteLine(TestEnum.Afternoon.ToString());
            myList mm = new myList();
            mm.ID = 1;
            foreach (string x in mm)
            {
                
                Console.WriteLine(x + "\n");
            }
            TestStruct newStruct;
            newStruct.Length = 10;
            newStruct.Width = 10;
            SomeMethod();
            Console.WriteLine(mm.ID.ToString());
            Console.ReadLine();
            
        }

        public static unsafe void SomeMethod()
        {
            Console.WriteLine(sizeof(int));
        }
    }

    public enum TestEnum
    { 
        Morning = 0,
        Afternoon = 1,
        Night =2
    }
    struct TestStruct
    {
        public int Length;
        public int Width;
    }
}
