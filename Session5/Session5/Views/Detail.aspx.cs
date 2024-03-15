using Session5.Models;
using Session5.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Session5.Views
{
    public partial class Detail : System.Web.UI.Page
    {
        ClothRepository clothRepo = new ClothRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            var id = Request.QueryString["id"];

            Cloth cloth = clothRepo.FindById(id);

            IdLbl.Text = cloth.Id;
            NameLbl.Text = cloth.Name;
            PriceLbl.Text = "Rp " + cloth.Price;
            TypeNameLbl.Text = cloth.ClothType.Name;
        }
    }
}