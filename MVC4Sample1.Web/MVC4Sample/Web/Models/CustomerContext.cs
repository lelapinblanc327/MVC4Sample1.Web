﻿using System.Data.Entity;
using MVC4Sample.Web.Models;

namespace MVC4Sample1.Web.MVC4Sample.Web.Models
{
    public class CustomerContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, add the following
        // code to the Application_Start method in your Global.asax file.
        // Note: this will destroy and re-create your database with every model change.
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<MVC4Sample1.Web.MVC4Sample.Web.Models.CustomerContext>());

        public CustomerContext() : base("name=CustomerContext")
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
