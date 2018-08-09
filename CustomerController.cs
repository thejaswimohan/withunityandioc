

namespace CustomerAPI.Controllers
{
    
        using System;
        using System.Collections.Generic;
        using System.Linq;
        using System.Net;
        using System.Net.Http;
        using System.Threading.Tasks;
        using System.Web.Http;
        using System.Web.Http.Description;
    using CustomerAPI.DomainObjects;
    using CustomerAPI.Repository;

        public class CustomerController : ApiController
        {
      
        //private CustomerEntities db = new CustomerEntities();
        //BasicUnitofWork b = new BasicUnitofWork();
       

        //// GET: api/Employees
        //public IEnumerable<CustomerData> GetEmployees()
        //    {
        //    return b.Customer.GetEmployees();
                
        //    }
        ICustomerObject employeeObject;
      
        public CustomerController() { }

        public CustomerController(ICustomerObject _employeeObject)
        {
            employeeObject = _employeeObject;
          
        }
        [Route("api/GetEmployees")]
        public async Task<IEnumerable<CustomerData>> GetEmployees()
        {
           // logger.Debug("Application Started");
            return await employeeObject.GetEmployees();
        }

        //[Route("api/GetAdmin")]
        //public async Task<IEnumerable<Admin>> GetAdmins()
        //{
        //    var admins = await Task.Run(() => unitOfWork.admin_Repository.GetAll());
        //    return admins;
        //}

        //[Route("api/EmployeesgetbyId/{id}")]
        //[ResponseType(typeof(CustomerData))]
        //    public async Task<HttpResponseMessage> GetEmployee(int id)
        //    {
        //        CustomerData employee = await Task.Run(() => unitOfWork.customer_Repository.GetById(id));
        //        if (employee == null)
        //        {
        //            return Request.CreateResponse(HttpStatusCode.NotFound);
        //        }

        //        return Request.CreateResponse(HttpStatusCode.OK, employee);
        //    }

        //    [Route("api/GetEmployeesSortBySalary")]
        //    public IEnumerable<CustomerData> GetEmployeesSortBySalary(CustomerData emp)
        //    {
        //        var employee = unitOfWork.customer_Repository.GetAll();
        //        employee.ToList().Sort();
        //        return employee;
        //    }

        //    [Route("api/PutEmployee/{id}")]
        //    [ResponseType(typeof(void))]
        //    public IHttpActionResult PutEmployee(long id, CustomerData employee)
        //    {
        //        try
        //        {
        //            if (ModelState.IsValid)
        //            {
        //                unitOfWork.customer_Repository.Update(employee);
        //                unitOfWork.Save();
        //            }
        //        }
        //        catch (Exception ex)
        //        {

        //            ModelState.AddModelError("", "Some Error Occurred" + ex.StackTrace);
        //        }
        //        return StatusCode(HttpStatusCode.NoContent);
        //    }

        //    [ResponseType(typeof(CustomerData))]
        //    [Route("api/PostEmployee")]
        //    public IHttpActionResult PostEmployee(CustomerData employee)
        //    {
        //        try
        //        {
        //            if (ModelState.IsValid)
        //            {
        //                unitOfWork.customer_Repository.Add(employee);
        //                unitOfWork.Save();
        //            }
        //        }
        //        catch (Exception ex)
        //        {

        //            ModelState.AddModelError("", "Some Error Occurred." + ex.StackTrace);
        //        }

        //        return CreatedAtRoute("DefaultApi", new { id = employee.Id }, employee);
        //    }

        //    [Route("api/DeleteEmployee")]
        //    [ResponseType(typeof(CustomerData))]
        //    public IHttpActionResult DeleteEmployee(int id)
        //    {
        //        CustomerData employee = unitOfWork.customer_Repository.GetById(id);
        //        if (employee == null)
        //        {
        //            return NotFound();
        //        }
        //        unitOfWork.customer_Repository.Delete(employee);
        //        unitOfWork.Save();

        //        return Ok(employee);
        //    }

        //    protected override void Dispose(bool disposing)
        //    {
        //        if (disposing)
        //        {
        //            unitOfWork.Dispose();
        //        }
        //        base.Dispose(disposing);
        //    }

        }
    }
