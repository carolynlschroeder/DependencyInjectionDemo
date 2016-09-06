using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjectionDemo.Entities;

namespace DependencyInjectionDemo.Repositories
{
    public class StaffRepository : IStaffRepository
    {
        public List<Staff> GetAll()
        {
            return new List<Staff>()
            {
                new Staff()
                {
                    FirstName = "Art",
                    LastName = "Venere",
                    Email = "art123@hotmail.com"
                },
                new Staff()
                {
                    FirstName = "James",
                    LastName = "Butt",
                    Email = "james456@gmail.com"
                },
                new Staff()
                {
                    FirstName = "Lenna",
                    LastName = "Paprocki",
                    Email = "lenna567@gmail.com"
                }
            };
        }
    }
}
