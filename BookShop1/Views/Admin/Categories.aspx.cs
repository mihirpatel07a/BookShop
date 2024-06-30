using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookShop.Views.Admin
{
    public partial class Categories : System.Web.UI.Page
    {
        BookShop.Models.functions con;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new BookShop.Models.functions();
            showCategories();
        }

        private void showCategories()
        {
            string query = "select * from CategoryTbl";
            Categorylist.DataSource = con.GetData(query);
            Categorylist.DataBind();

        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatName.Value == "" || C_des.Value == "")
                {
                    ErrMsg.Text = "Missing Detail!!!";
                }

                else
                {
                    string cat_name = CatName.Value;
                    string cat_desc = C_des.Value;

                    string query = "update CategoryTbl set CatName = '{0}' , CatDescription = '{1}' where Catid = '{2}'";
                    query = string.Format(query, cat_name, cat_desc, Categorylist.SelectedRow.Cells[1].Text);
                    con.SetData(query);
                    showCategories();
                    ErrMsg.Text = "Category updated !!";
                    CatName.Value = "";
                    C_des.Value = "";

                }
            }


            catch (Exception ex)
            {
                ErrMsg.Text = ex.Message;
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatName.Value == "" || C_des.Value == "")
                {
                    ErrMsg.Text = "Missing Detail!!!";
                }

                else
                {
                    string cat_name = CatName.Value;
                    string cat_desc = C_des.Value;

                    string query = "delete from CategoryTbl where Catid = '{0}'";
                    query = string.Format(query, Categorylist.SelectedRow.Cells[1].Text);
                    con.SetData(query);
                    showCategories();
                    ErrMsg.Text = "Category Deleted !!";
                    CatName.Value = "";
                    C_des.Value = "";

                }
            }


            catch (Exception ex)
            {
                ErrMsg.Text = ex.Message;
            }
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(CatName.Value == "" || C_des.Value == "")
                {
                    ErrMsg.Text = "Missing Detail!!!";
                }

                else
                {
                    string cat_name = CatName.Value;
                    string cat_desc = C_des.Value;

                    string query = "insert into CategoryTbl values ('{0}' , '{1}')";
                    query = string.Format(query, cat_name, cat_desc);
                    con.SetData(query);
                    showCategories();
                    ErrMsg.Text = "Category inserted !!";
                    CatName.Value = "";
                    C_des.Value = "";

                }
            }


            catch(Exception ex)
            {
                ErrMsg.Text = ex.Message;
            }
        }

        int key = 0;
        protected void Categorylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            CatName.Value = Categorylist.SelectedRow.Cells[2].Text;
            C_des.Value = Categorylist.SelectedRow.Cells[3].Text;

            if(CatName.Value == "" || C_des.Value == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(Categorylist.SelectedRow.Cells[1].Text);
            }
            
        }
    }
}