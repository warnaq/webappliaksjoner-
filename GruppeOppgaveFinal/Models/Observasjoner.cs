namespace GruppeOppgaveFinal.Models
{
    public class Observasjoner
    {
        public int id { get; set; }
        public string fullnavn { get; set; }
        public string email { get; set; }
        public string adress { get; set; }
        public string land { get; set; }
        public DateTime dato { get; set; }
        public string Beskrivelse { get; set; }
    }
}
