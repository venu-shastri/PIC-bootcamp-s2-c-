public delegate void OrderStatusChangeHandler(string orderId, OrderStatus status);

    public enum OrderStatus
    {
        CONFIRMED,
        DISPTACHED,
        DELIVERED,
        CANCELLED
    }

    //Subject/Publisher/EventSource
    public class Order
    {
        #region Events
       // private OrderStatusChangeHandler OrderStatusChanged;
       public event OrderStatusChangeHandler OrderStatusChanged;
        #endregion
        /*
        #region Event Mutators

        public void Add_OrderStatusChanged(OrderStatusChangeHandler handler)
        {
            this.OrderStatusChanged += handler;
        }

        public void Remove_OrderStatusChanged(OrderStatusChangeHandler handler)
        {
            this.OrderStatusChanged -= handler;
        }

        #endregion
        */
        private OrderStatus _status;
        private string orderId;
        public string OrderId { get { return this.orderId; } }

        public Order(string orderId)
        {
            this.orderId = orderId;
        }
        public void ChangeOrderStatus(OrderStatus status)
        {
            this._status = status;
            //Raise orderStatusChanged Event 
            if (this.OrderStatusChanged != null)
            {
                this.OrderStatusChanged.Invoke(this.OrderId, this._status);
            }
        }
    }

    //Subscribers/Observers / EventSink
    public class EmailManager
    {
        public void Compose() { }
        public void Send() { }
        public void Recieve() { }

        //Event Handler - Method
        public void Update(string id, OrderStatus status)
        {
            Console.WriteLine($"Email Notification : Order Id { id} and Status { status}" );

        }
    }
    //Subscribers/Observers/EventSink
    public class SMSManager
    {
        public void Compose() { }
        public void Send() { }

        //Event Handler - Method
        public void Notify(string id, OrderStatus status)
        {
            Console.WriteLine($"SMS Notification : Order Id { id} and Status { status}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            EmailManager _emailManager = new EmailManager();
            SMSManager _smsmanager = new SMSManager();

            OrderStatusChangeHandler _handler_one = new OrderStatusChangeHandler(_emailManager.Update);
            OrderStatusChangeHandler _handler_two = new OrderStatusChangeHandler(_smsmanager.Notify);

            Order _order = new Order("ODR100");
            // _order.Add_OrderStatusChanged(_handler_one);
            _order.OrderStatusChanged += _handler_one;

            //_order.Add_OrderStatusChanged(_handler_two);
            _order.OrderStatusChanged += _handler_two;


            _order.ChangeOrderStatus(OrderStatus.CONFIRMED);
            _order.ChangeOrderStatus(OrderStatus.DISPTACHED);
            _order.ChangeOrderStatus(OrderStatus.DELIVERED);
            



        }
    }
