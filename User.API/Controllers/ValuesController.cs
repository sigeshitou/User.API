using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using User.API.Data;
using Microsoft.EntityFrameworkCore;
using User.API.Models;

namespace User.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : Controller
    {
        public UserContext _userContext;

        public ValuesController(UserContext userContext)
        {
            _userContext = userContext;
        }

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Json(await _userContext.Users.SingleOrDefaultAsync(u => u.Name == "sigeshitou"));
        }

      

       
    }
}
