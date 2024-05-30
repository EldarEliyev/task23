using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp53
{
    public class Customer
    {
        private string _name;
        private int _fincode;
        private string _surname;
        public string surname
        {
            get
            {
                return _surname;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value");
                } _surname = value;
            }
        }

        public string name
        {
            get
            {  
                 return _name; 
            }
            set 
            {  
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("no name");
                    name  = value;
            }
            }

        }



        public int fincode
        {
            get
            {
                return _fincode;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("fincode cannot be less than 0");
                }
                _fincode = value;
                
            }
        }
    }
}
