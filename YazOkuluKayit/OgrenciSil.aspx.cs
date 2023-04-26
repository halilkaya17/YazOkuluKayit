using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using BusinessLogicLayer;
using DataAccessLayer;


public partial class OgrenciSil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt32(Request.QueryString["OgrId"]);
        Response.Write(x);
        EntityOgrenci ent = new EntityOgrenci();
        ent.OGRID = x;
        BLLOgrenci.OgrenciSilBLL(ent.OGRID);
        Response.Redirect("OgrenciListesi.Aspx");
    }
}