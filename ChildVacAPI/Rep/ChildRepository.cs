using System;
using System.Collections.Generic;
using System.Linq;
using ChildVacAPI.Context;
using ChildVacAPI.Models;
using ChildVacAPI.Services;

namespace ChildVacAPI.Repositories
{
    public class ChildRepository : IChildService
    {
        private BaseContext _context;

        public ChildRepository(BaseContext context)
        {
            _context = context;
        }

        public Child Add(Child child)
        {
            _context.Children.Add(child);
            _context.SaveChanges();
            return child;
        }

        public Child Get(string name)
        {
            return _context.Children.FirstOrDefault(c => c.Name == name);
        }

        public IEnumerable<Child> GetAll()
        {
            return _context.Children.OrderBy(c => c.IIN);
        }
    }
}
