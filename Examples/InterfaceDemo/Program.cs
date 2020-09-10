using InterfaceDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public class Switch
    {
        ISwitchable _appliance;
        public ISwitchable Applicance { set { this._appliance = value; } }
    
        public void On() {
            _appliance.Close();
        }
        public void Off() { _appliance.Open(); }

    }

    //Contract
    //Appliance View from Switch 
    //Public view of an Object
    //Interface name begins with "I"
    public interface ISwitchable
    {
        //Methods are non implemented
        //Methods are abstarct and public 
        void Open();
        void Close();
    }
    //implements 
    public class LedBulb:ISwitchable
    {
        public void Open() { Dim(); }
        public void Close() { Glow(); }
        public void Glow() { Console.WriteLine("Led Glow"); }
        public void Dim() { Console.WriteLine("Led Dim"); }

    }
    class Program
    {
        static void Main(string[] args)
        {
        Switch _switch = new Switch();
        _switch.Applicance = new LedBulb();

        _switch.On();
        _switch.Off();
        }
    }
}
