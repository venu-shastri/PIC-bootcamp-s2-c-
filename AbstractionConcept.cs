 public class Person
    {
        public void Quiet() { }
        public void Anger() { }
        public void Friendly() { }

        public void Professional() { }

        public void Matured() { }
    }

    public class Library
    {

        public void Visit(Person obj)
        {
            obj.Anger();//Error
            obj.Friendly();//Error
            obj.Quiet();
            obj.Matured();
            obj.Professional();
        }
            
    }

    public class Office
    {
        public void Work(Person obj)
        {
            obj.Anger();//Error
            obj.Friendly();
            obj.Quiet();//Error
            obj.Matured();
            obj.Professional();
        }
    }

    public class FriendCircle
    {
        public void Hangout(Person obj)
        {
            obj.Anger();
            obj.Friendly();
            obj.Quiet();//Error
            obj.Matured();
            obj.Professional();//Error
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            Person personObj = new Person();
            
            Library _lib = new Library();
            _lib.Visit(personObj);

            Office _office = new Office();
            _office.Work(personObj);

            FriendCircle _meetup = new FriendCircle();
            _meetup.Hangout(personObj);



        }
    
}
