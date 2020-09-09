    public delegate bool FunctionPointerGeneric<T>(T item);
    public delegate bool FunctionPointer(string item);
   public class CodeDemo
    {
        static void Main()
        {
            string[] names = { "Philips", "PIC", "BLR", "BSDK", "CHN" };
            FindString("P", names);
            FindString("B", names);
            FindString("p", names);
            FindString("b", names);

            FunctionPointer _pointer1 = new FunctionPointer(CheckStringLength_3);
            FindString(_pointer1, names);
            FunctionPointer _pointer2 = new FunctionPointer(CheckStringLength_3);
            FindString(_pointer2, names);

            int[] numbers = { 1, 2, 3, 4, 56, 7 };

            FunctionPointerGeneric<int> _pointer3 = new FunctionPointerGeneric<int>(CheckNumberEvenOrOdd);
            Find<int>(_pointer3, numbers);

            FunctionPointerGeneric<string> _pointer4 = new FunctionPointerGeneric<string>(CheckStringStartsWithP);
            Find<string>(_pointer4, names);

            List<string> nameList = names.ToList();
          List<string> _result=  Find<string>(_pointer4, nameList);
            for(int i = 0; i < _result.Count; i++)
            {
                Console.WriteLine(_result[i]);
            }
            foreach(string item in _result)
            {
                Console.WriteLine(_result[i]);
            }
        }

        
       
        static bool CheckStringStartsWithP(string item)
        {
            return item.StartsWith("P");
        }
        static bool CheckStringLength_3(string item)
        {
            return item.Length == 3;
        }
        static bool CheckNumberEvenOrOdd(int item)
        {
            return item % 2 == 0;
        }
        static List<string> FindString(string prefix, string[] source)
        {
            List<string> resultList = new List<string>();
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i].StartsWith(prefix))
                {
                    resultList.Add(source[i]);
                }
            }
            return resultList;
        }
        static List<string> FindString(FunctionPointer func,string[] source)
        {
            List<string> resultList = new List<string>();
            for (int i = 0; i < source.Length; i++)
            {
                if (func.Invoke(source[i]))
                {
                    resultList.Add(source[i]);
                }
            }
            return resultList;

        }
        static List<T> Find<T> (FunctionPointerGeneric<T> func, T[] source)
        {
            List<T> resultList = new List<T>();
            for (int i = 0; i < source.Length; i++)
            {
                if (func.Invoke(source[i]))
                {
                    resultList.Add(source[i]);
                }
            }
            return resultList;
        }

        static List<T> Find<T>(FunctionPointerGeneric<T> func, IEnumerable<T> source)
        {
            List<T> resultList = new List<T>();

           //IEnumerator<T> _iterator= source.GetEnumerator();
           // try
           // {
           //     while (_iterator.MoveNext())
           //     {
           //         T item = _iterator.Current;
           //         if (func(item))
           //         {
           //             resultList.Add(item);
           //         }
           //     }
           // }
           // finally
           // {
           //     _iterator.Dispose();
           // }
           foreach(T item in source) {

                if (func.Invoke(item))
                {
                    resultList.Add(item);
                }
            }
            return resultList;
        }

    }
