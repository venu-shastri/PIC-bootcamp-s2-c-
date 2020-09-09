  public class CodeDemo
    {
        static void Main()
        {
            string[] names = { "Philips", "PIC", "BLR", "BSDK", "CHN" };
            int[] numbers = { 1, 2, 3, 4, 56, 7 };
            List<string> stringList = names.ToList();


            //Step -2 
            Func<string,bool> _pointer = new Func<string,bool>(CheckStringtartWithP);

            //Lamda - grammer - generate Function + Delegate Instance

            Func<string,bool> _newPointer = (string item) => {

                //Method Body 
                return item.EndsWith("s");
            };
            Find<string>(_pointer, names);
            Find<string>(_newPointer, names);

            Find<string>(
                //Grammer - > Generate Method + Instantiate Delegate Instance + Pass Delegate Instance Address
                (string item) => { return item.Length == 3; },
                names
                );


            
        }

        //Step 1 - Define Function
        static bool CheckStringtartWithP(string item)
        {
            return item.StartsWith("P");
        }
        
       
        
        static List<T> Find<T>(Func<T,bool> func, IEnumerable<T> source)
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
