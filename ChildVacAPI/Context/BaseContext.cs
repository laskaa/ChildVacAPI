using System;
using ChildVacAPI.Models; 
using Microsoft.EntityFrameworkCore;

namespace ChildVacAPI.Context
{
    public class BaseContext : DbContext
    {
        //public BaseContext(DbContextOptions<BaseContext> options) : base(options)
        //{
        //}

        public BaseContext(DbContextOptions<BaseContext> options)
            : base(options)
        {

        }

        public DbSet<Child> Children { get; set; }
    }
}
