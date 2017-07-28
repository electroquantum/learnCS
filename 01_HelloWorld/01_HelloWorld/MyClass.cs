using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HelloWorld
{
    // Class
    //      single inheritance

    public class MyClass : SuperClass
    {

        // Field.
        private string msg;
        private int seconds;
       
        // Properties combine aspects of both fields and methods:
        //      are used as normal fields
        //      but the implementation include set-accessor and get-accessor 
        //      are not variables, so cannot be passed to a method as ref or out parameter
        //      useful for data validation 

        // Property with default implementation of get and set.
        public int Number { get; set; }
        
        // Property.
        public int Hours
        {
            get { return seconds / 3600; }
            set
            {
                if(value<0 || value > 24)
                {
                    throw new ArgumentOutOfRangeException();
                }
                seconds = value * 3600;
            }
        }

        // Property as expression-bodied members from C#6
        public string ErrMsg => $"Message: {Number}_{ErrMsg}";

        // Property as expression-bodied members from C#7
        /*
        public string Msg {
            get => msg;
            set => msg = value;
        }
        */

        // Constructor.
        public MyClass()
        {
            Number = 0;
            msg = "";
            seconds = 10000;
        }

        // Constructor (alternative)
        public MyClass(int n, string s)
        {
            Number = n;
            msg = s;
        }

        // Method
        public int GetNum()
        {
            return Number;
        }
    }
}
