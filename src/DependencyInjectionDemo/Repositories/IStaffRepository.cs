using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjectionDemo.Entities;

namespace DependencyInjectionDemo.Repositories
{
    public interface IStaffRepository
    {
        List<Staff> GetAll();
    }
}
