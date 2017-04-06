﻿using System.Text.RegularExpressions;

namespace CheeseMVC.Models
{
    public class Cheese
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public string Odor { get; set; }
        public int Age { get; set; }
        public int CategoryID { get; set; }
        public CheeseCategory Category { get; set; }
    }
}
