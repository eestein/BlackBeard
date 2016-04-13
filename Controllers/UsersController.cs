using System.Collections.Generic;
using Microsoft.AspNet.Mvc;

namespace BlackBeard.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        User[] users = new User[] {
              new User {
                Name = "William Kidd",
                Content = "(Scottish, 1645 - 1701)",
                ImageUrl = "http://historylists.org/images/william-kidd.jpg"
              },
              new User {
                Name = "Edward Teach \"Blackbeard\"",
                Content = "(English, 1680- 1718)",
                ImageUrl = "http://historylists.org/images/edward-teach.jpg"
              }};

        // GET: api/users
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return users;
        }

        // GET api/users/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return users[id];
        }

        // POST api/users
        [HttpPost]
        public void Post([FromBody]User value)
        {
        }

        // PUT api/users/
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]User value)
        {
        }

        // DELETE api/users/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
