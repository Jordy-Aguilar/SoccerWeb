namespace SoccerWeb.Models
{
    public class Jugador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Posicion { get; set; }
        public int Edad {  get; set; }
        public string Nacionalidad { get; set; }
        public int ClubId { get; set; }
        public Club Club { get; set; }
    }
}
