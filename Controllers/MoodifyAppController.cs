using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MoodifyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoodifyAppController : ControllerBase
    {
        // GET: api/MoodifyApp
        [HttpGet]
        public bool Get()
        {
            return true;
        }

        
        //GET username pass
        [HttpGet("{login}")]
        public ActionResult GetLogin(string loginPass)
        {
            // 0 username; 1 password
            string[] login = loginPass.Split(';');

            return Ok();
        }

        //GET projects
        [HttpPost("{projects}")]
        public string GetProjects()
        {
            //project + users + calculation of overall mood
            return "value";
        }

        //GET users project?id=1
        [HttpPost("{project}")]
        public string GetProject(int id)
        {
            //project + users + calculation of overall mood + mood history
            return "value";
        }

        //GET user
        [HttpPost("{user}")]
        public string GetUser(int id)
        {
            //project + users + calculation of overall mood
            return "value";
        }

    }
}
