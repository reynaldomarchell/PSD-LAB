using Session2_lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Session2_lab.Views
{
    public partial class InsertPage : System.Web.UI.Page
    {
        Database1Entities db = new Database1Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<string> clothType = (from type in db.ClothTypes select type.typeName).ToList();
            ListClothType.DataSource = clothType;
            ListClothType.DataBind();
        }

        protected string GenerateId()
        {
            String newId = "";
            String lastId = (from last in db.Clothes select last.Id).ToList().LastOrDefault();
            if(lastId == null)
            {
                newId = "CO001";
            }
            else
            {
                int numberId = Convert.ToInt32(lastId.Substring(2));
                numberId++;
                newId = string.Format("CO{0:000}", numberId);
            }
            return newId;
        }

        protected void BtnInsert_Click(object sender, EventArgs e)
        {
            String newId = GenerateId();
            String newBrand = TxtBrand.Text.ToString();
            int price = Convert.ToInt32(TxtPrice.Text.ToString());
            String newClothType = ListClothType.Text.ToString();
            String newClothTypeId = (from type in db.ClothTypes where newClothType == type.typeName select type.Id).ToList().FirstOrDefault();

            Cloth cloth = new Cloth();
            cloth.Id = newId;
            cloth.Brand = newBrand;
            cloth.Price = price;
            cloth.Cloth_Type_Id = newClothTypeId;

            db.Clothes.Add(cloth);
            db.SaveChanges();
            Response.Redirect("~/Views/ViewPage.aspx");
        }
    }
}