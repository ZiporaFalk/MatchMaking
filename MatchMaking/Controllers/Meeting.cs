using Microsoft.AspNetCore.Mvc;

namespace matchmaking.Controllers
{
    public class Meeting
    {

        public int Id { get; set; }
        public int IdM { get; set; }
        public int IdF { get; set; }
        public int IdMatchMaker { get; set; }
        public int NumMeeting { get; set; }
        public DateOnly Datemeeting { get; set; }
        public string Placemeeting { get; set; }

        public Meeting()
        {
            

        }

        public Meeting(int id, int idM, int idF, int idMatchMaker, int numMeeting, DateOnly datemeeting, string placemeeting)
        {
            Id = id;
            IdM = idM;
            IdF = idF;
            IdMatchMaker = idMatchMaker;
            NumMeeting = numMeeting;
            Datemeeting = datemeeting;
            Placemeeting = placemeeting;
        }
    }
}
