using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntitiesDynamicPRO
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        DbEntityCVEntities db = new DbEntityCVEntities();
        protected void Button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.TBLADMINs where x.KULLANICIAD == TextBox1.Text && x.SIFRE == TextBox2.Text select x;
            if (sorgu.Any()) //any = yani eger bu sorgudan bana değer dönüyosa
            {
                Response.Redirect("İletisim.Aspx");
            }
            else
            {
                Response.Write("Hatalı Kullanıcı Adı Veya Şifre");
            }
        }
    }
}