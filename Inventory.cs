﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class Inventory//model class
    {
        public List <TypeofRice> typeofRice;
       
        public List <TypeofWheat> typeofWheat;

        public List <TypeofPulse> typeofPulse;



    }
    public class TypeofRice
    {
        public string name { get; set; }
        public int weight { get; set; }
        public int price { get; set; }

    }
    public class TypeofWheat
    {
        public string name { get; set; }
        public int weight { get; set; }
        public int price { get; set; }

    }
    public class TypeofPulse
    {
        public string name { get; set; }
        public int weight { get; set; }
        public int price { get; set; }

    }

}
