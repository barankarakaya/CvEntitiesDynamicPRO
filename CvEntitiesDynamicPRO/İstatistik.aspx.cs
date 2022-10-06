using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntitiesDynamicPRO
{
    public partial class İstatistik : System.Web.UI.Page
    {
        DbEntityCVEntities db = new DbEntityCVEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = db.TBLYETENEKLERs.Count().ToString();
            Label2.Text = db.TBLILETISIMs.Count().ToString();
            Label3.Text = db.TBLYETENEKLERs.Average(x => x.DERECE).ToString();
            Label4.Text = db.TBLYETENEKLERs.Max(x => x.DERECE).ToString();
           
        }
    }
}