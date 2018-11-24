using System.Collections.Generic;
using ChildVacAPI.Models;

namespace ChildVacAPI.Services
{
    public interface IChildService
    {
        IEnumerable<Child> GetAll();
        Child Get(string name);
        Child Add(Child child);
    }
}
