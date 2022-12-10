using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Backend.U1_W3_D4.Progetto_settimanale
{
    public partial class Carrello : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridCarrello.DataSource = Articolo.CarrelloUtente;
            GridCarrello.DataBind();
        }
    }
}