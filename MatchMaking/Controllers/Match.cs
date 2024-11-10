namespace matchmaking.Controllers
{
    public class Match
    {
        public int Id { get; set; }
        public int IdMatchMaker { get; set; }
        public int IdM { get; set; }
        public int IdF { get; set; }
        public DateOnly dateWedding { get; set; }
        public Match()
        {
            
        }

        public Match(int id, int idMatchMaker, int idM, int idF, DateOnly dateWedding)
        {
            Id = id;
            IdMatchMaker = idMatchMaker;
            IdM = idM;
            IdF = idF;
            this.dateWedding = dateWedding;
        }
    }
}
