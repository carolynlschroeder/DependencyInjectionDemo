using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.Entities
{
    public class Operation : IOperationTransient, IOperationScoped, IOperationSingleton
    {
        public Guid OperationId { get; }

        public Operation()
        {
            OperationId = Guid.NewGuid();
        }
    }
}
