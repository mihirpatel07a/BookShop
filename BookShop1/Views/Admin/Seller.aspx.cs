using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookShop1.Views.Admin
{
    public partial class Seller : System.Web.UI.Page
    {
        BookShop.Models.functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new BookShop.Models.functions();
            ShowSellers();
        }

        private void ShowSellers()
        {
            string query = "Select * from SellerTbl";
            SellerList.DataSource = Con.GetData(query);
            SellerList.DataBind();
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
         
                if (Sname.Value == "" || Semail.Value == "" || sphone.Value == "" || spassword.Value == "")
                {
                    ErrMsg.Text = "Missing Detail !!";
                }

                else
                {
                    string s_name = Sname.Value;
                    string s_email = Semail.Value;
                    string s_phone = sphone.Value;
                    string s_password = spassword.Value;


                    string query = "insert into SellerTbl values('{0}' , '{1}' , '{2}', '{3}')";
                    query = string.Format(query, s_name, s_email, s_phone, s_password);
                    Con.SetData(query);
                    ShowSellers();
                    ErrMsg.Text = "Seller inserted !!";
                    Sname.Value = "";
                    Semail.Value = "";
                    sphone.Value = "";
                    spassword.Value = "";
                }
               
            }
            catch (Exception ex)
            {

                ErrMsg.Text = ex.Message;
            }

        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (Sname.Value == "" || Semail.Value == "" || sphone.Value == "" || spassword.Value == "")
                {
                    ErrMsg.Text = "Missing Detail !!";
                }

                else
                {
                    string s_name = Sname.Value;
                    string s_email = Semail.Value;
                    string s_phone = sphone.Value;
                    string s_password = spassword.Value;


                    string query = "update SellerTbl set SelName = '{0}' , SelEmail = '{1}' , SelPhone = '{2}' , SelPassword = '{3}' where Selid = '{4}' ";
                    query = string.Format(query, s_name, s_email, s_phone, s_password , SellerList.SelectedRow.Cells[1].Text);
                    Con.SetData(query);
                    ShowSellers();
                    ErrMsg.Text = "Seller Updated !!";
                    Sname.Value = "";
                    Semail.Value = "";
                    sphone.Value = "";
                    spassword.Value = "";
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

                if (Sname.Value == "" || Semail.Value == "" || sphone.Value == "" || spassword.Value == "")
                {
                    ErrMsg.Text = "Missing Detail !!";
                }

                else
                {
                    string s_name = Sname.Value;
                    string s_email = Semail.Value;
                    string s_phone = sphone.Value;
                    string s_password = spassword.Value;


                    string query = "delete from SellerTbl where Selid = '{0}'";
                    query = string.Format(query, SellerList.SelectedRow.Cells[1].Text);
                    Con.SetData(query);
                    ShowSellers();
                    ErrMsg.Text = "Seller Deleted !!";
                    Sname.Value = "";
                    Semail.Value = "";
                    sphone.Value = "";
                    spassword.Value = "";
                }

            }
            catch (Exception ex)
            {

                ErrMsg.Text = ex.Message;
            }


        }

        int key = 0;
        protected void SellerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sname.Value = SellerList.SelectedRow.Cells[2].Text;
            Semail.Value = SellerList.SelectedRow.Cells[3].Text;
            sphone.Value = SellerList.SelectedRow.Cells[4].Text;
            spassword.Value = SellerList.SelectedRow.Cells[5].Text;


            if(Sname.Value == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(SellerList.SelectedRow.Cells[1].Text);
            }
        }
    }
}