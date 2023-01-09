using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [Route("greet")]
        public string[] Greet()
        {
            string[] greets = { "Hello", "Namaste", "Hi", "Hey", "Mar" };
            return greets;
        }

        [Route("people")]
        public List<Person> GetPeople()
        {
            var man6eharu = new List<Person>
            {
                new Person { Name = "Ram Karki", Age= 15 },
                new Person { Name = "Kishan Rawal", Age= 14 },
                new Person { Name = "Sita Panta", Age= 12 }
            };

            return man6eharu;
        }
    }
}


public class Person
{
    public string Name { get; set; }
    public byte Age { get; set; }
}
