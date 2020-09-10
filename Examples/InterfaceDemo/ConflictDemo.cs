using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    interface ICharchable
    {
        void Connect();
        void Disconnect();
        void Charge();
    }


    interface IWirelessCharchable
    {
        void Connect();
        void Disconnect();
        void Charge();
    }
    class ChargingStation
    {
        public void Plugin(ICharchable device)
        {
            device.Connect();
            device.Charge();
            device.Disconnect();
        }

        public void PluginWireless(IWirelessCharchable device)
        {

        }

    }

    class MiPhone:ICharchable
    {
        public void Charge()
        {
            throw new NotImplementedException();
        }

        public void Connect()
        {
            throw new NotImplementedException();
        }

        public void Disconnect()
        {
            throw new NotImplementedException();
        }
    }

    class IPhone : ICharchable,IWirelessCharchable
    {
        #region Wire Based Charge Behaviors

        //Explict Interface Implementation
        public void Charge()
        {
            throw new NotImplementedException();
        }

        public void Connect()
        {
            throw new NotImplementedException();
        }

         public void Disconnect()
        {
            throw new NotImplementedException();
        }

        #endregion
         void IWirelessCharchable. Charge()
        {
            throw new NotImplementedException();
        }

        void IWirelessCharchable.Connect()
        {
            throw new NotImplementedException();
        }

         void IWirelessCharchable.Disconnect()
        {
            throw new NotImplementedException();
        }

    }

    class SamsungPhone : ICharchable
    {
        public void Charge()
        {
            throw new NotImplementedException();
        }

        public void Connect()
        {
            throw new NotImplementedException();
        }

        public void Disconnect()
        {
            throw new NotImplementedException();
        }
    }


    class Entrypoint
    {
        static void Main()
        {
           IPhone obj = new IPhone();
            obj.Charge();

            IWirelessCharchable _newObj = new IPhone();
            _newObj.Charge();
        }
    }

}
