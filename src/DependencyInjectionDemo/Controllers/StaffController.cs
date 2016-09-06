using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjectionDemo.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DependencyInjectionDemo.Controllers
{
    public class StaffController : Controller
    {
        private IStaffRepository _staffRepository;

        public StaffController(IStaffRepository staffRepository)
        {
            _staffRepository = staffRepository;
        }

        public IActionResult Index()
        {
            var model = _staffRepository.GetAll();
            return View(model);
        }
    }
}
