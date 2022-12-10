using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Backend.U1_W3_D4.Progetto_settimanale
{
    public partial class Header : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string path = Request.Url.LocalPath;
            if (path == "/Dettagli.aspx")
            {
                LabelCarrelloAggiungi.Visible = true;
            }
            LabelCarrelloNumeroArticoli.Text = Articolo.CarrelloUtente.Count.ToString();
            double prezzoCarrelloTotale = 0;
            foreach (Articolo a in Articolo.CarrelloUtente)
            {
                prezzoCarrelloTotale += a.Prezzo; ;
            }
            LabelCarrelloTotale.Text = prezzoCarrelloTotale.ToString();
        }

        protected void ResettaCarrello_Click(object sender, EventArgs e)
        {
            Articolo.CarrelloUtente.Clear();
            LabelCarrelloTotale.Text = "0";
            LabelCarrelloNumeroArticoli.Text = "0";
        }

        protected void LabelCarrelloAggiungi_Click(object sender, EventArgs e)
        {
            string idChair = Request.QueryString["IDChair"];
            foreach (Articolo a in Articolo.ListaArticoli)
            {
                if (idChair == a.ID.ToString())
                {
                    Articolo.CarrelloUtente.Add(a);
                    LabelCarrelloNumeroArticoli.Text = (int.Parse(LabelCarrelloNumeroArticoli.Text) + 1).ToString();
                    LabelCarrelloTotale.Text = (Convert.ToDouble(LabelCarrelloTotale.Text) + a.Prezzo).ToString();
                }
            }
        }
    }
}