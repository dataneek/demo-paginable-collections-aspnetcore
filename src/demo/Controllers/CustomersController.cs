namespace Demo
{   
    using Microsoft.AspNetCore.Mvc; 
    using Models;
    using PaginableCollections;
    
    [Route("api/customers")]
    public class CustomersController : Controller
    {
        private readonly ICustomerRepository customerRepository;

        public CustomersController(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        [HttpGet]
        public IActionResult Get(int pageNumber, int itemCountPerPage)
        {
            return Ok(customerRepository.GetCustomers(pageNumber, itemCountPerPage));
        }
    }
}