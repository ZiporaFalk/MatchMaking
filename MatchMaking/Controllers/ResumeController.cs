using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Numerics;


namespace Tickets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResumeController : ControllerBase
    {

        static List<Resume> Resumes = new List<Resume>()
        { new Resume{Id=1,Name="Lea Coen",Address="chazon ish" ,Phone="0533145728" },
        new Resume{Id=2,Name="riki kraus",Address="Lando" ,Phone="0527176658" },
        new Resume{Id=3,Name="zipi gold",Address="Jerusalem" ,Phone="0533145728" }};

        //שליפת כל המועמדים                 
        [HttpGet]
        public IEnumerable<Resume> Get()
        {
            return Resumes;
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            foreach (Resume resume in Resumes)
            {
                if (resume.Id == id)
                    return Ok(resume);
            }
            return NotFound();
        }
        //שליפת מועמד לפי מין          
        [HttpGet("{min}")]
        public ActionResult Get(string min)
        {
            foreach (Resume resume in Resumes)
            {
                if (resume.Min == min)
                    return Ok(resume);
            }
            return NotFound();
        }
        //הוספת מועמד חדש                   
        [HttpPost]
        public void Post([FromBody] Resume c)
        {
            Resumes.Add(c);
        }
        //עדכון מועמד (סמינר
        //לשאול אם אני רוצה לעשכן כל פעם מאפיין אחר
        [HttpPut("{id}")]
        [HttpPost("Update Phone")]
        public void Put(int id, [FromBody]  string phone)
        {
            foreach (Resume resume in Resumes)
            {
                if (resume.Id == id)
                {
                    resume.Phone = phone;
                }
            }
            
        }

        //מחיקת מועמד                          
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            foreach (Resume resume in Resumes)
            {
                if (resume.Id == id)
                {
                    Resumes.Remove(resume);
                    break;
                }
            }
        }
    }
}
