using Microsoft.AspNetCore.Mvc;
using Tickets.Controllers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace matchmaking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingController : ControllerBase
    {
        static List<Meeting> meetings = new List<Meeting>()
        { new Meeting{Id=300,IdM=1,IdF=3,Datemeeting=new DateOnly(20,2,2024) ,IdMatchMaker=21,NumMeeting=1,Placemeeting="Park-Aleumi"},
        new Meeting{Id=301,IdM=2,IdF=6,Datemeeting=new DateOnly(8,2,2024) ,IdMatchMaker=24,NumMeeting=4,Placemeeting="Park-Aleumi"},
            new Meeting{Id=302,IdM=1,IdF=5,Datemeeting=new DateOnly(16,5,2024) ,IdMatchMaker=23,NumMeeting=2,Placemeeting="cfar-hamacabia"}};

        //קבלת כל הפגישות
        [HttpGet]
        public IEnumerable<Meeting> Get()
        {
            return meetings;
        }

        [HttpGet("Id")]
        public Meeting Get(int Id)
        {
            foreach (Meeting meeting in meetings)
            {
                if (meeting.Id == Id)
                    return meeting;
            }
            return null;
        }

        //לשאול אם רוצים לעשות 2 get שמקבל int
        //[HttpGet("idresume")]
        //public Meeting Get(int idresume)
        //{
        //    foreach (Meeting meeting in meetings)
        //    {
        //        if (meeting.IdM == idresume)
        //            return meeting;
        //    }
        //    return null;
        //}

        //הוספת פגישה
        [HttpPost]
        public void Post([FromBody] Meeting m)
        {
            meetings.Add(m);
        }

        //עדכון מקום לפגישה
        [HttpPut("{id}/{place}")]
        public void Put(int id, string place)
        {
            foreach (Meeting meeting in meetings)
            {
                if (meeting.Id == id)
                    meeting.Placemeeting = place;
            }
        }
        //מחיקת פגישה
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            foreach (Meeting meeting in meetings)
            {
                if (meeting.Id == id)
                {
                    meetings.Remove(meeting);
                    break;
                }
            }
        }

    }
}
