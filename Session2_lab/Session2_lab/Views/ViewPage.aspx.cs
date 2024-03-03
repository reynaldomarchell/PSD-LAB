using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Session2_lab.Models;

namespace Session2_lab.Views
{
   
    public partial class WebForm1 : System.Web.UI.Page
    {   
        Database1Entities db = new Database1Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Cloth> clothes = (from c in db.Clothes select c).ToList();
            GridView1.DataSource = clothes;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}