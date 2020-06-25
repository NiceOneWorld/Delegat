using System;


namespace Delegat
{
    class Program
    {
        static int FindCharA(Object[] arr)
        {
            int pos = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals('a'))
                {
                    pos = i;
                    break;
                }
            }
            return pos;
        }
        static int FindNumberTwo(Object[] arr)
        {
            int pos = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(2))
                {
                    pos = i;
                    break;
                }
            }
            return pos;
        }

        static int FindStrStr(Object[] arr)
        {
            int pos = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals("str"))
                {
                    pos = i;
                    break;
                }
            }
            return pos;
        }

        delegate int MyDelegat(Object[] arr);

        static int Find(Object[] arr, MyDelegat myDelegat) => myDelegat(arr);

        static void Main(string[] args)
        {
            Object[] arr = new Object[10] { 4, 5, 6, 7, 8, 2, 10, 11, 12, 12 };
            Console.WriteLine(Find(arr, FindNumberTwo));
            Console.WriteLine();
            Object[] ch = new Object[3] { 'a', 'b', 'c' };
            Console.WriteLine(Find(ch, FindCharA));
            Console.WriteLine();
            Object[] str = new Object[3] { "arr", "ch", "str" };
            Console.WriteLine(Find(str, FindCharA));
            Console.WriteLine(Find(str, FindStrStr));

        }
    }
}
