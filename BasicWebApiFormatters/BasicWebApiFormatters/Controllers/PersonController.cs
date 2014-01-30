using System.Web.Http;
using BasicWebApiFormatters.Models;

namespace BasicWebApiFormatters.Controllers
{
    public class PersonController : ApiController
    {
        [HttpPost]
        public Person PostAPerson([FromUri] int id, [FromBody] Person person)
        {
            return new Person
            {
                Name = person.Name,
                BirthDate = person.BirthDate,
                Description = "you have successfully posted a person's data with Id:" + id
            };
        }
    }


}
