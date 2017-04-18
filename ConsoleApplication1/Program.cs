using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
         string _firstName;
         string _lastName;

        public Program(string firstName, string lastName) {
            _firstName = firstName;
            _lastName = lastName;

        }

        public void PrintFullName() {

            System.Diagnostics.Debug.WriteLine(_firstName + _lastName);
        }
    }

    public class Test {

        public static void Main()
        {
            Program p = new Program("A", "B");
            p.PrintFullName();
            Program p1 = new Program("C", "D");
            p1.PrintFullName();
            Program p2 = new Program("Rao", "Raja");
            p2.PrintFullName();
            Program p3 = new Program("testRao", "testRalph");
            p3.PrintFullName();

        }
    }
}
