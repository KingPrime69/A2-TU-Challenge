using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static object GenericSort(List<int> toSort, Func<int, int, bool> isInOrder)
        {

            toSort.Sort();
            return toSort;
        }

        public static List<int> GetAllPrimary(int a)
        {

            List<int> list = new List<int> { };
            for(int i = 2; i <= a; i++)
            {
                if(IsPrimary(i) == true)
                {
                    list.Add(i);
                }
            }
            return list;
        }

        public static bool IsDivisible(int a, int b)
        {
            if(a % b == 0)
            {
                return true;
            }
            return false;
        }

        public static bool IsEven(int a)
        {
            if(a%2 == 0)
            {
                return true;
            }
            return false;
        }

        public static bool IsInOrder(int a, int b)
        {
            if(a > b)
            {
                return true;
            }
            return false;
        }

        public static bool IsInOrderDesc(int arg1, int arg2)
        {
            if (arg1 < arg2)
            {
                return true;
            }
            return false;
        }

        public static bool IsListInOrder(List<int> list)
        {
            int check = list[0];
            foreach(int i in list) 
            { 
                if (i != check)
                {
                    if(!IsInOrder(i, check))
                    {
                        check = i;
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool IsMajeur(int age)
        {
            if(age < 0) throw new ArgumentException();
            if(age >= 150) throw new ArgumentException();
            if(age >= 18) return true;
            return false;
        }

        public static bool IsPrimary(int a)
        {
            int b = a / 2;
            for(int i = 2; i <= b; i++)
            {
                if(a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static int Power(int a, int b)
        {
            return a**b;
        }

        public static int Power2(int a)
        {
            return (int)Math.Pow(a, 2);
        }

        public static object Sort(List<int> toSort)
        {
            throw new NotImplementedException();
        }
    }
}
