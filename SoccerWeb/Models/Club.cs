namespace SoccerWeb.Models
{
    public class Club
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Liga { get; set; }
        public List<Jugador> Jugadores { get; set; }
    }
}
