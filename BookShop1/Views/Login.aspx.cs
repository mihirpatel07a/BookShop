using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookShop1.Views
{
    public partial class Login : System.Web.UI.Page
    {
        BookShop.Models.functions Con;
     

        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new BookShop.Models.functions();
            
            
        }
        public static string uname = "";
        public static int User;
        protected void loginbtn_Click(object sender, EventArgs e)
        {
            if(U_name.Value == "" || Password.Value == "")
            {
                ErrMsg.Text = "Missing Detail !!";
            }
            else if(U_name.Value == "Admin@gmail.com"  && Password.Value == "password")
            {
                Response.Redirect("Admin/Books.aspx");
            }
            else
            {
                string query = "select * from SellerTbl where SelEmail = '{0}' and SelPassword = '{1}'";
                query = String.Format(query, U_name.Value, Password.Value);
                DataTable dt = Con.GetData(query);
                if(dt.Rows.Count == 0)
                {
                    ErrMsg.Text = "User not found";
                }
                else
                {
                    uname = U_name.Value;
                    User = Convert.ToInt32(dt.Rows[0][0].ToString());

                }
            }
        }
    }
}