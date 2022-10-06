using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntitiesDynamicPRO
{
    public partial class Default : System.Web.UI.Page
    {
        DbEntityCVEntities db = new DbEntityCVEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.TBLHAKKIMDAs.ToList();
            Repeater1.DataBind();
            Repeater2.DataSource = db.TBLHAKKIMDAs.ToList();
            Repeater2.DataBind();
            Repeater3.DataSource = db.TBLHAKKIMDAs.ToList();
            Repeater3.DataBind();
            Repeater4.DataSource = db.TBLYETENEKLERs.ToList();
            Repeater4.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TBLILETISIM t = new TBLILETISIM();
            t.ADSOYAD = TextBox1.Text;
            t.MAIL = TextBox2.Text;
            t.KONU = TextBox3.Text;
            t.MESAJ = TextBox4.Text;
            db.TBLILETISIMs.Add(t);
            db.SaveChanges();
        }
    }
}