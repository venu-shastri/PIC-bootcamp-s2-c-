
    public delegate void Test();
    public class MultiCastDeleagteDemo
    {
        static void Main_()
        {
            Test _instance_One = new Test(MultiCastDeleagteDemo.Foo);
            Test _instance_two = new Test(MultiCastDeleagteDemo.Fun);
            //_instance_One = (Test)System.Delegate.Combine(_instance_One, _instance_two);
            _instance_One += _instance_two;

            _instance_One.Invoke();
            _instance_One -= _instance_two;//Remove
            _instance_One.Invoke();
        }

        static void Foo() { }
        static void Fun() { }
    }
