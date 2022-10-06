using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntitiesDynamicPRO
{
    public partial class Hakkimda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbEntityCVEntities db = new DbEntityCVEntities();
            Repeater1.DataSource = db.TBLYETENEKLERs.ToList();
            Repeater1.DataBind();

        }
    }
}