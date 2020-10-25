using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BusinessRealEstate.Models
{
    public class realestateContext:DbContext
    {
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Branch> Branches { get; set; }
        //public object Branchs { get; internal set; }
    }
}