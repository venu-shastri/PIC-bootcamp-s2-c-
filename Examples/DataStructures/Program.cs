using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {

            //DynamicArray numbers = new DynamicArray();
            //for(int i = 0; i < 5; i++)
            //{
            //    numbers[i] = i + 10;//Boxing
            //}

            ////Explicit Cast - Chance of Exception  
            //int item=(int)numbers[4];//unboxing
            //Console.WriteLine(item);
            //Console.WriteLine($"Array Length {numbers.Length} ItemsCount:{numbers.ItemCount}");

            //System.Collections.ArrayList _dynamicList = new System.Collections.ArrayList();
            //_dynamicList.Add(10);//Boxing 4bytes->12 Bytes
            //_dynamicList.Add("Ten"); //string is a reference type and Object is a reference type

            //int x =(int) _dynamicList[0];//UnBoxing Using explicit Cast

            DynamicArray<int> _numbersList = new DynamicArray<int>();
            DynamicArray<string> _stringList = new DynamicArray<string>();

            _numbersList[0] = 10;
            int x = _numbersList[0];

            System.Collections.Generic.List<int> _intList = new List<int>();
            _intList.Add(10);
            int y = _intList[0];

            System.Collections.Generic.Stack<int> _intStack = new Stack<int>();
            System.Collections.Generic.Stack<string> _stringStack = new Stack<string>();
            System.Collections.Generic.Stack<float> _floatStack = new Stack<float>();




        }
    }
}
