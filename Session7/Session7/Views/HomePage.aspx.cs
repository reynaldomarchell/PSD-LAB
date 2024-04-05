using Session7.Handlers;
using Session7.Models;
using Session7.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Session7.Views
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridView();
            }
        }

        protected void BindGridView()
        {
            Response <List<Fish>> response = FishHandler.GetAllFish();

            if (response.Success)
            {
                GridView1.DataSource = response.payload;
                GridView1.DataBind();
            }
            else
            {
                return;
            }
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];
            String id = row.Cells[0].Text;
            Response<Fish> response = FishHandler.DeleteFish(id);
            if (response.Success)
            {
                BindGridView();
            }
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int price = Convert.ToInt32(txtPrice.Text);
            Response<Fish> response = FishHandler.Create(name, price);

            if (response.Success)
            {
                BindGridView();
            }
        }

    }
}