using Session5.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Session5.Views
{
    public partial class Home : System.Web.UI.Page
    {
        ClothRepository clothRepo = new ClothRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridViewCloth.DataSource = clothRepo.GetAllCloth();
            GridViewCloth.DataBind();

            CountLbl.Text = "Cloth Count : " + clothRepo.GetClothCount();
            PriceLbl.Text = "Total Price : " + clothRepo.GetClothTotalPrice();
        }

        protected void GridViewCloth_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = GridViewCloth.SelectedRow.Cells[1].Text;

            Response.Redirect("Detail.aspx?id=" + id);
        }
    }
}