using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAPI.DomainObjects
{
    public interface ICustomerObject
    {
        Task<IEnumerable<CustomerData>> GetEmployees();
    }
}
