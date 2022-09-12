using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class ClsTest
    {
        private string _firstName { get; set; }
        public string _LastName { get; set; }

        public string _firstProp
        {
            get { return _firstName; }
            set { _firstName = value; }
        }


        public ClsTest() 
        {
            _firstProp = "Viks ";
            
        }

        public ClsTest(string _data)
        {
            Console.WriteLine("COnstructor...");
            _firstName = _data;
        }

        ~ ClsTest()
        {
            Console.WriteLine("Destructor...");
        }

    }
}
