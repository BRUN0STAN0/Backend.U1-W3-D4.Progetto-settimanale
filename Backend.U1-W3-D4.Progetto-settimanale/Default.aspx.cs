﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Backend.U1_W3_D4.Progetto_settimanale
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Articolo.ListaArticoli.Clear();
                Articolo c001 = new Articolo();
                c001.ID = 1;
                c001.URLImage = "https://th.bing.com/th/id/OIP.nDwmzmffQKPqZaLMXF9-EwAAAA?w=151&h=148&c=7&r=0&o=5&pid=1.7";
                c001.Nome = "Vintage French Rouund Leather Side Chair";
                c001.Descrizione = "Pregiatissima sedia da salotto anni 70, Vintage e di ottima fattura.";
                c001.Categoria = CategoriaSedia.SALOTTO;
                c001.Prezzo = 78.50;
                c001.InOfferta = false;
                Articolo.ListaArticoli.Add(c001);
                Articolo c002 = new Articolo();
                c002.ID = 2;
                c002.URLImage = "https://th.bing.com/th/id/OIP.ovu_GTAIcXdbCWpCbqYQ6wAAAA?w=151&h=148&c=7&r=0&o=5&pid=1.7";
                c002.Nome = "English Windsor Side Chair";
                c002.Descrizione = "Sedia inglese resistente di vero legno, un classico che non muore mai.";
                c002.Categoria = CategoriaSedia.CUCINA;
                c002.Prezzo = 54.00;
                c002.InOfferta = true;
                Articolo.ListaArticoli.Add(c002);
                Articolo c003 = new Articolo();
                c003.ID = 3;
                c003.URLImage = "https://th.bing.com/th/id/OIP.MZNaBtNRkxX9lVF1xLDJ3wAAAA?w=151&h=148&c=7&r=0&o=5&pid=1.7";
                c003.Nome = "Barrelback Swan Chair";
                c003.Descrizione = "Sedia Barrelback di ottima fattura, cuscino rinforzato e legno levigato a mano.";
                c003.Categoria = CategoriaSedia.SALOTTO;
                c003.Prezzo = 144.99;
                c003.InOfferta = true;
                Articolo.ListaArticoli.Add(c003);
                Articolo c004 = new Articolo();
                c004.ID = 4;
                c004.URLImage = "https://th.bing.com/th/id/OIP.UnsHoSuQlQM6zDhWFPX6EwAAAA?w=151&h=148&c=7&r=0&o=5&pid=1.7";
                c004.Nome = "19th C English Schoolhouse Side Chair";
                c004.Descrizione = "Sedia inglese realizzata in legno composito per una lunga durata.";
                c004.Categoria = CategoriaSedia.CUCINA;
                c004.Prezzo = 24.99;
                c004.InOfferta = false;
                Articolo.ListaArticoli.Add(c004);
                Articolo c005 = new Articolo();
                c005.ID = 5;
                c005.URLImage = "https://th.bing.com/th/id/OIP.fg69yxa-5koi-eV6FPMQ0AAAAA?w=150&h=150&c=7&r=0&o=5&pid=1.7";
                c005.Nome = "Jennifer Dining";
                c005.Descrizione = "Per chi vuole il massimo dell'effetto in cucina. Elegante, stile Jennifer.";
                c005.Categoria = CategoriaSedia.CUCINA;
                c005.Prezzo = 119.90;
                c005.InOfferta = true;
                Articolo.ListaArticoli.Add(c005);
                Articolo c006 = new Articolo();
                c006.ID = 6;
                c006.URLImage = "https://th.bing.com/th/id/OIP.Sk1qzM-rN-RWtNpVx5Qn-gAAAA?w=150&h=150&c=7&r=0&o=5&pid=1.7";
                c006.Nome = "Medallion Chair";
                c006.Descrizione = "La cucina che tutti sognano, ha queste tipologie di sedie. Le medallion non hanno bisogno di descrizione.";
                c006.Categoria = CategoriaSedia.CUCINA;
                c006.Prezzo = 220.00;
                c006.InOfferta = true;
                Articolo.ListaArticoli.Add(c006);
                Articolo c007 = new Articolo();
                c007.ID = 7;
                c007.URLImage = "data:image/jpeg;base64,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";
                c007.Nome = "Churchill Leather Swivel Chair";
                c007.Descrizione = "Il divano fatto a sedia. Per chi egoisticamente sogna di spoltronarsi da solo difronte ad una maestosa tv.";
                c007.Categoria = CategoriaSedia.SALOTTO;
                c007.Prezzo = 350.00;
                c007.InOfferta = false;
                Articolo.ListaArticoli.Add(c007);
                Articolo c008 = new Articolo();
                c008.ID = 8;
                c008.URLImage = "https://th.bing.com/th/id/OIP.an6Wwx59AwCIig8_coSr1gAAAA?w=141&h=150&c=7&r=0&o=5&pid=1.7";
                c008.Nome = "Realspace Modern Conform Verismo";
                c008.Descrizione = "Lucida, Confortevole ed ergonomica. In offerta solo per oggi!";
                c008.Categoria = CategoriaSedia.UFFICIO;
                c008.Prezzo = 54.90;
                c008.InOfferta = true;
                Articolo.ListaArticoli.Add(c008);
                Articolo c009 = new Articolo();
                c009.ID = 9;
                c009.URLImage = "https://th.bing.com/th/id/OIP.EfI7RnQx4isQwuik61F03gAAAA?w=141&h=150&c=7&r=0&o=5&pid=1.7";
                c009.Nome = "Executive Office";
                c009.Descrizione = "Se sei il direttore, o aspiri a tale ruolo, questa è la sedia del capo! La sedia che fa per te!";
                c009.Categoria = CategoriaSedia.UFFICIO;
                c009.Prezzo = 99.99;
                c009.InOfferta = true;
                Articolo.ListaArticoli.Add(c009);
                Articolo c010 = new Articolo();
                c010.ID = 10;
                c010.URLImage = "https://th.bing.com/th/id/OIP.M560rXSDd9IHYBffVaxapgAAAA?w=167&h=133&c=7&r=0&o=5&pid=1.7";
                c010.Nome = "Andromeda Chair";
                c010.Descrizione = "Questa è una sedia da osservare. Un opera d'arte.";
                c010.Categoria = CategoriaSedia.SALOTTO;
                c010.Prezzo = 750.00;
                c010.InOfferta = false;
                Articolo.ListaArticoli.Add(c010);
                Articolo c011 = new Articolo();
                c011.ID = 11;
                c011.URLImage = "https://th.bing.com/th/id/OIP.GttHYY3F-VOrj75nIqNtAgAAAA?w=118&h=179&c=7&r=0&o=5&pid=1.7";
                c011.Nome = "Jorn Well Instrual Office";
                c011.Descrizione = "Vuoi dare un tocco di Western al tuo ufficio moderno? Questa è la sedia che fa per te.";
                c011.Categoria = CategoriaSedia.UFFICIO;
                c011.Prezzo = 82.50;
                c011.InOfferta = false;
                Articolo.ListaArticoli.Add(c011);
                Articolo c012 = new Articolo();
                c012.ID = 12;
                c012.URLImage = "https://th.bing.com/th/id/OIP.HbDH8EhH0uvVOIWBv8BSMgAAAA?w=140&h=150&c=7&r=0&o=5&pid=1.7";
                c012.Nome = "Azure Swivel Chair";
                c012.Descrizione = "La sedia per chi ama il lusso nel proprio salotto";
                c012.Categoria = CategoriaSedia.SALOTTO;
                c012.Prezzo = 154.00;
                c012.InOfferta = false;
                Articolo.ListaArticoli.Add(c012);
                Articolo c013 = new Articolo();
                c013.ID = 13;
                c013.URLImage = "https://th.bing.com/th/id/OIP.vXIGrG663WY_eLQiKAY0kQAAAA?w=131&h=140&c=7&r=0&o=5&pid=1.7";
                c013.Nome = "Simple Office Chair";
                c013.Descrizione = "Tutti iniziano la propria avventura con una sedia come questa.";
                c013.Categoria = CategoriaSedia.UFFICIO;
                c013.Prezzo = 19.00;
                c013.InOfferta = true;
                Articolo.ListaArticoli.Add(c013);
                Articolo c014 = new Articolo();
                c014.ID = 14;
                c014.URLImage = "https://th.bing.com/th/id/OIP.qYapCw3Wc288nSsNGGwW_AAAAA?w=140&h=150&c=7&r=0&o=5&pid=1.7";
                c014.Nome = "Jasper Chair";
                c014.Descrizione = "Valentini Forniture ha realizzato questa fantastica poltrona per una persona. Bordeaux!";
                c014.Categoria = CategoriaSedia.SALOTTO;
                c014.Prezzo = 324.00;
                c014.InOfferta = false;
                Articolo.ListaArticoli.Add(c014);
                Articolo c015 = new Articolo();
                c015.ID = 15;
                c015.URLImage = "https://th.bing.com/th/id/OIP.cjQLe9wEnIsGsg-PFj4GRwAAAA?w=142&h=150&c=7&r=0&o=5&pid=1.7";
                c015.Nome = "Office Swivel Chair White";
                c015.Descrizione = "Bianca, elegante, soffice. Inserti in alluminio lucido. Un vero lusso nel proprio ufficio.";
                c015.Categoria = CategoriaSedia.UFFICIO;
                c015.Prezzo = 52.75;
                c015.InOfferta = true;
                Articolo.ListaArticoli.Add(c015);

                Repeater1.DataSource = Articolo.ListaArticoli;
                Repeater1.DataBind();
            }
        }
    }
}