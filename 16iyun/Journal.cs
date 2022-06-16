using System;
using System.Collections.Generic;
using System.Text;

namespace _16iyun
{
    internal class Journal:Product

    {
        public string Company;


        public override void GetInfo()
        {
            Console.WriteLine($"Name: {Name}, Company: {Company} Price: {Price}");
        }
    }
}
