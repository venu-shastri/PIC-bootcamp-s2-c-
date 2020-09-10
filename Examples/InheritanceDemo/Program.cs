using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentIdCard _studentIdCard = new StudentIdCard("S100", "Tom", "O+");
            Console.WriteLine($"{_studentIdCard.StudentId} {_studentIdCard.Name} {_studentIdCard.BloodGroup}");
        }
    }
}
