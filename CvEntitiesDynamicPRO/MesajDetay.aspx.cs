using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntitiesDynamicPRO
{
    public partial class MesajDetay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbEntityCVEntities db = new DbEntityCVEntities();
            int x = int.Parse(Request.QueryString["ID"]);
            var mesaj = db.TBLILETISIMs.Find(x);
            TxtAdSoyad.Text = mesaj.ADSOYAD;
            TxtMail.Text = mesaj.MAIL;
            TxtKonu.Text = mesaj.KONU;
            TxtMesaj.Text = mesaj.MESAJ;

        }
    }
}