namespace Tickets.Controllers
{
    public class MatchMaker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public Double Price { get; set; }

        public MatchMaker()
        {
            
        }

        public MatchMaker(int id, string name, string phone, double price)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Price = price;
        }
    }
}
