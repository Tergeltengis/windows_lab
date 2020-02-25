using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab1
{
    public class User
    {
        public string name { get; set; }

        private int _phone;

        public int getPhone { get { return _phone;  } set { _phone = value; } }
       
    }
}
