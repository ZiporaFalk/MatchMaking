using Microsoft.AspNetCore.Mvc;
using System.Net.Sockets;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tickets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchMakerController : ControllerBase
    {

        static List<MatchMaker> matchmakers = new List<MatchMaker>()
        { new MatchMaker{Id=20,Name="chaim cohen",Phone="0548485695",Price=4000 },
        new MatchMaker{Id=21,Name="yossef levi",Phone="054844785",Price=5000 },
            new MatchMaker{Id=22,Name="leha kostelitz",Phone="0548454545",Price=8000 }};
        // GET: api/<TicketController>
        [HttpGet]
        public IEnumerable<MatchMaker> Get()
        {
            return matchmakers;
        }

        [HttpGet("Id")]
        public MatchMaker Get(int Id)
        {
            foreach (MatchMaker matchMaker in matchmakers)
            {
                if (matchMaker.Id == Id)
                    return matchMaker;
            }
            return null;
        }


        [HttpGet("Name")]
        public MatchMaker Get(string name)
        {
            foreach (MatchMaker matchMaker in matchmakers)
            {
                if (matchMaker.Name == name)
                    return matchMaker;
            }
            return null;
        }
        //הוספת שדכן
        [HttpPost]
        public void Post([FromBody] MatchMaker m)
        {
            matchmakers.Add(m);
        }

        //עדכון מחיר לשדכן
        [HttpPut("{id}/{price}")]
        public void Put(int id, int price)
        {
            foreach (MatchMaker matchMaker in matchmakers)
            {
                if (matchMaker.Id == id)
                    matchMaker.Price = price;
            }
        }
        //מחיקת שדכן
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            foreach (MatchMaker matchMaker in matchmakers)
            {
                if (matchMaker.Id == id)
                {
                    matchmakers.Remove(matchMaker);
                    break;
                }
            }
        }
    }
}
