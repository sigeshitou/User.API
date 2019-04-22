using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using User.API.Data;

namespace User.API.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        protected AppUserContext _appUserContext;
        public ValuesController(AppUserContext appUserContext)
        {
            _appUserContext = appUserContext;
        }

        // GET api/values
        [HttpGet]
        public async  Task<IActionResult> Get()
        {
            return Json(await _appUserContext.Users.SingleOrDefaultAsync(u => u.Name == "sigeshitou"));
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
