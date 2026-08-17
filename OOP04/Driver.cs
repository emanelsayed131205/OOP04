using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
    internal class Driver
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public int PhoneNum { get; set; }

        public Driver(int id, string fullname, int phonenum)
        {
            ID = id;
            FullName = fullname;
            PhoneNum = phonenum;

        }
    }
}
