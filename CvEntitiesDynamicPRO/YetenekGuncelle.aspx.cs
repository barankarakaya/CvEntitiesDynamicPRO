using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntitiesDynamicPRO
{
    public partial class YetenekGuncelle : System.Web.UI.Page
    {
        DbEntityCVEntities db = new DbEntityCVEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = int.Parse(Request.QueryString["ID"]);
            if (Page.IsPostBack == false)//Guncelle ye kaydet dedikten sonra sayfa yeniden yuklenmesin.
            {
                var deger = db.TBLYETENEKLERs.Find(x);
                TextBox1.Text = deger.YETENEK;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(Request.QueryString["ID"]);
            var deger = db.TBLYETENEKLERs.Find(x);
            deger.YETENEK = TextBox1.Text;
            db.SaveChanges();
            Response.Redirect("Yeteneklerim.Aspx");
        }
    }
}