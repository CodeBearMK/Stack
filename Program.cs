using System.Collections;

namespace StackEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack SName = new Stack();
            string[] aryName = { "David", "Tom", "Jack", "Mary", "Bob" };
            for (int i = 0; i < aryName.Length; i++)
            {
                SName.Push(aryName[i]);
            }

            // 1. 原始資料
            Console.WriteLine("1. Stack 原始資料, 元素共計：{0}", SName.Count);
            Console.Write("   ");
            foreach (string s in SName)
            {
                Console.Write("{0}   ", s);
            }

            Console.WriteLine("\n");

            // 2. 移除最上面一個資料
            SName.Pop();
            Console.WriteLine("2. Stack 移除最上面一個資料, 元素共計：{0}", SName.Count);
            Console.Write("   ");
            foreach (string s in SName)
            {
                Console.Write("{0}   ", s);
            }

            Console.WriteLine("\n");

            // 3. 顯示最前面資料
            Console.WriteLine("3. Stack 顯示最前面地一個資料：{0}", SName.Peek());

            Console.WriteLine("\n");

            // 4.加入元素
            SName.Push("Susan");
            Console.WriteLine("4. Stack 加入 Susan 資料元素, 元素共計：{0}", SName.Count);
            Console.Write("   ");
            foreach (string s in SName)
            {
                Console.Write("{0}   ", s);
            }

            Console.WriteLine("\n");

            // 5.移除所有元素
            SName.Clear();
            Console.Write("5. Stack 移除所有元素,元素共計：{0}", SName.Count);

            Console.Read();
        }
    }
}