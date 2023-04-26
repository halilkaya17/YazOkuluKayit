using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using BusinessLogicLayer;
using DataAccessLayer;


public partial class OgrenciGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x= Convert.ToInt32(Request.QueryString["OGRID"]); 
        TxtId.Text=x.ToString();
        TxtId.Enabled = false;

        if (Page.IsPostBack==false)
        {       
        List<EntityOgrenci> OgrList = BLLOgrenci.OgrenciDetayBll(x);

        TxtAd.Text = OgrList[0].AD.ToString();
        TxtSoyad.Text = OgrList[0].SOYAD.ToString();
        TxtNumara.Text = OgrList[0].NUMARA.ToString();
        TxtFotograf.Text = OgrList[0].FOTOGRAF.ToString();
        TxtSifre.Text = OgrList[0].SIFRE.ToString();
        }
    }

    protected void Unnamed7_Click(object sender, EventArgs e)
    {
        EntityOgrenci ent = new EntityOgrenci();
        ent.AD=TxtAd.Text;
        ent.SOYAD=TxtSoyad.Text;
        ent.SIFRE=TxtSifre.Text;
        ent.NUMARA=TxtNumara.Text;
        ent.FOTOGRAF=TxtFotograf.Text;
        ent.OGRID = Convert.ToInt32(TxtId.Text);
        BLLOgrenci.OgrenciGuncelleBll(ent);

        Response.Redirect("OgrenciListesi.aspx");
    }
}