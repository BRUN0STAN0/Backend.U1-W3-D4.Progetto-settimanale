using System.Collections.Generic;

namespace Backend.U1_W3_D4.Progetto_settimanale
{
    public enum CategoriaSedia { UFFICIO, CUCINA, SALOTTO }
    public class Articolo
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public string URLImage { get; set; }
        public double Prezzo { get; set; }
        public CategoriaSedia Categoria { get; set; }
        public bool InOfferta { get; set; }

        public static List<Articolo> ListaArticoli = new List<Articolo>();
        public static List<Articolo> CarrelloUtente = new List<Articolo>();

       
        
    }
}