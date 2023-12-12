﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OzturkOtoMarketWEBUI.Entity
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set;}
        public string Description { get; set;}
        public string Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
        
        public bool IsApproved { get; set; }

        public int  CategoryId { get; set; }  
        public Category Category { get; set;}

    }
}