
    class A {

        
    }
    class B { }
    class Program
    {
        static void Main(string[] args)
        {
            var  vt = 0;
            //Task(vt);//Pass Value , vt is a value type 
            Task(ref vt);//Pass Address of Vt
            Console.WriteLine(vt);

            int value;
          bool isValidConvertion=ConvertToInteger("10", out value);
            Console.WriteLine($" Value {value} and isValidConvertion {isValidConvertion}");

            isValidConvertion = ConvertToInteger("Hundred", out value);
            Console.WriteLine($" Value {value} and isValidConvertion {isValidConvertion}");
            int[] numbers = { 1, 3, 4 };
            Compute( out value,numbers);
            numbers =new int[] { 2,5,6,7,8,9};
            Compute( out value,numbers);

            Compute(out value,1, 2, 3, 4, 5, 5);// new int[] { 1,2,3,4,5,5}
            Compute(out value ,4, 5, 5);//new int[]{4,5,5}
            Compute(out value ,4, 5, 6, 6, 7);//new int[]{4,5,6,7}


            Object obj = GetObject();

            //if(obj is A)
            //{
            //    A target = (A)GetObject();//DownCast
            //}

            //if (obj is B)
            //{
            //    B _bObj = (B)GetObject();//DownCast
            //}

            B _bobj = obj as B;// if valid cast return Object Address , else return null
            if (_bobj != null)
            {
                //Use _bobj;
            }





        }

        static void Task(ref int  x)
        {
            x = 100;
        }
        static bool   ConvertToInteger(string data,out int convertedData)
        {
            bool isSuccessfull = default(bool);
            convertedData = default(int);
            try
            {
                convertedData=System.Convert.ToInt32(data);
                isSuccessfull = true;
            }
            catch(Exception ex)
            {
                isSuccessfull = false;

            }

            return isSuccessfull;
        }

        static void Compute(out int result, params int[] numbers)
        {
            result = default(int);
            for(int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
        }

        static Object GetObject()
        {
            return new A();
        }

        static void Foo()
        {
            //Implicitly Typed Variable - Limited to method scope (local varialble)
            var x = default(int);
            
            var y = default(int);
            var z = default(int);

            x = y + z;
        }
    }
