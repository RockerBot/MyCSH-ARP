using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            byte numbler = 1;
            float totPrce = 20.25f;//20.25 is double by default
            decimal ada = 12.555555m;
            char cherctr = 'A';
            string str = "wooo";
            bool working = true;
            var yum = true;
            Console.WriteLine(numbler);
            Console.WriteLine(totPrce);
            Console.WriteLine(cherctr);
            Console.WriteLine(str);
            Console.WriteLine(ada);
            Console.WriteLine(working);
            Console.WriteLine("{0}, {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0}, {1}", char.MinValue, char.MaxValue);
            const float Pi = 3.14f;
            string s = "1234";
            int nums = numbler;
            byte numss = (byte)nums;
            int interesting = Convert.ToInt32(s);
            int james = int.Parse(s);
            try
            {
                byte ii = Convert.ToByte(s);//errs out cas 1234 is greater than 255
                Console.WriteLine(ii);

            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("nope");
            }
            //Console.Write("Enter name:");
            //string nam = Console.ReadLine();
            //Console.Write("Enter age:");
            //int age = Convert.ToInt32(Console.ReadLine());

            int[] nuggets = {123,24,34,24,23,432,432,23 };
            string[] namezon = new string[5];
            namezon[1] = "asdfghjkl";
            Console.WriteLine(nuggets[2]);
            Console.WriteLine(namezon[1]);
            Console.WriteLine(Foolala(12));
            int index = 5;
            while (index-->0)
            {
                int j = index;
                do
                {
                    Console.Write("*");
                } while (j-->0);
                Console.WriteLine("-");
            }
            for(int i = 5; i < 20; i++)
            {
                if(i==6)continue;
                Console.WriteLine(i);
            }
            int[,] mat= { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++) Console.Write(mat[i,j]+" ");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static int Foolala(int n)
        {
            if (n!=0) Console.WriteLine("is:"+n);
            else if (n < n << 2) Console.WriteLine("eh"+n);
            else Console.WriteLine("not" + n);
            switch (n % 4) { 
                case 0:
                    Console.WriteLine("aaa:"+n);
                    break;
                case 1:
                    Console.WriteLine("bbb:"+n);
                    break;
                case 2:
                    Console.WriteLine("ccc:"+n);
                    break;
                default:
                    Console.WriteLine("ddd:"+n);
                    break;
            }
            return n * n + n - n / n;
        }
    }
}
