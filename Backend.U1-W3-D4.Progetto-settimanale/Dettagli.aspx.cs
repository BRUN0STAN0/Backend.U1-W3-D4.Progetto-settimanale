using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Backend.U1_W3_D4.Progetto_settimanale
{
    public partial class Dettagli : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string idChair = Request.QueryString["IDChair"];

            foreach (Articolo a in Articolo.ListaArticoli)
            {
                if (idChair == a.ID.ToString())
                {
                    ImageDetail.ImageUrl = a.URLImage;
                    LabelCardTitle.Text = a.Nome;
                    LabelCardDescription.Text = a.Descrizione;
                    LabelCardPrezzo.Text = a.Prezzo.ToString("c2");
                    //ButtonAggiungiCarrello.Enabled = true;
                    //ButtonAggiungiCarrello.Text = "Aggiungi al carrello";
                }
            }
        }

        protected void ButtonAggiungiCarrello_Click(object sender, EventArgs e)
        {

            string idChair = Request.QueryString["IDChair"];
            foreach (Articolo a in Articolo.ListaArticoli)
            {
                if (idChair == a.ID.ToString())
                {
                    Articolo.CarrelloUtente.Add(a);

                }
            }
        }
    }
}