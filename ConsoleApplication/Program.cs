using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {

            #region  Print
            //Console.WriteLine(Foo(6));

            //SortNum();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}


            //IndexClass clas = new IndexClass();

            //for (int i = 0; i < 6; i++)
            //{
            //    clas[i] = "aa" + i;
            //}

            //for (int i = 0; i < 6; i++)
            //{
            //    Console.WriteLine(clas[i]);
            //}


            //Console.WriteLine("*******************通过姓名进行索引**********************");
            //for (int i = 0; i < 6; i++)
            //{
            //    Console.WriteLine(clas["aa" + i]);
            //}
            #endregion

            //B b = new B();


            SomeClass s1 = new SomeClass();
            s1.Number1 = 12;

            SomeClass s2 = s1;
            s2.Number1 = 16;

            SomeValue r1 = new SomeValue();
            SomeValue r2 = r1;
            r1.Number1 = 66;
            r2.Number1 = 99;

           // Console.WriteLine(string.Format("s1:{0},,,,s2:{1}", s1.Number1, s2.Number1));
           // Console.WriteLine("\n");
           // Console.WriteLine(string.Format("r1:{0},,,,r2:{1}", r1.Number1, r2.Number1));

            string bb = "bbb";
            string cc = bb;
            cc = "ccccc";
            Console.WriteLine(string.Format("bb:{0},cc:{1}", bb, cc));

            Console.ReadLine();
        }


        #region  递归
        //一列数的规则如下: 1、1、2、3、5、8、13、21、34...... 求第30位数是多少， 用递归算法实现。
        public static int a = 0;
        public static int Foo(int i)
        {
            if (i <= 0)
            {
                return 0;
            }
            else if (i <= 2)
            {
                return 1;
            }
            else
            {
                return Foo(i - 1) + Foo(i - 2);
            }
        }

        #endregion

        #region  冒泡排序
        //请编程实现一个冒泡排序算法？
        public static int[] array;

        public static int[] SortNum()
        {
            array = new int[] { 5, 4, 3, 6, 9, 1, 2 };

            int temp = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {

                    if (array[j] < array[i])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }

        #endregion

    }


   public class A 
   {
       public A() 
       {
           PrintFields();
       }
       public virtual void PrintFields() { }
   }

   public class B : A 
   {
       int x = 1;
       int y;
       public B() 
       {
           y = -1;

       }

       public override void PrintFields()
       {
           Console.WriteLine("x={0},y={1}", x, y);
       }
   }

    
}
