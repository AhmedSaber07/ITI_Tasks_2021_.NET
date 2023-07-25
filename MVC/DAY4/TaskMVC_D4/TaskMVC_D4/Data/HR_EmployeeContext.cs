using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TaskMVC_D4.Data
{
    public class HR_EmployeeContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public HR_EmployeeContext() : base("name=HR_EmployeeContext")
        {
        }

        public System.Data.Entity.DbSet<TaskMVC_D4.Models.Employee> Employees { get; set; }
    }
}
