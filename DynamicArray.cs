public class DynamicArray
    {

        #region Data members
        int[] buffer;
        #endregion
        #region Constructors
        public DynamicArray() {
            buffer = new int[10];
        }
        public DynamicArray(int capacity)
        {
            buffer = new int[capacity];

        }

        #endregion

        #region methods

        public void Set_Item(int index,int value)
        {
            if (index >= this.buffer.Length)
            {
                int[] tempBuffer = new int[index + 10];
                buffer.CopyTo(tempBuffer, 0);
                buffer = tempBuffer;
            }
            buffer[index] = value;
        }
        public int Get_Item(int index)
        {
            return this.buffer[index];
        }
        #endregion
    }
    
     class Program
    {   static void Main(string[] args)
        {
            DynamicArray numbers = new DynamicArray();
            for(int i = 0; i < 15; i++)
            {
                numbers.Set_Item(i, i + 10);

            }
            int value = numbers.Get_Item(12);
            Console.WriteLine(value);
            Console.WriteLine(numbers.Length);//error
            Console.WriteLine(numbers.ItemCount);//error

        }
    }
