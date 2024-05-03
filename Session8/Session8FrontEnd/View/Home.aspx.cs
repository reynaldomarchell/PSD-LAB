using Session8.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Session8FrontEnd.View
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FoodGV.DataSource = FoodController.GetAllFood();
            FoodGV.DataBind();
        }

        protected void InsertBtn_Click1(object sender, EventArgs e)
        {
            string id = IdTxt.Text;
            string name = NameTxt.Text;
            int price = int.Parse(PriceTxt.Text);

            FoodController.InsertFood(id, name, price);

            FoodGV.DataSource = FoodController.GetAllFood();
            FoodGV.DataBind();
        }
    }
}