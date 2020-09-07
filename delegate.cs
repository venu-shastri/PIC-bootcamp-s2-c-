
    public class EmailTask
    {
        public  void Send()
        {

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Sending Email.....");
            }
        }
    }

    public class SMSTask
    {
        public  void Send()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Sending SMS.....");
            }
        }
    }
    public class WhatsupTask
    {

    }

    public delegate void ThreadStartCommand();

    /*
    public class ThreadStartCommand
    {
        object target;
        string methodName;

        public ThreadStartCommand(object commandTarget,string methodName)
        {
            this.target = commandTarget;
            this.methodName = methodName;
        }
        public void Invoke()
        {
            //Reflection - Dynamically  Discover - Object / DataType Details
            // method existance - Given Object

         System.Type _typeDef =  this.target.GetType();
          System.Reflection.MethodInfo methodInfo=  _typeDef.GetMethod(this.methodName);
            //Invoke - Dynamic Invoke
            methodInfo.Invoke(this.target,null);


        }
    }
    */
    public class Thread {

        ThreadStartCommand _startCommand;
        public Thread(ThreadStartCommand startCommand)
        {
            this._startCommand = startCommand;
        }
        public void Start() {

            this._startCommand.Invoke();
        }
        public void Stop() { }
    }

    
   
    class Program
    {
        static void Main(string[] args)
        {
            EmailTask _emailTask = new EmailTask();
            ThreadStartCommand _emailTaskCommand = new ThreadStartCommand(_emailTask.Send);
            Thread _t1 = new Thread(_emailTaskCommand);
            _t1.Start();

            SMSTask _smsTask = new SMSTask();
            ThreadStartCommand _smsTaskCommand = new ThreadStartCommand(_smsTask.Send);
            Thread _t2 = new Thread(_smsTaskCommand);
            _t2.Start();
        }
    }
