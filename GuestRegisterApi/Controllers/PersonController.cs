using GuestRegisterModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace GuestRegisterApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        [Route("getPerson")]
        public IActionResult getPerson()
        {
            List<Person> peopleList = new List<Person>();

            Person p = null;
            p = new Person
            {
                Name = "Erfan",
                ReservCode = "1254893",
                RoomNumber = "4",
                companions = "3",
                NatCode = "0926881159",
                CheckinDate = "1402/07/12",
                CheckOutDate = "1402/07/05",
                Price = "2000"
            };
            peopleList.Add(p);

           


            return Ok(peopleList);


        }
    }
}
