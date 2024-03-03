using Session3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Session3
{
    public partial class Login : System.Web.UI.Page
    {
        Database1Entities db = new Database1Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["user-cred"] != null)
            {
                var userId = Request.Cookies["user-cred"].Value;

                User user = (from x in db.Users
                             where x.Id.Equals(userId)
                             select x).FirstOrDefault();

                Session["user"] = user;
            }

            if (Session["user"] != null)
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTxt.Text;
            string password = PasswordTxt.Text;

            User user = (from x in db.Users
                         where x.Username.Equals(username)
                         && x.Password.Equals(password)
                         select x).FirstOrDefault();

            if (user == null) {
                // Passing Error Message
                return;
            }

            Session["user"] = user;

            if(RememberCB.Checked)
            {
                HttpCookie cookie = new HttpCookie("user-cred");
                cookie.Value = user.Id;
                cookie.Expires = DateTime.Now.AddHours(1);

                Response.Cookies.Add(cookie);
            }

            Response.Redirect("Home.aspx");
        }
    }
}