using CustomerAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CustomerAPI.DomainObjects
{
    public class CustomerObject: ICustomerObject
    {
        private UnitofWork unitofWork = new UnitofWork();

        public async Task<IEnumerable<CustomerData>> GetEmployees()
        {
            var employee = await Task.Run(() => unitofWork.customer_Repository.GetAll());
            return employee;
        }
    }
}