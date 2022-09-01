using Microsoft.AspNetCore.Mvc;
using MIVI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MIVIWebAPIEcommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    public class SubCategoryController : ControllerBase
    {
       
        SubCategoryRepository repository = null;
        public SubCategoryController( ApplicationDbContext db)
        {
            repository = new SubCategoryRepository(db);
        }
        // GET: api/<SubCategoryController>
        [HttpGet]
        public IEnumerable<SubCategory> Get()
        {
            return repository.GetAllSubCategories();
        }

        // GET api/<SubCategoryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SubCategoryController>
        [HttpPost]
        public void Post([FromBody] SubCategory value)
        {
            repository.AddSubCategory(value);
        }

        // PUT api/<SubCategoryController>/5
        [HttpPut()]
        public void Put([FromBody] SubCategory value)
        {
            repository.UpdateSubCategory(value);
        }

        // DELETE api/<SubCategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.deleteSubCategory(id);
        }
    }
}
