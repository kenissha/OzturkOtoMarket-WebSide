﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace OzturkOtoMarketWEBUI.Entity
{
    public class DataContext: DbContext
    {
        public DataContext() : base("dataConnection")
        {
            Database.SetInitializer(new DataInitializer());

        }


        public DbSet <Product> Products { get; set; }
        public DbSet <Category> Categories { get; set; }
    }
}