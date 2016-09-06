using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjectionDemo.Entities;
using DependencyInjectionDemo.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DependencyInjectionDemo.Controllers
{
    public class OperationsController : Controller
    {
        private IOperationTransient _transientOperation;
        private IOperationScoped _scorpedOperation;
        private IOperationSingleton _singletonOperation;
        private OperationService _operationService;

        public OperationsController(IOperationTransient transientOperation, IOperationScoped scopedOperation, 
            IOperationSingleton singletonOperation, OperationService operationService)
        {
            _transientOperation = transientOperation;
            _scorpedOperation = scopedOperation;
            _singletonOperation = singletonOperation;
            _operationService = operationService;

        }

        public ActionResult Index()
        {
            ViewBag.TransientId = _transientOperation.OperationId;
            ViewBag.ScopedId = _scorpedOperation.OperationId;
            ViewBag.SingletonId = _singletonOperation.OperationId;
            ViewBag.Service = _operationService;

            return View();
        }
    }
}
